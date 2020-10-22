using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FeeReportsViewer : Form
    {

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        public FeeReportsViewer()
        {
            InitializeComponent();
            conn.Open();
        }

        public void FillClasses()
        {
            try
            {
                string query = "select * from Classes";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                //class_cmbbox.ValueMember = "ClassID";
                //class_cmbbox.DisplayMember = "CLassName";
                //class_cmbbox.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FeeReportsViewer_Load(object sender, EventArgs e)
        {
            //class_cmbbox.Items.Clear();
            FillClasses();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            showReport();
        }

        ReportDocument reportDocument;

        private void showReport()
        {
            try
            {
                reportDocument = new ReportDocument();
                SqlCommand cmd = new SqlCommand("getMonthlyStudentFee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                //cmd.Parameters.AddWithValue("@Month", month_year.Value.Month);
                //cmd.Parameters.AddWithValue("@Year", month_year.Value.Year);
                SqlDataReader reader = cmd.ExecuteReader();
                reportDocument.Load("FeeVoucherReport.rpt");
                reportDocument.SetDataSource(reader.FieldCount);
                crystalReportViewer1.ReportSource = reportDocument;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
