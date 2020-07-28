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
    class userform_dbmethods
    {
        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region View Data
        public DataTable view()
        {
            SqlConnection conn = new SqlConnection(connstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM users_table";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region Insert Data
        public bool insert(userform_gettersetters gs)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                string sql = "INSERT INTO users_table (first_name, last_name, username, password, contact, email, gender, user_type, added_date) VALUES(@first_name, @last_name, @username, @password, @contact, @email, @gender, @user_type, @added_date)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                /*cmd.Parameters.AddWithValue("@first_name", gs.first_name);
                cmd.Parameters.AddWithValue("@last_name", gs.last_name);
                cmd.Parameters.AddWithValue("@username", gs.username);
                cmd.Parameters.AddWithValue("@password", gs.password);
                cmd.Parameters.AddWithValue("@contact", gs.contact);
                cmd.Parameters.AddWithValue("@email", gs.email);
                cmd.Parameters.AddWithValue("@gender", gs.gender);
                cmd.Parameters.AddWithValue("@user_type", gs.user_type);
                cmd.Parameters.AddWithValue("@added_date", gs.added_date);*/

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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
        #endregion

        #region Update Data
        public bool update(userform_gettersetters gs)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                string sql = "UPDATE users_table SET first_name=@first_name, last_name=@last_name, username=@username, password=@password, contact=@contact, email=@email, gender=@gender, user_type=@user_type, added_date=@added_date WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                /*cmd.Parameters.AddWithValue("@first_name", gs.first_name);
                cmd.Parameters.AddWithValue("@last_name", gs.last_name);
                cmd.Parameters.AddWithValue("@username", gs.username);
                cmd.Parameters.AddWithValue("@password", gs.password);
                cmd.Parameters.AddWithValue("@contact", gs.contact);
                cmd.Parameters.AddWithValue("@email", gs.email);
                cmd.Parameters.AddWithValue("@gender", gs.gender);
                cmd.Parameters.AddWithValue("@user_type", gs.user_type);
                cmd.Parameters.AddWithValue("@added_date", gs.added_date);
                cmd.Parameters.AddWithValue("@id", gs.id);*/

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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
        #endregion

        #region Delete Data
        public bool delete(userform_gettersetters gs)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                string sql = "DELETE FROM users_table WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@id", gs.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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
        #endregion

        #region Search Data
        public DataTable search(string keywords)
        {
            SqlConnection conn = new SqlConnection(connstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM users_table WHERE id LIKE '%"+keywords+ "%' OR first_name LIKE '%" + keywords + "%' OR last_name LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
