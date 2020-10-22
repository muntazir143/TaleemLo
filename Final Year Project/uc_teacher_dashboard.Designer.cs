namespace Final_Year_Project
{
    partial class uc_teacher_dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_teacher_dashboard));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(18, 37);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(125, 25);
            this.bunifuCustomLabel3.TabIndex = 22;
            this.bunifuCustomLabel3.Text = "Dashboard";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(133, 37);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(828, 35);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 18;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 38;
            this.bunifuTileButton1.LabelText = "Attendance";
            this.bunifuTileButton1.Location = new System.Drawing.Point(68, 116);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 27;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // uc_teacher_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "uc_teacher_dashboard";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}
