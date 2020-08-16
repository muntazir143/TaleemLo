namespace Final_Year_Project
{
    partial class students_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(students_form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.section_cmbbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.rollno_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.students_dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.fathername_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender_cmbbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dob = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.mobile_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.admissionDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label8 = new System.Windows.Forms.Label();
            this.class_cmbbox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.view_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.add_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.search_cmbbox = new System.Windows.Forms.ComboBox();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.print_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.image_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.students_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(1085, 23);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 34);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 1;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 80);
            this.panel1.TabIndex = 2;
            // 
            // section_cmbbox
            // 
            this.section_cmbbox.FormattingEnabled = true;
            this.section_cmbbox.Location = new System.Drawing.Point(111, 541);
            this.section_cmbbox.Name = "section_cmbbox";
            this.section_cmbbox.Size = new System.Drawing.Size(250, 24);
            this.section_cmbbox.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Section";
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
            this.name_txtbox.Location = new System.Drawing.Point(111, 160);
            this.name_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(250, 35);
            this.name_txtbox.TabIndex = 62;
            this.name_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "Name";
            // 
            // rollno_txtbox
            // 
            this.rollno_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.rollno_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollno_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.rollno_txtbox.BorderThickness = 3;
            this.rollno_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rollno_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rollno_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollno_txtbox.isPassword = false;
            this.rollno_txtbox.Location = new System.Drawing.Point(111, 108);
            this.rollno_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.rollno_txtbox.Name = "rollno_txtbox";
            this.rollno_txtbox.Size = new System.Drawing.Size(250, 35);
            this.rollno_txtbox.TabIndex = 60;
            this.rollno_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Roll No.";
            // 
            // students_dgv
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.students_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.students_dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.students_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.students_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.students_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.students_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students_dgv.DoubleBuffered = true;
            this.students_dgv.EnableHeadersVisualStyles = false;
            this.students_dgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.students_dgv.HeaderForeColor = System.Drawing.Color.White;
            this.students_dgv.Location = new System.Drawing.Point(399, 169);
            this.students_dgv.Name = "students_dgv";
            this.students_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.students_dgv.Size = new System.Drawing.Size(704, 457);
            this.students_dgv.TabIndex = 65;
            this.students_dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.students_dgv_RowHeaderMouseDoubleClick);
            // 
            // fathername_txtbox
            // 
            this.fathername_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.fathername_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fathername_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.fathername_txtbox.BorderThickness = 3;
            this.fathername_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fathername_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fathername_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fathername_txtbox.isPassword = false;
            this.fathername_txtbox.Location = new System.Drawing.Point(111, 216);
            this.fathername_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.fathername_txtbox.Name = "fathername_txtbox";
            this.fathername_txtbox.Size = new System.Drawing.Size(250, 35);
            this.fathername_txtbox.TabIndex = 67;
            this.fathername_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Father Name";
            // 
            // gender_cmbbox
            // 
            this.gender_cmbbox.FormattingEnabled = true;
            this.gender_cmbbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_cmbbox.Location = new System.Drawing.Point(111, 276);
            this.gender_cmbbox.Name = "gender_cmbbox";
            this.gender_cmbbox.Size = new System.Drawing.Size(250, 24);
            this.gender_cmbbox.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Gender";
            // 
            // dob
            // 
            this.dob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.dob.BorderRadius = 0;
            this.dob.ForeColor = System.Drawing.Color.White;
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dob.FormatCustom = null;
            this.dob.Location = new System.Drawing.Point(111, 320);
            this.dob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(250, 38);
            this.dob.TabIndex = 71;
            this.dob.Value = new System.DateTime(2020, 6, 7, 22, 4, 21, 641);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "DOB";
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
            this.mobile_txtbox.Location = new System.Drawing.Point(111, 376);
            this.mobile_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.mobile_txtbox.Name = "mobile_txtbox";
            this.mobile_txtbox.Size = new System.Drawing.Size(250, 35);
            this.mobile_txtbox.TabIndex = 73;
            this.mobile_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Mobile";
            // 
            // admissionDate
            // 
            this.admissionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.admissionDate.BorderRadius = 0;
            this.admissionDate.ForeColor = System.Drawing.Color.White;
            this.admissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.admissionDate.FormatCustom = null;
            this.admissionDate.Location = new System.Drawing.Point(111, 431);
            this.admissionDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.admissionDate.Name = "admissionDate";
            this.admissionDate.Size = new System.Drawing.Size(250, 39);
            this.admissionDate.TabIndex = 75;
            this.admissionDate.Value = new System.DateTime(2020, 6, 7, 22, 4, 21, 641);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Admission Date";
            // 
            // class_cmbbox
            // 
            this.class_cmbbox.FormattingEnabled = true;
            this.class_cmbbox.Location = new System.Drawing.Point(111, 492);
            this.class_cmbbox.Name = "class_cmbbox";
            this.class_cmbbox.Size = new System.Drawing.Size(250, 24);
            this.class_cmbbox.TabIndex = 77;
            this.class_cmbbox.SelectedIndexChanged += new System.EventHandler(this.class_cmbbox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 76;
            this.label9.Text = "Class";
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
            this.view_btn.Location = new System.Drawing.Point(973, 651);
            this.view_btn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.view_btn.Name = "view_btn";
            this.view_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.view_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.view_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.view_btn.selected = false;
            this.view_btn.Size = new System.Drawing.Size(130, 43);
            this.view_btn.TabIndex = 81;
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
            this.delete_btn.Location = new System.Drawing.Point(828, 651);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.delete_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.delete_btn.selected = false;
            this.delete_btn.Size = new System.Drawing.Size(130, 43);
            this.delete_btn.TabIndex = 80;
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
            this.update_btn.Location = new System.Drawing.Point(683, 651);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(130, 43);
            this.update_btn.TabIndex = 79;
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
            this.add_btn.Location = new System.Drawing.Point(538, 651);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.add_btn.Name = "add_btn";
            this.add_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.add_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.add_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.add_btn.selected = false;
            this.add_btn.Size = new System.Drawing.Size(130, 43);
            this.add_btn.TabIndex = 78;
            this.add_btn.Text = "Add";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Textcolor = System.Drawing.Color.White;
            this.add_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // search_cmbbox
            // 
            this.search_cmbbox.FormattingEnabled = true;
            this.search_cmbbox.Items.AddRange(new object[] {
            "Name",
            "Roll No.",
            "Father Name",
            "Class"});
            this.search_cmbbox.Location = new System.Drawing.Point(399, 115);
            this.search_cmbbox.Name = "search_cmbbox";
            this.search_cmbbox.Size = new System.Drawing.Size(210, 24);
            this.search_cmbbox.TabIndex = 82;
            // 
            // search_txtbox
            // 
            this.search_txtbox.Location = new System.Drawing.Point(657, 118);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(188, 21);
            this.search_txtbox.TabIndex = 83;
            this.search_txtbox.TextChanged += new System.EventHandler(this.search_txtbox_TextChanged);
            // 
            // print_btn
            // 
            this.print_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.print_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print_btn.BorderRadius = 0;
            this.print_btn.ButtonText = "Print";
            this.print_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print_btn.DisabledColor = System.Drawing.Color.Gray;
            this.print_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.print_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("print_btn.Iconimage")));
            this.print_btn.Iconimage_right = null;
            this.print_btn.Iconimage_right_Selected = null;
            this.print_btn.Iconimage_Selected = null;
            this.print_btn.IconMarginLeft = 0;
            this.print_btn.IconMarginRight = 0;
            this.print_btn.IconRightVisible = true;
            this.print_btn.IconRightZoom = 0D;
            this.print_btn.IconVisible = true;
            this.print_btn.IconZoom = 90D;
            this.print_btn.IsTab = false;
            this.print_btn.Location = new System.Drawing.Point(390, 651);
            this.print_btn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.print_btn.Name = "print_btn";
            this.print_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.print_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.print_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.print_btn.selected = false;
            this.print_btn.Size = new System.Drawing.Size(130, 43);
            this.print_btn.TabIndex = 84;
            this.print_btn.Text = "Print";
            this.print_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.print_btn.Textcolor = System.Drawing.Color.White;
            this.print_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // image_btn
            // 
            this.image_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.image_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.image_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_btn.BorderRadius = 0;
            this.image_btn.ButtonText = "Open";
            this.image_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image_btn.DisabledColor = System.Drawing.Color.Gray;
            this.image_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.image_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("image_btn.Iconimage")));
            this.image_btn.Iconimage_right = null;
            this.image_btn.Iconimage_right_Selected = null;
            this.image_btn.Iconimage_Selected = null;
            this.image_btn.IconMarginLeft = 0;
            this.image_btn.IconMarginRight = 0;
            this.image_btn.IconRightVisible = true;
            this.image_btn.IconRightZoom = 0D;
            this.image_btn.IconVisible = true;
            this.image_btn.IconZoom = 90D;
            this.image_btn.IsTab = false;
            this.image_btn.Location = new System.Drawing.Point(24, 614);
            this.image_btn.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.image_btn.Name = "image_btn";
            this.image_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.image_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.image_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.image_btn.selected = false;
            this.image_btn.Size = new System.Drawing.Size(120, 40);
            this.image_btn.TabIndex = 85;
            this.image_btn.Text = "Open";
            this.image_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.image_btn.Textcolor = System.Drawing.Color.White;
            this.image_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_btn.Click += new System.EventHandler(this.image_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(160, 584);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // students_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.image_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.search_cmbbox);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.class_cmbbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.admissionDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mobile_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gender_cmbbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fathername_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.students_dgv);
            this.Controls.Add(this.section_cmbbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rollno_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "students_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmissionForm";
            this.Load += new System.EventHandler(this.students_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.students_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox section_cmbbox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox name_txtbox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox rollno_txtbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid students_dgv;
        private Bunifu.Framework.UI.BunifuMetroTextbox fathername_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gender_cmbbox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker admissionDate;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox mobile_txtbox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker dob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox class_cmbbox;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton view_btn;
        private Bunifu.Framework.UI.BunifuFlatButton delete_btn;
        private Bunifu.Framework.UI.BunifuFlatButton update_btn;
        private Bunifu.Framework.UI.BunifuFlatButton add_btn;
        private System.Windows.Forms.ComboBox search_cmbbox;
        private System.Windows.Forms.TextBox search_txtbox;
        private Bunifu.Framework.UI.BunifuFlatButton print_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton image_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}