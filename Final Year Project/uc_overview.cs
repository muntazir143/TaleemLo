using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Final_Year_Project
{
    public partial class uc_overview : UserControl
    {
        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        public uc_overview()
        {
            InitializeComponent();
            conn.Open();
        }

        public void totalStudents()
        {
            String students = "select count(*) from Students";
            SqlCommand cmd = new SqlCommand(students, conn);
            totalstudents_label.Text = cmd.ExecuteScalar().ToString();
        }

        public void totalTeachers()
        {
            String teachers = "select count(*) from Teachers";
            SqlCommand cmd = new SqlCommand(teachers, conn);
            totalteachers_label.Text = cmd.ExecuteScalar().ToString();
        }

        public void news()
        {
            string newsann = "select top 1 * from Events";
            SqlCommand cmd = new SqlCommand(newsann, conn);
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            eventTitle_label.Text = "EventTitle";
        }

        private void uc_overview_Load(object sender, EventArgs e)
        {
            totalStudents();
            totalTeachers();
            news();
        }

        private void createEvent_btn_Click(object sender, EventArgs e)
        {
            events_dialog ed = new events_dialog();
            ed.ShowDialog();
        }
    }
}
