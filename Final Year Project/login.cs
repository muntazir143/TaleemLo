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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class login : Form
    {
        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        public login()
        {
            InitializeComponent();
            conn.Open();
        }


        public static string loggedin_username;

        private void login_btn_Click(object sender, EventArgs e)
        {
            string login = "select Username, Password, UserType from Users where Username='"+username_txt.Text.Trim()+"' and Password='"+password_txt.Text.Trim()+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(login, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                //MessageBox.Show("Login Successfull.");
                loggedin_username = username_txt.Text;

                //for (int i=0; i<dataTable.Rows.Count; i++)
                //{
                    if(dataTable.Rows[0]["UserType"].ToString() == usertype_dd.SelectedItem.ToString())
                    {
                        //MessageBox.Show("Login Successful");
                        if(usertype_dd.SelectedIndex == 0)
                        {
                            admin_dashboard admin = new admin_dashboard();
                            admin.Show();
                            this.Hide();
                    }
                        else 
                        {
                            teacher_dashboard teacher = new teacher_dashboard();
                            teacher.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Type Not Valid");
                    }
                //}

                /*switch (usertype_dd.SelectedItem.ToString())
                {
                    case "Admin":
                        {
                            admin_dashboard admin = new admin_dashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "Teacher":
                        {
                            teacher_dashboard teacher = new teacher_dashboard();
                            teacher.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("User Type not valid.");
                        }
                        break;
                }*/
            }
            else
            {
                MessageBox.Show("Login Failed.");
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
