using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class classes_form : Form
    {
        public classes_form()
        {
            InitializeComponent();
        }

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillBranches()
        {
            try
            {
                conn.Open();
                string query = "select * from Branches";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                branch_cmbbox.ValueMember = "BranchID";
                branch_cmbbox.DisplayMember = "BranchName";
                branch_cmbbox.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void classes_form_Load(object sender, EventArgs e)
        {
            branch_cmbbox.Items.Clear();
            FillBranches();
        }

        private void Clear()
        {
            class_txtbox.Text = "";
            id_txtbox.Text = "";
            branch_cmbbox.SelectedIndex = -1;
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void ViewAll()
        {
            string view = "select ClassID as 'Class ID', ClassName as 'Class Name', BranchName as 'Branch Name' from Classes left join Branches on Classes.BranchID = Branches.BranchID";
            SqlDataAdapter adapter = new SqlDataAdapter(view, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            classes_dgv.DataSource = dt;
        }

        private void classes_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            id_txtbox.Text = classes_dgv.Rows[rowindex].Cells[0].Value.ToString();
            class_txtbox.Text = classes_dgv.Rows[rowindex].Cells[1].Value.ToString();
            branch_cmbbox.Text = classes_dgv.Rows[rowindex].Cells[2].Value.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string insert = "insert into Classes(ClassName,BranchID) values(@ClassName,@BranchID)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@ClassName", class_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@BranchID", branch_cmbbox.SelectedValue);
                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string update = "update Classes set ClassName=@ClassName, BranchID=@BranchID where ClassID=@ClassID";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@ClassID", id_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@ClassName", class_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@BranchID", branch_cmbbox.SelectedValue);

                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string delete = "delete from Classes where ClassID=@ClassID";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.AddWithValue("@ClassID", id_txtbox.Text.Trim());
                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
