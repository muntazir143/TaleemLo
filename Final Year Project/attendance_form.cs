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
    public partial class attendance_form : Form
    {

        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);
        public attendance_form()
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
                class_cmbbox.ValueMember = "ClassID";
                class_cmbbox.DisplayMember = "CLassName";
                class_cmbbox.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void attendance_form_Load(object sender, EventArgs e)
        {
            class_cmbbox.Items.Clear();
            section_cmbbox.Items.Clear();
            FillClasses();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void class_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                section_cmbbox.DataSource = null;
                section_cmbbox.Items.Clear();
                string query = "select * from Sections where ClassID=@ClassID";
                SqlCommand cmd = new SqlCommand(query, conn);
                string str = "ClassID";
                cmd.Parameters.AddWithValue(str, class_cmbbox.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                section_cmbbox.ValueMember = "SectionID";
                section_cmbbox.DisplayMember = "SectionName";
                section_cmbbox.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                attendance_dgv.DataSource = null;
                if (class_cmbbox.SelectedIndex != -1 && section_cmbbox.SelectedIndex != -1)
                {
                    String attendanceExists = "select count(*) from Attendance where Date='" + date.Value + "' and ClassID='" + Convert.ToInt32(class_cmbbox.SelectedValue.ToString()) + "' and SectionID='" + Convert.ToInt32(section_cmbbox.SelectedValue.ToString()) + "'";
                    SqlCommand cmd = new SqlCommand(attendanceExists, conn);
                    //SqlDataReader reader = cmd.ExecuteReader();
                    int checkifexists = (int)cmd.ExecuteScalar();
                    if (checkifexists > 0)
                    {
                        //MessageBox.Show("IF Part");
                        attendanceExistLabel.Visible = true;
                        //"select s.RollNo, s.Name, AttendanceStatus, Date, ClassID, SectionID from Students s inner join Classes c on c.ClassID=s.ClassID inner join Sections sec on sec.SectionID=s.SectionID left join Attendance a on s.RollNo=a.RollNo where c.ClassID=@ClassID and sec.SectionID=@SectionID and a.Date='" + date.Value + "'"
                        String attendanceWRTDate = "select AttendanceID, AttendanceStatus, Students.RollNo, Name from Students inner join Classes on Classes.ClassID=Students.ClassID inner join Sections on Sections.SectionID=Students.SectionID left join Attendance on Students.RollNo=Attendance.RollNo where Classes.ClassID='" + class_cmbbox.SelectedValue + "' and Sections.SectionID='" + section_cmbbox.SelectedValue + "' and Date='" + date.Value + "'";
                        //SqlCommand cmd1 = new SqlCommand(attendanceWRTDate, conn);
                        //cmd1.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                        //cmd1.Parameters.AddWithValue("@SectionID", section_cmbbox.SelectedValue);
                        //cmd1.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(attendanceWRTDate, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Attendanceid.DataPropertyName = "AttendanceID";
                        Attendance.DataPropertyName = "AttendanceStatus";
                        RollNo.DataPropertyName = "RollNo";
                        Name_col.DataPropertyName = "Name";
                        //Classid.DataPropertyName = "ClassID";
                        //Sectionid.DataPropertyName = "SectionID";
                        
                        attendance_dgv.DataSource = dt;
                        save_btn.Enabled = false;
                        //attendance_dgv.Enabled = false;
                    }
                    else
                    {
                        //MessageBox.Show("Else Part");
                        attendanceExistLabel.Visible = false;
                        save_btn.Enabled = true;
                    //"select Students.RollNo, Name, Classes.ClassID, Sections.SectionID from Students inner join Classes on Classes.ClassID=Students.ClassID inner join Sections on Sections.SectionID=Students.SectionID left join Attendance on Students.RollNo=Attendance.RollNo where Classes.ClassID='" + class_cmbbox.SelectedValue + "' and Sections.SectionID='" + section_cmbbox.SelectedValue + "'"
                    String getAttendanceWRTClassSections = "select RollNo, Name from Students where ClassID='" + class_cmbbox.SelectedValue + "' and SectionID='" + section_cmbbox.SelectedValue + "'";
                        SqlDataAdapter adapter = new SqlDataAdapter(getAttendanceWRTClassSections, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Attendanceid.DataPropertyName = "AttendanceID";
                        Attendance.DataPropertyName = "AttendanceStatus";
                        RollNo.DataPropertyName = dt.Columns["RollNo"].ToString();
                        Name_col.DataPropertyName = dt.Columns["Name"].ToString();
                        //Classid.DataPropertyName = "ClassID";
                        //Sectionid.DataPropertyName = "SectionID";
                        attendance_dgv.DataSource = dt;
                    }
                }
                else if(class_cmbbox.SelectedIndex == -1 && section_cmbbox.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Class & Section");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*try
            {
                string load = "select RollNo, Name from Students where ClassID='" + class_cmbbox.SelectedValue + "' and SectionID='" + section_cmbbox.SelectedValue + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                RollNo.DataPropertyName = dt.Columns["RollNo"].ToString();
                Name_col.DataPropertyName = dt.Columns["Name"].ToString();
                attendance_dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        //int done;
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (class_cmbbox.SelectedIndex!=-1 && section_cmbbox.SelectedIndex!=-1)
            {
                try
                {
                    if (attendance_dgv.Rows.Count > 0)
                    {
                        int count = 0;
                        foreach (DataGridViewRow row in attendance_dgv.Rows)
                        {
                            if (row.Cells["Attendance"].Value == null)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            foreach (DataGridViewRow row in attendance_dgv.Rows)
                            {
                                string save = "insert into Attendance values(@RollNo,@AttendanceStatus,@ClassID,@SectionID,@Date)";
                                SqlCommand cmd = new SqlCommand(save, conn);
                                cmd.Parameters.AddWithValue("@RollNo", row.Cells["RollNo"].Value.ToString());
                                cmd.Parameters.AddWithValue("@AttendanceStatus", row.Cells["Attendance"].Value.ToString());
                                cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                                cmd.Parameters.AddWithValue("@SectionID", section_cmbbox.SelectedValue);
                                cmd.Parameters.AddWithValue("@Date", date.Value);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mark every attendance");
                        }
                    }
                    /*for (int i=0; i<attendance_dgv.RowCount; i++)
                    {
                        string save = "insert into Attendance values(@RollNo,@AttendanceStatus,@ClassID,@SectionID,@Date)";
                        SqlCommand cmd = new SqlCommand(save, conn);
                        cmd.Parameters.AddWithValue("@RollNo", attendance_dgv.Rows[i].Cells["RollNo"].Value.ToString());
                        cmd.Parameters.AddWithValue("@AttendanceStatus", attendance_dgv.Rows[i].Cells["Attendance"].Value.ToString());
                        cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                        cmd.Parameters.AddWithValue("@SectionID", section_cmbbox.SelectedValue);
                        cmd.Parameters.AddWithValue("@Date", date.Value);
                        done = cmd.ExecuteNonQuery();
                    }
                    if (done > 0)
                    {
                        MessageBox.Show("Success");
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void allpresent_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (allpresent_checkbox.Checked)
            {
                for (int i = 0; i < attendance_dgv.RowCount; i++)
                {
                    attendance_dgv.Rows[i].Cells["Attendance"].Value = "P";
                }
            }
            else
            {
                for (int i = 0; i < attendance_dgv.RowCount; i++)
                {
                    attendance_dgv.Rows[i].Cells["Attendance"].Value = "";
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (attendance_dgv.Rows.Count > 0)
                {
                    int count = 0;
                    foreach (DataGridViewRow row in attendance_dgv.Rows)
                    {
                        if (row.Cells["Attendance"].Value == null)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        foreach (DataGridViewRow row in attendance_dgv.Rows)
                        {
                            string update = "update Attendance set AttendanceStatus=@AttendanceStatus where AttendanceID=@AttendanceID";
                            SqlCommand cmd = new SqlCommand(update, conn);
                            cmd.Parameters.AddWithValue("@AttendanceStatus", row.Cells["Attendance"].Value.ToString());
                            cmd.Parameters.AddWithValue("@AttendanceID", row.Cells["Attendanceid"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mark every attendance");
                    }*/
                    for (int i = 0; i < attendance_dgv.RowCount; i++)
                    {
                        string update = "update Attendance set AttendanceStatus=@AttendanceStatus where AttendanceID=@AttendanceID";
                        SqlCommand cmd = new SqlCommand(update, conn);
                    // var check = Attendanceid.DataPropertyName = "AttendanceID";
                    
                        cmd.Parameters.AddWithValue("@AttendanceStatus", attendance_dgv.Rows[i].Cells["Attendance"].Value.ToString());
                        cmd.Parameters.AddWithValue("@AttendanceID", attendance_dgv.Rows[i].Cells["Attendanceid"].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
