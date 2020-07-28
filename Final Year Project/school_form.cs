using Dapper;
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
    public partial class school_form : Form
    {
        public school_form()
        {
            InitializeComponent();
        }

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                /*DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SchoolName", school_txtbox.Text.Trim());
                parameters.Add("@StatementType", "insert");

                conn.Execute("masterCrudSchool", parameters, commandType: CommandType.StoredProcedure);*/

                string insert = "insert into School(SchoolName) values(@SchoolName)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = school_txtbox.Text.Trim();
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
            school_txtbox.Text = "";
            id_txtbox.Text = "";
        }

        private void ViewAll()
        {
                string view = "select SchoolID as 'School ID', SchoolName as 'School Name' from School";
                SqlDataAdapter adapter = new SqlDataAdapter(view, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                school_dgv.DataSource = dt;
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
                string update = "update School set SchoolName=@SchoolName where SchoolID=@SchoolID";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@SchoolID", SqlDbType.Int).Value = id_txtbox.Text.Trim();
                cmd.Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = school_txtbox.Text.Trim();
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

        private void school_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            id_txtbox.Text = school_dgv.Rows[rowindex].Cells[0].Value.ToString();
            school_txtbox.Text = school_dgv.Rows[rowindex].Cells[1].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string delete = "delete from School where SchoolID=@SchoolID";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@SchoolID", SqlDbType.Int).Value = id_txtbox.Text.Trim();
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
