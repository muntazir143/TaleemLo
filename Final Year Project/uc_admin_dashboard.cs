using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class uc_admin_dashboard : UserControl
    {
        public uc_admin_dashboard()
        {
            InitializeComponent();
        }

        private void students_btn_Click(object sender, EventArgs e)
        {
            students_form studentsForm = new students_form();
            studentsForm.Show();
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            users_form uf = new users_form();
            uf.Show();
        }

        private void sections_btn_Click(object sender, EventArgs e)
        {
            sections_form sf = new sections_form();
            sf.Show();
        }

        private void school_btn_Click(object sender, EventArgs e)
        {
            school_form school_Form = new school_form();
            school_Form.Show();
        }

        private void branches_btn_Click(object sender, EventArgs e)
        {
            branch_form branch_Form = new branch_form();
            branch_Form.Show();
        }

        private void class_btn_Click(object sender, EventArgs e)
        {
            classes_form classes_Form = new classes_form();
            classes_Form.Show();
        }

        private void teachers_btn_Click(object sender, EventArgs e)
        {
            teachers_form teachers_Form = new teachers_form();
            teachers_Form.Show();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            attendance_form attendance_Form = new attendance_form();
            attendance_Form.Show();
        }

        private void feeStructure_btn_Click(object sender, EventArgs e)
        {
            fees_form fees_Form = new fees_form();
            fees_Form.Show();
        }
    }
}
