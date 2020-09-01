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
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                slider.Width += 4;
                if(slider.Width >= 600)
                {
                    timer1.Stop();
                    login l = new login();
                    this.Hide();
                    l.Show();
                    
                }
            }
            catch (Exception)
            {
                return;
            }

        }
    }
}
