using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
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
            uc_admin_dashboard dashboard = new uc_admin_dashboard();
            ChangeablePanels(dashboard);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            lbl_loggedin.Text = login.loggedin_username;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            uc_about_school about_School = new uc_about_school();
            ChangeablePanels(about_School);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo fb = new ProcessStartInfo("www.facebook.com");
            Process.Start(fb);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo insta = new ProcessStartInfo("www.instagram.com");
            Process.Start(insta);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo whatsapp = new ProcessStartInfo("www.whatsapp.com");
            Process.Start(whatsapp);
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            events_dialog ed = new events_dialog();
            ed.ShowDialog();
        }
    }
}
