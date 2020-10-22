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
    public partial class events_dialog : Form
    {
        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);
        public events_dialog()
        {
            InitializeComponent();
            conn.Open();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void events_dialog_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string insert = "insert into Events(EventTitle, EventDescription) values(@EventTitle, @EventDescription)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@EventTitle", title_txtbox.Text);
            cmd.Parameters.AddWithValue("@EventDescription", desc_txtbox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Event added succesfully");
        }
    }
}
