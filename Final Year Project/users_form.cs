using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class users_form : Form
    {
        public users_form()
        {
            InitializeComponent();
            conn.Open();
        }

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        public void view()
        {
            string view = "select UserID, Name, Gender, Mobile, Username, Password, UserType from Users";
            SqlDataAdapter adapter = new SqlDataAdapter(view, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            users_dgv.DataSource = dt;
        }

        public void Clear()
        {
            id_txtbox.Text = "";
            firstname_txtbox.Text = "";
            username_txtbox.Text = "";
            password_txtbox.Text = "";
            contact_txtbox.Text = "";
            email_txtbox.Text = "";
            gender_dd.Text = "";
            usertype_dd.Text = "";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into Users(Name,Gender,DOB,Mobile,Username,Password,UserType) values(@Name,@Gender,@DOB,@Mobile,@Username,@Password,@UserType)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@Name", firstname_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", gender_dd.SelectedItem);
                cmd.Parameters.AddWithValue("@DOB", DateTime.Now);
                cmd.Parameters.AddWithValue("@Mobile", contact_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Username", username_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", password_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@UserType", usertype_dd.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                Clear();
                view();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            view();
        }
      
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@id", id_txtbox.Text);

                conn.Execute("users_delete", parameters, commandType: CommandType.StoredProcedure);
                view();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void users_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id_txtbox.Text = users_dgv.Rows[rowIndex].Cells[0].Value.ToString();
            firstname_txtbox.Text = users_dgv.Rows[rowIndex].Cells[1].Value.ToString();
            username_txtbox.Text = users_dgv.Rows[rowIndex].Cells[2].Value.ToString();
            password_txtbox.Text = users_dgv.Rows[rowIndex].Cells[3].Value.ToString();
            contact_txtbox.Text = users_dgv.Rows[rowIndex].Cells[4].Value.ToString();
            email_txtbox.Text = users_dgv.Rows[rowIndex].Cells[5].Value.ToString();
            gender_dd.Text = users_dgv.Rows[rowIndex].Cells[6].Value.ToString();
            usertype_dd.Text = users_dgv.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void update_btn_Click(object sender, EventArgs e)
        {
            gs.id = Convert.ToInt32(id_txtbox.Text);
            gs.first_name = firstname_txtbox.Text;
            gs.last_name = lastname_txtbox.Text;
            gs.username = username_txtbox.Text;
            gs.password = password_txtbox.Text;
            gs.contact = contact_txtbox.Text;
            gs.email = email_txtbox.Text;
            gs.gender = gender_dd.selectedValue.ToString();
            gs.user_type = usertype_dd.selectedValue.ToString();
            gs.added_date = DateTime.Now;

            bool success = db.update(gs);

            if (success == true)
            {
                MessageBox.Show("User updated successfully.");
                clear();
            }
            else
            {
                MessageBox.Show("Transaction not successfull.");
            }
            DataTable dt = db.view();
            users_dgv.DataSource = dt;
        }

        private void search_txt_OnTextChange(object sender, EventArgs e)
        {
            string keywords = search_txt.Text;

            if (keywords != null)
            {
                DataTable dt = db.search(keywords);
                users_dgv.DataSource = dt;
            }
            else
            {
                DataTable dt = db.view();
                users_dgv.DataSource = dt;
            }
        }*/
    }
}
