namespace Final_Year_Project
{
    partial class teachers_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teachers_form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.name_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.teachers_dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mobile_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.qualification_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.cnic_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.email_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.password_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.branch_cmbbox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.view_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.add_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gender_cmbbox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.joiningDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_dgv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1033, 68);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teachers";
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(989, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 34);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 2;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // name_txtbox
            // 
            this.name_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.name_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.name_txtbox.BorderThickness = 3;
            this.name_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_txtbox.isPassword = false;
            this.name_txtbox.Location = new System.Drawing.Point(101, 149);
            this.name_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(250, 35);
            this.name_txtbox.TabIndex = 18;
            this.name_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
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
            this.id_txtbox.Location = new System.Drawing.Point(101, 97);
            this.id_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(250, 35);
            this.id_txtbox.TabIndex = 16;
            this.id_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // teachers_dgv
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teachers_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.teachers_dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.teachers_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teachers_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teachers_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.teachers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachers_dgv.DoubleBuffered = true;
            this.teachers_dgv.EnableHeadersVisualStyles = false;
            this.teachers_dgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.teachers_dgv.HeaderForeColor = System.Drawing.Color.White;
            this.teachers_dgv.Location = new System.Drawing.Point(381, 97);
            this.teachers_dgv.Name = "teachers_dgv";
            this.teachers_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.teachers_dgv.Size = new System.Drawing.Size(625, 457);
            this.teachers_dgv.TabIndex = 19;
            this.teachers_dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.teachers_dgv_RowHeaderMouseDoubleClick);
            // 
            // mobile_txtbox
            // 
            this.mobile_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.mobile_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mobile_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.mobile_txtbox.BorderThickness = 3;
            this.mobile_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobile_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mobile_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mobile_txtbox.isPassword = false;
            this.mobile_txtbox.Location = new System.Drawing.Point(101, 246);
            this.mobile_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.mobile_txtbox.Name = "mobile_txtbox";
            this.mobile_txtbox.Size = new System.Drawing.Size(250, 35);
            this.mobile_txtbox.TabIndex = 23;
            this.mobile_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mobile";
            // 
            // qualification_txtbox
            // 
            this.qualification_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.qualification_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qualification_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.qualification_txtbox.BorderThickness = 3;
            this.qualification_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qualification_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.qualification_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qualification_txtbox.isPassword = false;
            this.qualification_txtbox.Location = new System.Drawing.Point(101, 356);
            this.qualification_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.qualification_txtbox.Name = "qualification_txtbox";
            this.qualification_txtbox.Size = new System.Drawing.Size(250, 35);
            this.qualification_txtbox.TabIndex = 27;
            this.qualification_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Qualification";
            // 
            // cnic_txtbox
            // 
            this.cnic_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.cnic_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnic_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.cnic_txtbox.BorderThickness = 3;
            this.cnic_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnic_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cnic_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnic_txtbox.isPassword = false;
            this.cnic_txtbox.Location = new System.Drawing.Point(101, 304);
            this.cnic_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.cnic_txtbox.Name = "cnic_txtbox";
            this.cnic_txtbox.Size = new System.Drawing.Size(250, 35);
            this.cnic_txtbox.TabIndex = 25;
            this.cnic_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "CNIC";
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
            this.email_txtbox.Location = new System.Drawing.Point(101, 413);
            this.email_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(250, 35);
            this.email_txtbox.TabIndex = 31;
            this.email_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Joining Date";
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
            this.password_txtbox.Location = new System.Drawing.Point(101, 468);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(250, 35);
            this.password_txtbox.TabIndex = 33;
            this.password_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Password";
            // 
            // branch_cmbbox
            // 
            this.branch_cmbbox.FormattingEnabled = true;
            this.branch_cmbbox.Location = new System.Drawing.Point(101, 583);
            this.branch_cmbbox.Name = "branch_cmbbox";
            this.branch_cmbbox.Size = new System.Drawing.Size(250, 21);
            this.branch_cmbbox.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Branch";
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
            this.view_btn.Location = new System.Drawing.Point(866, 584);
            this.view_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.view_btn.Name = "view_btn";
            this.view_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.view_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.view_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.view_btn.selected = false;
            this.view_btn.Size = new System.Drawing.Size(140, 35);
            this.view_btn.TabIndex = 66;
            this.view_btn.Text = "View";
            this.view_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_btn.Textcolor = System.Drawing.Color.White;
            this.view_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
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
            this.delete_btn.Location = new System.Drawing.Point(706, 584);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.delete_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.delete_btn.selected = false;
            this.delete_btn.Size = new System.Drawing.Size(140, 35);
            this.delete_btn.TabIndex = 65;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Textcolor = System.Drawing.Color.White;
            this.delete_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
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
            this.update_btn.Location = new System.Drawing.Point(543, 584);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(140, 35);
            this.update_btn.TabIndex = 64;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Textcolor = System.Drawing.Color.White;
            this.update_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
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
            this.add_btn.Location = new System.Drawing.Point(381, 584);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.add_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.add_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.add_btn.selected = false;
            this.add_btn.Size = new System.Drawing.Size(140, 35);
            this.add_btn.TabIndex = 63;
            this.add_btn.Text = "Add";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Textcolor = System.Drawing.Color.White;
            this.add_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // gender_cmbbox
            // 
            this.gender_cmbbox.FormattingEnabled = true;
            this.gender_cmbbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_cmbbox.Location = new System.Drawing.Point(101, 208);
            this.gender_cmbbox.Name = "gender_cmbbox";
            this.gender_cmbbox.Size = new System.Drawing.Size(250, 21);
            this.gender_cmbbox.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 67;
            this.label12.Text = "Gender";
            // 
            // joiningDate
            // 
            this.joiningDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.joiningDate.BorderRadius = 0;
            this.joiningDate.ForeColor = System.Drawing.Color.White;
            this.joiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.joiningDate.FormatCustom = null;
            this.joiningDate.Location = new System.Drawing.Point(101, 518);
            this.joiningDate.Name = "joiningDate";
            this.joiningDate.Size = new System.Drawing.Size(250, 36);
            this.joiningDate.TabIndex = 69;
            this.joiningDate.Value = new System.DateTime(2020, 6, 7, 22, 4, 21, 641);
            // 
            // teachers_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 662);
            this.Controls.Add(this.joiningDate);
            this.Controls.Add(this.gender_cmbbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.branch_cmbbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.qualification_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cnic_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mobile_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teachers_dgv);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teachers_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teachers_form";
            this.Load += new System.EventHandler(this.teachers_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox name_txtbox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox id_txtbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid teachers_dgv;
        private Bunifu.Framework.UI.BunifuMetroTextbox mobile_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox password_txtbox;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox email_txtbox;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox qualification_txtbox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox cnic_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox branch_cmbbox;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton view_btn;
        private Bunifu.Framework.UI.BunifuFlatButton delete_btn;
        private Bunifu.Framework.UI.BunifuFlatButton update_btn;
        private Bunifu.Framework.UI.BunifuFlatButton add_btn;
        private System.Windows.Forms.ComboBox gender_cmbbox;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuDatepicker joiningDate;
    }
}