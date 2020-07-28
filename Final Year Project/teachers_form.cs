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
    public partial class teachers_form : Form
    {
        public teachers_form()
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

        private void teachers_form_Load(object sender, EventArgs e)
        {
            branch_cmbbox.Items.Clear();
            FillBranches();
        }

        private void Clear()
        {
            name_txtbox.Text = "";
            id_txtbox.Text = "";
            branch_cmbbox.SelectedIndex = -1;
            gender_cmbbox.SelectedIndex = -1;
            mobile_txtbox.Text = "";
            cnic_txtbox.Text = "";
            qualification_txtbox.Text = "";
            email_txtbox.Text = "";
            password_txtbox.Text = "";
            joiningDate.Value = DateTime.Now;
        }

        private void ViewAll()
        {
            string view = "select TeacherID as 'Teacher ID', Name, Gender, Mobile, CNIC, Qualification, Email, Password, JoiningDate as 'Joining Date', BranchName as 'Branch Name' from Teachers left join Branches on Teachers.BranchID = Branches.BranchID";
            SqlDataAdapter adapter = new SqlDataAdapter(view, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            teachers_dgv.DataSource = dt;
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void teachers_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            id_txtbox.Text = teachers_dgv.Rows[rowindex].Cells[0].Value.ToString();
            name_txtbox.Text = teachers_dgv.Rows[rowindex].Cells[1].Value.ToString();
            gender_cmbbox.Text = teachers_dgv.Rows[rowindex].Cells[2].Value.ToString();
            mobile_txtbox.Text = teachers_dgv.Rows[rowindex].Cells[3].Value.ToString();
            cnic_txtbox.Text = teachers_dgv.Rows[rowindex].Cells[4].Value.ToString();
            qualification_txtbox.Text = teachers_dgv.Rows[rowindex].Cells[5].Value.ToString();
            email_txtbox.Text = teachers_dgv.Rows[rowindex].Cells[6].Value.ToString();
            password_txtbox.Text = teachers_dgv.Rows[rowindex].Cells[7].Value.ToString();
            joiningDate.Value = DateTime.Parse(teachers_dgv.Rows[rowindex].Cells[8].Value.ToString());
            branch_cmbbox.Text = teachers_dgv.Rows[rowindex].Cells[9].Value.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string insert = "insert into Teachers(Name,Gender,Mobile,CNIC,Qualification,Email,Password,JoiningDate,BranchID) values(@Name,@Gender,@Mobile,@CNIC,@Qualification,@Email,@Password,@JoiningDate,@BranchID)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@Name", name_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", gender_cmbbox.SelectedItem);
                cmd.Parameters.AddWithValue("@Mobile", mobile_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@CNIC", cnic_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Qualification", qualification_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", email_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", password_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@JoiningDate", joiningDate.Value);
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
                string update = "update Teachers set Name=@Name, Gender=@Gender, Mobile=@Mobile, CNIC=@CNIC, Qualification=@Qualification, Email=@Email, Password=@Password, JoiningDate=@JoiningDate ,BranchID=@BranchID where TeacherID=@TeacherID";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@TeacherID", id_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", name_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", gender_cmbbox.SelectedItem);
                cmd.Parameters.AddWithValue("@Mobile", mobile_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@CNIC", cnic_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Qualification", qualification_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", email_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", password_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@JoiningDate", joiningDate.Value);
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
                string delete = "delete from Teachers where TeacherID=@TeacherID";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.AddWithValue("@TeacherID", id_txtbox.Text.Trim());
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
