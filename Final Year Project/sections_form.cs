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
    public partial class sections_form : Form
    {
        public sections_form()
        {
            InitializeComponent();
        }

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        /*public void view()
        {
            List<sectionform_gettersetters> list = conn.Query<sectionform_gettersetters>("sections_view", commandType: CommandType.StoredProcedure).ToList<sectionform_gettersetters>();
            sections_dgv.DataSource = list;
        }*/

        public void FillClasses()
        {
            try
            {
                conn.Open();
                string query = "select * from Classes";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                class_cmbbox.ValueMember = "ClassID";
                class_cmbbox.DisplayMember = "CLassName";
                class_cmbbox.DataSource = ds.Tables[0];
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
            sections_txtbox.Text = "";
            id_txtbox.Text = "";
            class_cmbbox.SelectedIndex = -1;
        }

        private void ViewAll()
        {
            string view = "select SectionID as 'Section ID', SectionName as 'Section Name', ClassName as 'Class Name' from Sections left join Classes on Sections.ClassID = Classes.ClassID";
            SqlDataAdapter adapter = new SqlDataAdapter(view, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sections_dgv.DataSource = dt;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            /*try
            {
                conn.Open();

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@sections", sections_txtbox.Text.Trim());

                conn.Execute("sections_insert", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }*/

            try
            {
                conn.Open();
                string insert = "insert into Sections(SectionName,ClassID) values(@SectionName,@ClassID)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@SectionName", sections_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
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

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sections_form_Load(object sender, EventArgs e)
        {
            class_cmbbox.Items.Clear();
            FillClasses();
        }

        private void sections_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            id_txtbox.Text = sections_dgv.Rows[rowindex].Cells[0].Value.ToString();
            sections_txtbox.Text = sections_dgv.Rows[rowindex].Cells[1].Value.ToString();
            class_cmbbox.Text = sections_dgv.Rows[rowindex].Cells[2].Value.ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string update = "update Sections set SectionName=@SectionName, ClassID=@ClassID where SectionID=@SectionID";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@SectionID", id_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@SectionName", sections_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);

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
                string delete = "delete from Sections where SectionID=@SectionID";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.AddWithValue("@SectionID", id_txtbox.Text.Trim());
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
