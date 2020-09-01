namespace Final_Year_Project
{
    partial class FeeReportsViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeReportsViewer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.class_cmbbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.month_year = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.load_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.load_btn);
            this.panel1.Controls.Add(this.month_year);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.class_cmbbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 536);
            this.panel1.TabIndex = 0;
            // 
            // class_cmbbox
            // 
            this.class_cmbbox.FormattingEnabled = true;
            this.class_cmbbox.Location = new System.Drawing.Point(111, 135);
            this.class_cmbbox.Name = "class_cmbbox";
            this.class_cmbbox.Size = new System.Drawing.Size(191, 21);
            this.class_cmbbox.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "Class";
            // 
            // month_year
            // 
            this.month_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.month_year.BorderRadius = 0;
            this.month_year.ForeColor = System.Drawing.Color.White;
            this.month_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_year.FormatCustom = "MMM-yyyy";
            this.month_year.Location = new System.Drawing.Point(114, 185);
            this.month_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.month_year.Name = "month_year";
            this.month_year.Size = new System.Drawing.Size(191, 38);
            this.month_year.TabIndex = 91;
            this.month_year.Value = new System.DateTime(2020, 6, 16, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 90;
            this.label10.Text = "Month/Year";
            // 
            // load_btn
            // 
            this.load_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.load_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_btn.BorderRadius = 0;
            this.load_btn.ButtonText = "Load";
            this.load_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_btn.DisabledColor = System.Drawing.Color.Gray;
            this.load_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.load_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("load_btn.Iconimage")));
            this.load_btn.Iconimage_right = null;
            this.load_btn.Iconimage_right_Selected = null;
            this.load_btn.Iconimage_Selected = null;
            this.load_btn.IconMarginLeft = 0;
            this.load_btn.IconMarginRight = 0;
            this.load_btn.IconRightVisible = true;
            this.load_btn.IconRightZoom = 0D;
            this.load_btn.IconVisible = true;
            this.load_btn.IconZoom = 90D;
            this.load_btn.IsTab = false;
            this.load_btn.Location = new System.Drawing.Point(62, 265);
            this.load_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.load_btn.Name = "load_btn";
            this.load_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.load_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.load_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.load_btn.selected = false;
            this.load_btn.Size = new System.Drawing.Size(154, 38);
            this.load_btn.TabIndex = 104;
            this.load_btn.Text = "Load";
            this.load_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.load_btn.Textcolor = System.Drawing.Color.White;
            this.load_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(305, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(816, 536);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // FeeReportsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 536);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FeeReportsViewer";
            this.Text = "FeeReportsViewer";
            this.Load += new System.EventHandler(this.FeeReportsViewer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox class_cmbbox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker month_year;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuFlatButton load_btn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}