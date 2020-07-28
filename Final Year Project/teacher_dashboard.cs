using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class teacher_dashboard : Form
    {
        public teacher_dashboard()
        {
            InitializeComponent();
        }

        private void ChangeablePanels(Control c)
        {
            c.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(c);
        }

        private void uc_overview_btn_Click(object sender, EventArgs e)
        {
            uc_overview overview = new uc_overview();
            ChangeablePanels(overview);
        }

        private void uc_dashboard_btn_Click(object sender, EventArgs e)
        {
            uc_teacher_dashboard dashboard = new uc_teacher_dashboard();
            ChangeablePanels(dashboard);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void teacher_dashboard_Load(object sender, EventArgs e)
        {
            lbl_loggedin.Text = login.loggedin_username;
        }
    }
}
