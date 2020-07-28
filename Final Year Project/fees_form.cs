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
    public partial class fees_form : Form
    {

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        public fees_form()
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

        private void fees_form_Load(object sender, EventArgs e)
        {
            class_cmbbox.Items.Clear();
            FillClasses();
        }

        private void admissionFee_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthly_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void miscellaneous_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Clear()
        {
            admissionFee_txtbox.Text = "";
            class_cmbbox.SelectedIndex = -1;
            miscellaneous_txtbox.Text = "";
            monthly_txtbox.Text = "";
        }

        private void feeStructure_dgv_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            class_cmbbox.Text = feeStructure_dgv.Rows[rowindex].Cells[1].Value.ToString();
            admissionFee_txtbox.Text = feeStructure_dgv.Rows[rowindex].Cells[2].Value.ToString();
            monthly_txtbox.Text = feeStructure_dgv.Rows[rowindex].Cells[3].Value.ToString();
            miscellaneous_txtbox.Text = feeStructure_dgv.Rows[rowindex].Cells[4].Value.ToString();
        }

        private void ViewAll()
        {
            string view = "select FeeID, ClassName as 'Class', AdmissionFee as 'Admission Fee', MonthlyFee as 'MonthlyFee', MiscellaneousFee as 'Miscellaneous Fee' from FeeStructure left join Classes on FeeStructure.ClassID = Classes.ClassID";
            SqlDataAdapter adapter = new SqlDataAdapter(view, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            feeStructure_dgv.DataSource = dt;
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into FeeStructure(ClassID, AdmissionFee, MonthlyFee, MiscellaneousFee) values(@ClassID, @AdmissionFee, @MonthlyFee, @MiscellaneousFee)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                cmd.Parameters.AddWithValue("@AdmissionFee", admissionFee_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@MonthlyFee", monthly_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@MiscellaneousFee", miscellaneous_txtbox.Text.Trim());

                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //string check = FeeID.DataPropertyName = "FeeID";
                string update = "update FeeStructure set ClassID=@ClassID, AdmissionFee=@AdmissionFee, MonthlyFee=@MonthlyFee, MiscellaneousFee=@MiscellaneousFee where FeeID='"+ feeStructure_dgv.Rows[0].Cells["FeeID"].Value + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                //cmd.Parameters.AddWithValue("@AttendanceID", feeStructure_dgv.Rows[0].Cells["FeeID"].Value);
                cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                cmd.Parameters.AddWithValue("@AdmissionFee", admissionFee_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@MonthlyFee", monthly_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@MiscellaneousFee", miscellaneous_txtbox.Text.Trim());

                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from FeeStructure FeeID='" + feeStructure_dgv.Rows[0].Cells["FeeID"].Value + "'";
                SqlCommand cmd = new SqlCommand(delete, conn);

                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
