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

        /*public void FillClasses()
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
        }*/

        private void fee_voucher_form_Load(object sender, EventArgs e)
        {
            //class_cmbbox.Items.Clear();
            //FillClasses();
        }

        private void class_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string save = "insert into FeeVoucher values(@RollNo,@ClassName,@Month,@Year,@DueDate,@MonthlyFee,@AdmissionFee,@LateFee,@MiscellaneousFee)";
                SqlCommand cmd = new SqlCommand(save, conn);
                cmd.Parameters.AddWithValue("@RollNo", roll_txtbox.Text);
                cmd.Parameters.AddWithValue("@ClassName", class_txtbox.Text);
                cmd.Parameters.AddWithValue("@Month", month_year.Value.Month);
                cmd.Parameters.AddWithValue("@Year", month_year.Value.Year);
                cmd.Parameters.AddWithValue("@DueDate", duedate.Value);
                cmd.Parameters.AddWithValue("@MonthlyFee", monthly_txtbox.Text);
                cmd.Parameters.AddWithValue("@AdmissionFee", admissionFee_checkbox.Checked ? admissionFee_txtbox.Text : "0");
                cmd.Parameters.AddWithValue("@LateFee", lateFee_checkbox.Checked ? lateFee_txtbox.Text : "0");
                cmd.Parameters.AddWithValue("@MiscellaneousFee", miscellaneousFee_checkbox.Checked ? miscFee_txtbox.Text : "0");
                cmd.ExecuteNonQuery();
                view();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reports_btn_Click(object sender, EventArgs e)
        {
            FeeReportsViewer feeReportsViewer = new FeeReportsViewer();
            feeReportsViewer.Show();
        }

        public void ok_btn_Click(object sender, EventArgs e)
        {
            if(roll_txtbox.Text != "")
            {
                string query = "select s.Name, c.ClassName, f.MonthlyFee, f.LateFee, AdmissionFee, MiscellaneousFee from Students s inner join Classes c on s.ClassID = c.ClassID inner join FeeStructure f on c.ClassID = f.ClassID where s.RollNo = '" + roll_txtbox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name_txtbox.Text = reader.GetValue(0).ToString();
                    class_txtbox.Text = reader.GetValue(1).ToString();
                    monthly_txtbox.Text = reader.GetValue(2).ToString();
                    lateFee_txtbox.Text = reader.GetValue(3).ToString();
                    admissionFee_txtbox.Text = reader.GetValue(4).ToString();
                    miscFee_txtbox.Text = reader.GetValue(4).ToString();
                    reader.Close();
                    //string getData = "select ClassName as 'Class Name', Month, Year, DueDate as 'Due Date', MonthlyFee as 'Monthly Fee', LateFee as 'LateFee', AdmissionFee as 'Admission Fee', MiscellaneousFee as 'Miscellaneous Fee' from FeeVoucher where RollNo = '"+ roll_txtbox.Text  + "'";
                    //SqlCommand cmd1 = new SqlCommand(getData, conn);
                    //SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                    //DataTable dt = new DataTable();
                    //adapter.Fill(dt);
                    //feevoucher_dgv.DataSource = dt;
                    view();
                }
                else
                {
                    MessageBox.Show("Student not found...");
                }
            }
            else
            {
                name_txtbox.Text = "";
                class_txtbox.Text = "";
                monthly_txtbox.Text = "";
            }
        }

        public void view()
        {
            string getData = "select ClassName as 'Class Name', Month, Year, DueDate as 'Due Date', MonthlyFee as 'Monthly Fee', LateFee as 'LateFee', AdmissionFee as 'Admission Fee', MiscellaneousFee as 'Miscellaneous Fee' from FeeVoucher where RollNo = '" + roll_txtbox.Text + "'";
            SqlCommand cmd1 = new SqlCommand(getData, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            feevoucher_dgv.DataSource = dt;
        }
    }
}
