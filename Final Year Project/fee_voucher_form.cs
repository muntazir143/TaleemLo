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
                feeVoucherID.DataPropertyName = "FeeVoucherID";
                name.DataPropertyName = "Name";
                feevoucher_dgv.DataSource = dt;
                string monthlyFee = "select MonthlyFee as 'Monthly Fee' from FeeStructure where FeeStructure.ClassID='"+ class_cmbbox.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(monthlyFee, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    monthly_txtbox.Text = reader.GetValue(0).ToString();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
