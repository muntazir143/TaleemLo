﻿namespace Final_Year_Project
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
            this.lateFee_checkbox = new System.Windows.Forms.CheckBox();
            this.roll_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.name_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.class_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.ok_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.admissionFee_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.miscFee_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lateFee_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "Roll No";
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
            this.monthly_txtbox.Location = new System.Drawing.Point(145, 321);
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
            this.label2.Location = new System.Drawing.Point(44, 330);
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
            this.month_year.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.month_year.FormatCustom = "";
            this.month_year.Location = new System.Drawing.Point(145, 445);
            this.month_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.month_year.Name = "month_year";
            this.month_year.Size = new System.Drawing.Size(250, 38);
            this.month_year.TabIndex = 89;
            this.month_year.Value = new System.DateTime(2020, 6, 17, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 458);
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
            this.duedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duedate.FormatCustom = "";
            this.duedate.Location = new System.Drawing.Point(145, 384);
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
            this.label3.Location = new System.Drawing.Point(37, 397);
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
            this.delete_btn.Location = new System.Drawing.Point(918, 604);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.delete_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.delete_btn.selected = false;
            this.delete_btn.Size = new System.Drawing.Size(120, 40);
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
            this.update_btn.Location = new System.Drawing.Point(762, 604);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(120, 40);
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
            this.save_btn.Location = new System.Drawing.Point(607, 604);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.save_btn.Name = "save_btn";
            this.save_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.save_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.save_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.save_btn.selected = false;
            this.save_btn.Size = new System.Drawing.Size(120, 40);
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
            this.admissionFee_checkbox.Location = new System.Drawing.Point(47, 560);
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
            this.miscellaneousFee_checkbox.Location = new System.Drawing.Point(47, 646);
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
            this.label5.Location = new System.Drawing.Point(36, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 99;
            this.label5.Text = "Select these to include:";
            // 
            // lateFee_checkbox
            // 
            this.lateFee_checkbox.AutoSize = true;
            this.lateFee_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateFee_checkbox.Location = new System.Drawing.Point(47, 603);
            this.lateFee_checkbox.Name = "lateFee_checkbox";
            this.lateFee_checkbox.Size = new System.Drawing.Size(82, 19);
            this.lateFee_checkbox.TabIndex = 102;
            this.lateFee_checkbox.Text = "Late Fee";
            this.lateFee_checkbox.UseVisualStyleBackColor = true;
            // 
            // roll_txtbox
            // 
            this.roll_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.roll_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roll_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.roll_txtbox.BorderThickness = 3;
            this.roll_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roll_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.roll_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roll_txtbox.isPassword = false;
            this.roll_txtbox.Location = new System.Drawing.Point(145, 121);
            this.roll_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.roll_txtbox.Name = "roll_txtbox";
            this.roll_txtbox.Size = new System.Drawing.Size(147, 35);
            this.roll_txtbox.TabIndex = 104;
            this.roll_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // name_txtbox
            // 
            this.name_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.name_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.name_txtbox.BorderThickness = 3;
            this.name_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txtbox.Enabled = false;
            this.name_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_txtbox.isPassword = false;
            this.name_txtbox.Location = new System.Drawing.Point(145, 184);
            this.name_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(250, 35);
            this.name_txtbox.TabIndex = 106;
            this.name_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 105;
            this.label7.Text = "Name";
            // 
            // class_txtbox
            // 
            this.class_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.class_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.class_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.class_txtbox.BorderThickness = 3;
            this.class_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.class_txtbox.Enabled = false;
            this.class_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.class_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.class_txtbox.isPassword = false;
            this.class_txtbox.Location = new System.Drawing.Point(145, 253);
            this.class_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.class_txtbox.Name = "class_txtbox";
            this.class_txtbox.Size = new System.Drawing.Size(250, 35);
            this.class_txtbox.TabIndex = 108;
            this.class_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 107;
            this.label8.Text = "Class";
            // 
            // ok_btn
            // 
            this.ok_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.ok_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok_btn.BorderRadius = 0;
            this.ok_btn.ButtonText = "OK!";
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.DisabledColor = System.Drawing.Color.Gray;
            this.ok_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.ok_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ok_btn.Iconimage")));
            this.ok_btn.Iconimage_right = null;
            this.ok_btn.Iconimage_right_Selected = null;
            this.ok_btn.Iconimage_Selected = null;
            this.ok_btn.IconMarginLeft = 0;
            this.ok_btn.IconMarginRight = 0;
            this.ok_btn.IconRightVisible = true;
            this.ok_btn.IconRightZoom = 0D;
            this.ok_btn.IconVisible = true;
            this.ok_btn.IconZoom = 90D;
            this.ok_btn.IsTab = false;
            this.ok_btn.Location = new System.Drawing.Point(318, 121);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.ok_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ok_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.ok_btn.selected = false;
            this.ok_btn.Size = new System.Drawing.Size(77, 35);
            this.ok_btn.TabIndex = 109;
            this.ok_btn.Text = "OK!";
            this.ok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_btn.Textcolor = System.Drawing.Color.White;
            this.ok_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // admissionFee_txtbox
            // 
            this.admissionFee_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.admissionFee_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admissionFee_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.admissionFee_txtbox.BorderThickness = 3;
            this.admissionFee_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.admissionFee_txtbox.Enabled = false;
            this.admissionFee_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.admissionFee_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admissionFee_txtbox.isPassword = false;
            this.admissionFee_txtbox.Location = new System.Drawing.Point(211, 544);
            this.admissionFee_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.admissionFee_txtbox.Name = "admissionFee_txtbox";
            this.admissionFee_txtbox.Size = new System.Drawing.Size(118, 35);
            this.admissionFee_txtbox.TabIndex = 110;
            this.admissionFee_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // miscFee_txtbox
            // 
            this.miscFee_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.miscFee_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miscFee_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.miscFee_txtbox.BorderThickness = 3;
            this.miscFee_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.miscFee_txtbox.Enabled = false;
            this.miscFee_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.miscFee_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miscFee_txtbox.isPassword = false;
            this.miscFee_txtbox.Location = new System.Drawing.Point(211, 630);
            this.miscFee_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.miscFee_txtbox.Name = "miscFee_txtbox";
            this.miscFee_txtbox.Size = new System.Drawing.Size(118, 35);
            this.miscFee_txtbox.TabIndex = 111;
            this.miscFee_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lateFee_txtbox
            // 
            this.lateFee_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.lateFee_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lateFee_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.lateFee_txtbox.BorderThickness = 3;
            this.lateFee_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lateFee_txtbox.Enabled = false;
            this.lateFee_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lateFee_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lateFee_txtbox.isPassword = false;
            this.lateFee_txtbox.Location = new System.Drawing.Point(211, 587);
            this.lateFee_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.lateFee_txtbox.Name = "lateFee_txtbox";
            this.lateFee_txtbox.Size = new System.Drawing.Size(118, 35);
            this.lateFee_txtbox.TabIndex = 112;
            this.lateFee_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fee_voucher_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 699);
            this.Controls.Add(this.lateFee_txtbox);
            this.Controls.Add(this.miscFee_txtbox);
            this.Controls.Add(this.admissionFee_txtbox);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.class_txtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roll_txtbox);
            this.Controls.Add(this.lateFee_checkbox);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fee_voucher_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.CheckBox lateFee_checkbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox roll_txtbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox class_txtbox;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox name_txtbox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton ok_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox lateFee_txtbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox miscFee_txtbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox admissionFee_txtbox;
    }
}