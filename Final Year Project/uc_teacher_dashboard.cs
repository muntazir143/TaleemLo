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
    public partial class uc_teacher_dashboard : UserControl
    {
        public uc_teacher_dashboard()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            attendance_form attendance_Form = new attendance_form();
            attendance_Form.Show();
        }
    }
}
