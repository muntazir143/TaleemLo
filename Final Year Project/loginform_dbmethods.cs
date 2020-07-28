using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    class loginform_dbmethods
    {
        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool login(loginform_gettersetters gs)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                string sql = "SELECT * FROM users_table WHERE username=@username AND password=@password AND user_type=@user_type";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", gs.username);
                cmd.Parameters.AddWithValue("@password", gs.password);
                cmd.Parameters.AddWithValue("@user_type", gs.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
