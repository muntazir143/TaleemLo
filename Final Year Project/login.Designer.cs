namespace Final_Year_Project
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.usertype_dd = new System.Windows.Forms.ComboBox();
            this.login_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.password_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.username_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.close_btn);
            this.bunifuGradientPanel1.Controls.Add(this.usertype_dd);
            this.bunifuGradientPanel1.Controls.Add(this.login_btn);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.password_txt);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.username_txt);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(600, 400);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // usertype_dd
            // 
            this.usertype_dd.FormattingEnabled = true;
            this.usertype_dd.Items.AddRange(new object[] {
            "Admin",
            "Teacher"});
            this.usertype_dd.Location = new System.Drawing.Point(160, 286);
            this.usertype_dd.Name = "usertype_dd";
            this.usertype_dd.Size = new System.Drawing.Size(281, 21);
            this.usertype_dd.TabIndex = 9;
            // 
            // login_btn
            // 
            this.login_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.BorderRadius = 0;
            this.login_btn.ButtonText = "Login";
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.DisabledColor = System.Drawing.Color.Gray;
            this.login_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.login_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("login_btn.Iconimage")));
            this.login_btn.Iconimage_right = null;
            this.login_btn.Iconimage_right_Selected = null;
            this.login_btn.Iconimage_Selected = null;
            this.login_btn.IconMarginLeft = 0;
            this.login_btn.IconMarginRight = 0;
            this.login_btn.IconRightVisible = true;
            this.login_btn.IconRightZoom = 0D;
            this.login_btn.IconVisible = true;
            this.login_btn.IconZoom = 90D;
            this.login_btn.IsTab = false;
            this.login_btn.Location = new System.Drawing.Point(218, 329);
            this.login_btn.Name = "login_btn";
            this.login_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.login_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.login_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.login_btn.selected = false;
            this.login_btn.Size = new System.Drawing.Size(148, 48);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "Login";
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.Textcolor = System.Drawing.Color.White;
            this.login_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(237, 242);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(98, 23);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "User Type";
            // 
            // password_txt
            // 
            this.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_txt.HintForeColor = System.Drawing.Color.Empty;
            this.password_txt.HintText = "Password...";
            this.password_txt.isPassword = true;
            this.password_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.password_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.password_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.password_txt.LineThickness = 3;
            this.password_txt.Location = new System.Drawing.Point(160, 178);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(281, 44);
            this.password_txt.TabIndex = 4;
            this.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(230, 135);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(96, 23);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(230, 28);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 23);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // username_txt
            // 
            this.username_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_txt.HintForeColor = System.Drawing.Color.Empty;
            this.username_txt.HintText = "Username...";
            this.username_txt.isPassword = false;
            this.username_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.username_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.username_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.username_txt.LineThickness = 3;
            this.username_txt.Location = new System.Drawing.Point(160, 71);
            this.username_txt.Margin = new System.Windows.Forms.Padding(4);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(281, 44);
            this.username_txt.TabIndex = 0;
            this.username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(556, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 34);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 10;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton login_btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ComboBox usertype_dd;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
    }
}

