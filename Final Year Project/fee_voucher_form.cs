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
    public partial class fee_voucher_form : Form
    {

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        public fee_voucher_form()
        {
            InitializeComponent();
            conn.Open();
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                class_cmbbox.ValueMember = "ClassID";
                class_cmbbox.DisplayMember = "CLassName";
                class_cmbbox.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fee_voucher_form_Load(object sender, EventArgs e)
        {
            class_cmbbox.Items.Clear();
            FillClasses();
        }

        private void class_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                feevoucher_dgv.DataSource = null;

                string query = "select RollNo as 'Roll No', Name from Students inner join Classes on Classes.ClassID=Students.ClassID where Classes.ClassID='"+class_cmbbox.SelectedValue+"'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
              
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //feeVoucherID.DataPropertyName = "FeeVoucherID";
                //RollNo.DataPropertyName = "RollNo";
                //name.DataPropertyName = "Name";
                feevoucher_dgv.DataSource = dt;
                string monthlyFee = "select MonthlyFee,LateFee from FeeStructure where FeeStructure.ClassID='"+ class_cmbbox.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(monthlyFee, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    monthly_txtbox.Text = reader.GetValue(0).ToString();
                    late_txtbox.Text = reader.GetValue(1).ToString();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            byte admissionFeeStatus = admissionFee_checkbox.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
            byte miscellaneousFeeStatus = miscellaneousFee_checkbox.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
            foreach (DataGridViewRow row in feevoucher_dgv.Rows)
            {
                float discount;
                if(row.Cells["discount"].Value == null || row.Cells["discount"].Value.ToString() == "")
                {
                    discount = 0;
                }
                else
                {
                    discount = Convert.ToSingle(row.Cells["discount"].Value.ToString());
                }
                string save = "insert into FeeVoucher values(@RollNo,@ClassID,@Month,@Year,@DueDate,@PaidWithInDueDate,@MonthlyFeeStatus,@AdmissionFeeStatus,@MiscellaneousFeeStatus,@Discount)";
                SqlCommand cmd = new SqlCommand(save, conn);
                cmd.Parameters.AddWithValue("@RollNo", row.Cells["RollNo"].Value.ToString());
                //cmd.Parameters.AddWithValue("@AttendanceStatus", row.Cells["Attendance"].Value.ToString());
                cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                cmd.Parameters.AddWithValue("@Month", month_year.Value.Month);
                cmd.Parameters.AddWithValue("@Year", month_year.Value.Year);
                cmd.Parameters.AddWithValue("@DueDate", duedate.Value);
                cmd.Parameters.AddWithValue("@PaidWithInDueDate", 0);
                cmd.Parameters.AddWithValue("@MonthlyFeeStatus", 0);
                cmd.Parameters.AddWithValue("@AdmissionFeeStatus", 0);
                cmd.Parameters.AddWithValue("@MiscellaneousFeeStatus", 0);
                cmd.Parameters.AddWithValue("@Discount", discount);

                cmd.ExecuteNonQuery();

            }
        }

        private void reports_btn_Click(object sender, EventArgs e)
        {
            FeeReportsViewer feeReportsViewer = new FeeReportsViewer();
            feeReportsViewer.Show();
        }
    }
}
