using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        loginform_gettersetters gs = new loginform_gettersetters();
        loginform_dbmethods db = new loginform_dbmethods();

        public static string loggedin_username;

        private void login_btn_Click(object sender, EventArgs e)
        {
            gs.username = username_txt.Text.Trim();
            gs.password = password_txt.Text.Trim();
            gs.user_type = usertype_dd.SelectedItem.ToString();

            bool success = db.login(gs);

            if(success == true)
            {
                MessageBox.Show("Login Successfull.");
                loggedin_username = gs.username;

                switch (gs.user_type)
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
                }
            }
            else
            {
                MessageBox.Show("Login Failed.");
            }
        }
    }
}
