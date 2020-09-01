namespace Final_Year_Project
{
    partial class fee_voucher_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fee_voucher_form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.class_cmbbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthly_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.month_year = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.duedate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.feevoucher_dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.delete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.admissionFee_checkbox = new System.Windows.Forms.CheckBox();
            this.miscellaneousFee_checkbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.late_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.reports_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feevoucher_dgv)).BeginInit();
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
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 80);
            this.panel1.TabIndex = 5;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(1025, 23);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 34);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 1;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Voucher";
            // 
            // class_cmbbox
            // 
            this.class_cmbbox.FormattingEnabled = true;
            this.class_cmbbox.Location = new System.Drawing.Point(145, 130);
            this.class_cmbbox.Name = "class_cmbbox";
            this.class_cmbbox.Size = new System.Drawing.Size(250, 21);
            this.class_cmbbox.TabIndex = 83;
            this.class_cmbbox.SelectedIndexChanged += new System.EventHandler(this.class_cmbbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "Class";
            // 
            // monthly_txtbox
            // 
            this.monthly_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.monthly_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monthly_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.monthly_txtbox.BorderThickness = 3;
            this.monthly_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.monthly_txtbox.Enabled = false;
            this.monthly_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.monthly_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monthly_txtbox.isPassword = false;
            this.monthly_txtbox.Location = new System.Drawing.Point(145, 177);
            this.monthly_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.monthly_txtbox.Name = "monthly_txtbox";
            this.monthly_txtbox.Size = new System.Drawing.Size(250, 35);
            this.monthly_txtbox.TabIndex = 87;
            this.monthly_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Monthly";
            // 
            // month_year
            // 
            this.month_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.month_year.BorderRadius = 0;
            this.month_year.ForeColor = System.Drawing.Color.White;
            this.month_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_year.FormatCustom = "MMM-yyyy";
            this.month_year.Location = new System.Drawing.Point(145, 298);
            this.month_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.month_year.Name = "month_year";
            this.month_year.Size = new System.Drawing.Size(250, 38);
            this.month_year.TabIndex = 89;
            this.month_year.Value = new System.DateTime(2020, 6, 16, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 88;
            this.label10.Text = "Select Month/Year";
            // 
            // duedate
            // 
            this.duedate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.duedate.BorderRadius = 0;
            this.duedate.ForeColor = System.Drawing.Color.White;
            this.duedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.duedate.FormatCustom = "dd-MMM-yyyy";
            this.duedate.Location = new System.Drawing.Point(145, 366);
            this.duedate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.duedate.Name = "duedate";
            this.duedate.Size = new System.Drawing.Size(250, 38);
            this.duedate.TabIndex = 91;
            this.duedate.Value = new System.DateTime(2020, 6, 16, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Due Date";
            // 
            // feevoucher_dgv
            // 
            this.feevoucher_dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.feevoucher_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.feevoucher_dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.feevoucher_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feevoucher_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feevoucher_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.feevoucher_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feevoucher_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discount});
            this.feevoucher_dgv.DoubleBuffered = true;
            this.feevoucher_dgv.EnableHeadersVisualStyles = false;
            this.feevoucher_dgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.feevoucher_dgv.HeaderForeColor = System.Drawing.Color.White;
            this.feevoucher_dgv.Location = new System.Drawing.Point(426, 130);
            this.feevoucher_dgv.Name = "feevoucher_dgv";
            this.feevoucher_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.feevoucher_dgv.Size = new System.Drawing.Size(612, 412);
            this.feevoucher_dgv.TabIndex = 92;
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
            this.delete_btn.Location = new System.Drawing.Point(891, 564);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.delete_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.delete_btn.selected = false;
            this.delete_btn.Size = new System.Drawing.Size(147, 43);
            this.delete_btn.TabIndex = 95;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Textcolor = System.Drawing.Color.White;
            this.delete_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.update_btn.Location = new System.Drawing.Point(713, 564);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(146, 43);
            this.update_btn.TabIndex = 94;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Textcolor = System.Drawing.Color.White;
            this.update_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // save_btn
            // 
            this.save_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_btn.BorderRadius = 0;
            this.save_btn.ButtonText = "Save";
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.DisabledColor = System.Drawing.Color.Gray;
            this.save_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.save_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("save_btn.Iconimage")));
            this.save_btn.Iconimage_right = null;
            this.save_btn.Iconimage_right_Selected = null;
            this.save_btn.Iconimage_Selected = null;
            this.save_btn.IconMarginLeft = 0;
            this.save_btn.IconMarginRight = 0;
            this.save_btn.IconRightVisible = true;
            this.save_btn.IconRightZoom = 0D;
            this.save_btn.IconVisible = true;
            this.save_btn.IconZoom = 90D;
            this.save_btn.IsTab = false;
            this.save_btn.Location = new System.Drawing.Point(535, 564);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.save_btn.Name = "save_btn";
            this.save_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.save_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.save_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.save_btn.selected = false;
            this.save_btn.Size = new System.Drawing.Size(154, 43);
            this.save_btn.TabIndex = 93;
            this.save_btn.Text = "Save";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Textcolor = System.Drawing.Color.White;
            this.save_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // admissionFee_checkbox
            // 
            this.admissionFee_checkbox.AutoSize = true;
            this.admissionFee_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionFee_checkbox.Location = new System.Drawing.Point(47, 505);
            this.admissionFee_checkbox.Name = "admissionFee_checkbox";
            this.admissionFee_checkbox.Size = new System.Drawing.Size(120, 19);
            this.admissionFee_checkbox.TabIndex = 97;
            this.admissionFee_checkbox.Text = "Admission Fee";
            this.admissionFee_checkbox.UseVisualStyleBackColor = true;
            // 
            // miscellaneousFee_checkbox
            // 
            this.miscellaneousFee_checkbox.AutoSize = true;
            this.miscellaneousFee_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscellaneousFee_checkbox.Location = new System.Drawing.Point(47, 573);
            this.miscellaneousFee_checkbox.Name = "miscellaneousFee_checkbox";
            this.miscellaneousFee_checkbox.Size = new System.Drawing.Size(147, 19);
            this.miscellaneousFee_checkbox.TabIndex = 98;
            this.miscellaneousFee_checkbox.Text = "Miscellaneous Fee";
            this.miscellaneousFee_checkbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 99;
            this.label5.Text = "Select these to include:";
            // 
            // late_txtbox
            // 
            this.late_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.late_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.late_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.late_txtbox.BorderThickness = 3;
            this.late_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.late_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.late_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.late_txtbox.isPassword = false;
            this.late_txtbox.Location = new System.Drawing.Point(145, 238);
            this.late_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.late_txtbox.Name = "late_txtbox";
            this.late_txtbox.Size = new System.Drawing.Size(250, 35);
            this.late_txtbox.TabIndex = 101;
            this.late_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 100;
            this.label6.Text = "Late";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(47, 539);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 19);
            this.checkBox1.TabIndex = 102;
            this.checkBox1.Text = "Late Fee";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // reports_btn
            // 
            this.reports_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reports_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.reports_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reports_btn.BorderRadius = 0;
            this.reports_btn.ButtonText = "Reports";
            this.reports_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reports_btn.DisabledColor = System.Drawing.Color.Gray;
            this.reports_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.reports_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("reports_btn.Iconimage")));
            this.reports_btn.Iconimage_right = null;
            this.reports_btn.Iconimage_right_Selected = null;
            this.reports_btn.Iconimage_Selected = null;
            this.reports_btn.IconMarginLeft = 0;
            this.reports_btn.IconMarginRight = 0;
            this.reports_btn.IconRightVisible = true;
            this.reports_btn.IconRightZoom = 0D;
            this.reports_btn.IconVisible = true;
            this.reports_btn.IconZoom = 90D;
            this.reports_btn.IsTab = false;
            this.reports_btn.Location = new System.Drawing.Point(359, 564);
            this.reports_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.reports_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.reports_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reports_btn.selected = false;
            this.reports_btn.Size = new System.Drawing.Size(154, 43);
            this.reports_btn.TabIndex = 103;
            this.reports_btn.Text = "Reports";
            this.reports_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reports_btn.Textcolor = System.Drawing.Color.White;
            this.reports_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports_btn.Click += new System.EventHandler(this.reports_btn_Click);
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            // 
            // fee_voucher_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 636);
            this.Controls.Add(this.reports_btn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.late_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.miscellaneousFee_checkbox);
            this.Controls.Add(this.admissionFee_checkbox);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.feevoucher_dgv);
            this.Controls.Add(this.duedate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.month_year);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.monthly_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.class_cmbbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fee_voucher_form";
            this.Text = "fee_voucher_form";
            this.Load += new System.EventHandler(this.fee_voucher_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feevoucher_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox class_cmbbox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox monthly_txtbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker month_year;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuDatepicker duedate;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid feevoucher_dgv;
        private Bunifu.Framework.UI.BunifuFlatButton delete_btn;
        private Bunifu.Framework.UI.BunifuFlatButton update_btn;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private System.Windows.Forms.CheckBox miscellaneousFee_checkbox;
        private System.Windows.Forms.CheckBox admissionFee_checkbox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox late_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuFlatButton reports_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
    }
}