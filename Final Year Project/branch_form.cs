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
    public partial class branch_form : Form
    {
        public branch_form()
        {
            InitializeComponent();
        }

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillSchool()
        {
            try
            {
                conn.Open();
                string query = "select * from School";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                school_cmbbox.ValueMember = "SchoolID";
                school_cmbbox.DisplayMember = "SchoolName";
                school_cmbbox.DataSource = ds.Tables[0];

                //DataTable dt = new DataTable();

                /*foreach (DataRow dr in dt.Rows)
                {
                    school_cmbbox.Items.Add(dr[1]);
                }*/
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string insert = "insert into Branches(BranchName,SchoolID) values(@BranchName,@SchoolID)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@BranchName", branch_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@SchoolID", school_cmbbox.SelectedValue);
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

        private void Clear()
        {
            branch_txtbox.Text = "";
            id_txtbox.Text = "";
            school_cmbbox.SelectedIndex = -1;
        }

        private void ViewAll()
        {
            string view = "select BranchID as 'Branch ID', BranchName as 'Branch Name', SchoolName as 'School Name' from Branches left join School on Branches.SchoolID = School.SchoolID";
            SqlDataAdapter adapter = new SqlDataAdapter(view, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            branches_dgv.DataSource = dt;
        }

        private void branch_form_Load(object sender, EventArgs e)
        {
            school_cmbbox.Items.Clear();
            FillSchool();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string update = "update Branches set BranchName=@BranchName, SchoolID=@SchoolID where BranchID=@BranchID";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@BranchID", id_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@BranchName", branch_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@SchoolID", school_cmbbox.SelectedValue);

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

        private void branches_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            id_txtbox.Text = branches_dgv.Rows[rowindex].Cells[0].Value.ToString();
            branch_txtbox.Text = branches_dgv.Rows[rowindex].Cells[1].Value.ToString();
            school_cmbbox.Text = branches_dgv.Rows[rowindex].Cells[2].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string delete = "delete from Branches where BranchID=@BranchID";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.AddWithValue("@BranchID", id_txtbox.Text.Trim());
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