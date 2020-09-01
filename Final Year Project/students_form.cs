using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class students_form : Form
    {
        static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        String fileName;
        

        public students_form()
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
                //conn.Open();
                string query = "select * from Classes";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                class_cmbbox.ValueMember = "ClassID";
                class_cmbbox.DisplayMember = "CLassName";
                class_cmbbox.DataSource = ds.Tables[0];
                //conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void students_form_Load(object sender, EventArgs e)
        {
            class_cmbbox.Items.Clear();
            section_cmbbox.Items.Clear();
            FillClasses();
            Student_Roll();
        }

        public void class_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //conn.Open();
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
            finally
            {
                //conn.Close();
            }
        }

        private void Clear()
        {
            name_txtbox.Text = "";
            int a = Convert.ToInt32(rollno_txtbox.Text);
            a++;
            rollno_txtbox.Text = a.ToString();
            fathername_txtbox.Text = "";
            class_cmbbox.SelectedIndex = -1;
            section_cmbbox.SelectedIndex = -1;
            gender_cmbbox.SelectedIndex = -1;
            mobile_txtbox.Text = "";
            dob.Value = DateTime.Now;
            admissionDate.Value = DateTime.Now;
        }

        Image BinaryToImage(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream(data);
            return Image.FromStream(memoryStream);
        }

        private void students_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            rollno_txtbox.Text = students_dgv.Rows[rowindex].Cells[0].Value.ToString();
            name_txtbox.Text = students_dgv.Rows[rowindex].Cells[1].Value.ToString();
            fathername_txtbox.Text = students_dgv.Rows[rowindex].Cells[2].Value.ToString();
            gender_cmbbox.Text = students_dgv.Rows[rowindex].Cells[3].Value.ToString();
            dob.Value = DateTime.Parse(students_dgv.Rows[rowindex].Cells[4].Value.ToString());
            mobile_txtbox.Text = students_dgv.Rows[rowindex].Cells[5].Value.ToString();
            admissionDate.Value = DateTime.Parse(students_dgv.Rows[rowindex].Cells[6].Value.ToString());
            class_cmbbox.Text = students_dgv.Rows[rowindex].Cells[7].Value.ToString();
            section_cmbbox.Text = students_dgv.Rows[rowindex].Cells[8].Value.ToString();
            pictureBox1.Image = BinaryToImage((byte[])students_dgv.Rows[rowindex].Cells[9].Value);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ViewAll()
        {
            string view = "select RollNo as 'Roll Number', Name, FathersName as 'Father Name', Gender, DOB, Mobile, AdmissionDate as 'Admission Date',ClassName as 'Class', SectionName as 'Section', Image from Students left join Classes on Students.ClassID = Classes.ClassID left join Sections on Students.SectionID = Sections.SectionID";
            SqlDataAdapter adapter = new SqlDataAdapter(view, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            students_dgv.DataSource = dt;
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            var imageData = ImagetoBinary(pictureBox1.Image);
            
            try
            {
                //conn.Open();
                
                string insert = "insert into Students(RollNo,Name,FathersName,Gender,DOB,Mobile,AdmissionDate,ClassID,SectionID,Image,StdPassword) values(@RollNo,@Name,@FathersName,@Gender,@DOB,@Mobile,@AdmissionDate,@ClassID,@SectionID,@Image,@StdPassword)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@RollNo", rollno_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", name_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@FathersName", fathername_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", gender_cmbbox.SelectedItem);
                cmd.Parameters.AddWithValue("@DOB", dob.Value);
                cmd.Parameters.AddWithValue("@Mobile", mobile_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@AdmissionDate", admissionDate.Value);
                cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                cmd.Parameters.AddWithValue("@SectionID", section_cmbbox.SelectedValue);
                cmd.Parameters.AddWithValue("@StdPassword", "pass123");
                cmd.Parameters.AddWithValue("@Image", imageData);
                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //conn.Close();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var updatedImage = ImagetoBinary(pictureBox1.Image);
            try
            {
                //conn.Open();
                string update = "update Students set Name=@Name, FathersName=@FathersName, Gender=@Gender, DOB=@DOB, Mobile=@Mobile, AdmissionDate=@AdmissionDate, ClassID=@ClassID, SectionID=@SectionID, Image=@Image where RollNo=@RollNo";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@RollNo", rollno_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", name_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@FathersName", fathername_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", gender_cmbbox.SelectedItem);
                cmd.Parameters.AddWithValue("@DOB", dob.Value);
                cmd.Parameters.AddWithValue("@Mobile", mobile_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@AdmissionDate", admissionDate.Value);
                cmd.Parameters.AddWithValue("@ClassID", class_cmbbox.SelectedValue);
                cmd.Parameters.AddWithValue("@SectionID", section_cmbbox.SelectedValue);
                cmd.Parameters.AddWithValue("@Image", updatedImage);
                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //conn.Close();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //conn.Open();
                string delete = "delete from Students where RollNo=@RollNo";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.AddWithValue("@RollNo", rollno_txtbox.Text.Trim());
                cmd.ExecuteNonQuery();
                Clear();
                ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //conn.Close();
            }
        }

        public void Student_Roll()
        {
            try
            {
                int rollno;

                //conn.Open();
                string studentroll = "select top 1 RollNo from Students order by RollNo desc";
                SqlCommand cmd = new SqlCommand(studentroll, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    //MessageBox.Show("Data read");
                    string value = dataReader["RollNo"].ToString();
                    if (!(value == ""))
                    {
                        rollno = Convert.ToInt32(dataReader["RollNo"].ToString());
                        rollno = rollno + 1;
                        rollno_txtbox.Text = rollno.ToString();
                    }
                    dataReader.Close();
                }
                else
                {
                    rollno_txtbox.Text = "1000";
                    //rollno = 1000;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //conn.Close();
            }
        }


        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = students_dgv.DataSource;

            if(search_cmbbox.Text == "Name")
            {
                bindingSource.Filter = "Name like '%" + search_txtbox.Text + "%'";
                students_dgv.DataSource = bindingSource;
            }
        }

        void reportGenerator()
        {
            //SqlCommand cmd = new SqlCommand(conn);
            //DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Students", conn);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            //students_dgv.DataSource = dataTable;
            StudentsFormReport studentsFormReport = new StudentsFormReport();
            studentsFormReport.SetDataSource(dataSet);

            StudentFormReportViewer studentFormReportViewer = new StudentFormReportViewer();
            studentFormReportViewer.StudentReportViewer.ReportSource = studentsFormReport;
            studentFormReportViewer.ShowDialog();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            reportGenerator();
        }

        public void image_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                var fileSize = new FileInfo(fileName);
             
                if(fileSize.Length > 30720)
                {
                    MessageBox.Show("Select Image less than 30kb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(fileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        //Convert Image to binary
        byte[] ImagetoBinary(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }


    }
}
