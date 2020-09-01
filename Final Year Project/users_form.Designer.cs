namespace Final_Year_Project
{
    partial class users_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users_form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.id_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.firstname_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.contact_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.email_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.users_dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label11 = new System.Windows.Forms.Label();
            this.add_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.view_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gender_dd = new System.Windows.Forms.ComboBox();
            this.usertype_dd = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users";
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(990, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 34);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 2;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // id_txtbox
            // 
            this.id_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.id_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.id_txtbox.BorderThickness = 3;
            this.id_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_txtbox.isPassword = false;
            this.id_txtbox.Location = new System.Drawing.Point(143, 82);
            this.id_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(250, 35);
            this.id_txtbox.TabIndex = 4;
            this.id_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // firstname_txtbox
            // 
            this.firstname_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.firstname_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstname_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.firstname_txtbox.BorderThickness = 3;
            this.firstname_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstname_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstname_txtbox.isPassword = false;
            this.firstname_txtbox.Location = new System.Drawing.Point(144, 128);
            this.firstname_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.firstname_txtbox.Name = "firstname_txtbox";
            this.firstname_txtbox.Size = new System.Drawing.Size(250, 35);
            this.firstname_txtbox.TabIndex = 6;
            this.firstname_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // username_txtbox
            // 
            this.username_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.username_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.username_txtbox.BorderThickness = 3;
            this.username_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_txtbox.isPassword = false;
            this.username_txtbox.Location = new System.Drawing.Point(144, 177);
            this.username_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(250, 35);
            this.username_txtbox.TabIndex = 10;
            this.username_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username";
            // 
            // password_txtbox
            // 
            this.password_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.password_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.password_txtbox.BorderThickness = 3;
            this.password_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_txtbox.isPassword = false;
            this.password_txtbox.Location = new System.Drawing.Point(144, 223);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(250, 35);
            this.password_txtbox.TabIndex = 12;
            this.password_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // contact_txtbox
            // 
            this.contact_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.contact_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contact_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.contact_txtbox.BorderThickness = 3;
            this.contact_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contact_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contact_txtbox.isPassword = false;
            this.contact_txtbox.Location = new System.Drawing.Point(144, 269);
            this.contact_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.contact_txtbox.Name = "contact_txtbox";
            this.contact_txtbox.Size = new System.Drawing.Size(250, 35);
            this.contact_txtbox.TabIndex = 14;
            this.contact_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contact No.";
            // 
            // email_txtbox
            // 
            this.email_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.email_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.email_txtbox.BorderThickness = 3;
            this.email_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_txtbox.isPassword = false;
            this.email_txtbox.Location = new System.Drawing.Point(144, 315);
            this.email_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(250, 35);
            this.email_txtbox.TabIndex = 16;
            this.email_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Gender";
            // 
            // users_dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.users_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.users_dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.users_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.users_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.users_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dgv.DoubleBuffered = true;
            this.users_dgv.EnableHeadersVisualStyles = false;
            this.users_dgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.users_dgv.HeaderForeColor = System.Drawing.Color.White;
            this.users_dgv.Location = new System.Drawing.Point(411, 82);
            this.users_dgv.Name = "users_dgv";
            this.users_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.users_dgv.Size = new System.Drawing.Size(601, 407);
            this.users_dgv.TabIndex = 20;
            this.users_dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.users_dgv_RowHeaderMouseDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 469);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "User Type";
            // 
            // add_btn
            // 
            this.add_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_btn.BorderRadius = 0;
            this.add_btn.ButtonText = "Add";
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.DisabledColor = System.Drawing.Color.Gray;
            this.add_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.add_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("add_btn.Iconimage")));
            this.add_btn.Iconimage_right = null;
            this.add_btn.Iconimage_right_Selected = null;
            this.add_btn.Iconimage_Selected = null;
            this.add_btn.IconMarginLeft = 0;
            this.add_btn.IconMarginRight = 0;
            this.add_btn.IconRightVisible = true;
            this.add_btn.IconRightZoom = 0D;
            this.add_btn.IconVisible = true;
            this.add_btn.IconZoom = 90D;
            this.add_btn.IsTab = false;
            this.add_btn.Location = new System.Drawing.Point(401, 543);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.add_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.add_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.add_btn.selected = false;
            this.add_btn.Size = new System.Drawing.Size(140, 35);
            this.add_btn.TabIndex = 25;
            this.add_btn.Text = "Add";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Textcolor = System.Drawing.Color.White;
            this.add_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_btn.BorderRadius = 0;
            this.update_btn.ButtonText = "Update";
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.DisabledColor = System.Drawing.Color.Gray;
            this.update_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.update_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("update_btn.Iconimage")));
            this.update_btn.Iconimage_right = null;
            this.update_btn.Iconimage_right_Selected = null;
            this.update_btn.Iconimage_Selected = null;
            this.update_btn.IconMarginLeft = 0;
            this.update_btn.IconMarginRight = 0;
            this.update_btn.IconRightVisible = true;
            this.update_btn.IconRightZoom = 0D;
            this.update_btn.IconVisible = true;
            this.update_btn.IconZoom = 90D;
            this.update_btn.IsTab = false;
            this.update_btn.Location = new System.Drawing.Point(556, 543);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(140, 35);
            this.update_btn.TabIndex = 26;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Textcolor = System.Drawing.Color.White;
            this.update_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // delete_btn
            // 
            this.delete_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_btn.BorderRadius = 0;
            this.delete_btn.ButtonText = "Delete";
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.DisabledColor = System.Drawing.Color.Gray;
            this.delete_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.delete_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("delete_btn.Iconimage")));
            this.delete_btn.Iconimage_right = null;
            this.delete_btn.Iconimage_right_Selected = null;
            this.delete_btn.Iconimage_Selected = null;
            this.delete_btn.IconMarginLeft = 0;
            this.delete_btn.IconMarginRight = 0;
            this.delete_btn.IconRightVisible = true;
            this.delete_btn.IconRightZoom = 0D;
            this.delete_btn.IconVisible = true;
            this.delete_btn.IconZoom = 90D;
            this.delete_btn.IsTab = false;
            this.delete_btn.Location = new System.Drawing.Point(716, 543);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.delete_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.delete_btn.selected = false;
            this.delete_btn.Size = new System.Drawing.Size(140, 35);
            this.delete_btn.TabIndex = 27;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Textcolor = System.Drawing.Color.White;
            this.delete_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // view_btn
            // 
            this.view_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.view_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.view_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_btn.BorderRadius = 0;
            this.view_btn.ButtonText = "View";
            this.view_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_btn.DisabledColor = System.Drawing.Color.Gray;
            this.view_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.view_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("view_btn.Iconimage")));
            this.view_btn.Iconimage_right = null;
            this.view_btn.Iconimage_right_Selected = null;
            this.view_btn.Iconimage_Selected = null;
            this.view_btn.IconMarginLeft = 0;
            this.view_btn.IconMarginRight = 0;
            this.view_btn.IconRightVisible = true;
            this.view_btn.IconRightZoom = 0D;
            this.view_btn.IconVisible = true;
            this.view_btn.IconZoom = 90D;
            this.view_btn.IsTab = false;
            this.view_btn.Location = new System.Drawing.Point(872, 543);
            this.view_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.view_btn.Name = "view_btn";
            this.view_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.view_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.view_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.view_btn.selected = false;
            this.view_btn.Size = new System.Drawing.Size(140, 35);
            this.view_btn.TabIndex = 31;
            this.view_btn.Text = "View";
            this.view_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_btn.Textcolor = System.Drawing.Color.White;
            this.view_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gender_dd
            // 
            this.gender_dd.FormattingEnabled = true;
            this.gender_dd.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_dd.Location = new System.Drawing.Point(144, 417);
            this.gender_dd.Name = "gender_dd";
            this.gender_dd.Size = new System.Drawing.Size(249, 24);
            this.gender_dd.TabIndex = 34;
            // 
            // usertype_dd
            // 
            this.usertype_dd.FormattingEnabled = true;
            this.usertype_dd.Items.AddRange(new object[] {
            "Admin",
            "Teacher"});
            this.usertype_dd.Location = new System.Drawing.Point(144, 461);
            this.usertype_dd.Name = "usertype_dd";
            this.usertype_dd.Size = new System.Drawing.Size(249, 24);
            this.usertype_dd.TabIndex = 35;
            // 
            // users_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.Controls.Add(this.usertype_dd);
            this.Controls.Add(this.gender_dd);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.users_dgv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contact_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstname_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "users_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "users_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox id_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox email_txtbox;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox contact_txtbox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox password_txtbox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox username_txtbox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox firstname_txtbox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid users_dgv;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuFlatButton delete_btn;
        private Bunifu.Framework.UI.BunifuFlatButton update_btn;
        private Bunifu.Framework.UI.BunifuFlatButton add_btn;
        private Bunifu.Framework.UI.BunifuFlatButton view_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox gender_dd;
        private System.Windows.Forms.ComboBox usertype_dd;
    }
}