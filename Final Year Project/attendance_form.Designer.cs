namespace Final_Year_Project
{
    partial class attendance_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendance_form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.section_cmbbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.class_cmbbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.attendance_dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Attendanceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sectionid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.load_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.allpresent_checkbox = new System.Windows.Forms.CheckBox();
            this.update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.attendanceExistLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_dgv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1027, 80);
            this.panel1.TabIndex = 3;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(983, 23);
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
            this.label1.Location = new System.Drawing.Point(355, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance";
            // 
            // section_cmbbox
            // 
            this.section_cmbbox.FormattingEnabled = true;
            this.section_cmbbox.Location = new System.Drawing.Point(93, 206);
            this.section_cmbbox.Name = "section_cmbbox";
            this.section_cmbbox.Size = new System.Drawing.Size(250, 21);
            this.section_cmbbox.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "Section";
            // 
            // class_cmbbox
            // 
            this.class_cmbbox.FormattingEnabled = true;
            this.class_cmbbox.Location = new System.Drawing.Point(93, 157);
            this.class_cmbbox.Name = "class_cmbbox";
            this.class_cmbbox.Size = new System.Drawing.Size(250, 21);
            this.class_cmbbox.TabIndex = 79;
            this.class_cmbbox.SelectedIndexChanged += new System.EventHandler(this.class_cmbbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Class";
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.date.BorderRadius = 0;
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.FormatCustom = null;
            this.date.Location = new System.Drawing.Point(93, 101);
            this.date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(250, 38);
            this.date.TabIndex = 81;
            this.date.Value = new System.DateTime(2020, 6, 7, 22, 4, 21, 641);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 80;
            this.label10.Text = "Date";
            // 
            // attendance_dgv
            // 
            this.attendance_dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.attendance_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.attendance_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendance_dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.attendance_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attendance_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendance_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.attendance_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendance_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attendanceid,
            this.Attendance,
            this.RollNo,
            this.Name_col,
            this.Classid,
            this.Sectionid});
            this.attendance_dgv.DoubleBuffered = true;
            this.attendance_dgv.EnableHeadersVisualStyles = false;
            this.attendance_dgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.attendance_dgv.HeaderForeColor = System.Drawing.Color.White;
            this.attendance_dgv.Location = new System.Drawing.Point(383, 137);
            this.attendance_dgv.Name = "attendance_dgv";
            this.attendance_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.attendance_dgv.Size = new System.Drawing.Size(618, 340);
            this.attendance_dgv.TabIndex = 82;
            // 
            // Attendanceid
            // 
            this.Attendanceid.HeaderText = "ID";
            this.Attendanceid.Name = "Attendanceid";
            this.Attendanceid.ReadOnly = true;
            this.Attendanceid.Visible = false;
            // 
            // Attendance
            // 
            this.Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Items.AddRange(new object[] {
            "P",
            "A",
            "L"});
            this.Attendance.Name = "Attendance";
            // 
            // RollNo
            // 
            this.RollNo.HeaderText = "Roll Number";
            this.RollNo.Name = "RollNo";
            // 
            // Name_col
            // 
            this.Name_col.HeaderText = "Name";
            this.Name_col.Name = "Name_col";
            // 
            // Classid
            // 
            this.Classid.HeaderText = "ClassID";
            this.Classid.Name = "Classid";
            this.Classid.Visible = false;
            // 
            // Sectionid
            // 
            this.Sectionid.HeaderText = "SectionID";
            this.Sectionid.Name = "Sectionid";
            this.Sectionid.Visible = false;
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
            this.save_btn.Location = new System.Drawing.Point(383, 506);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.save_btn.Name = "save_btn";
            this.save_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.save_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.save_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.save_btn.selected = false;
            this.save_btn.Size = new System.Drawing.Size(154, 43);
            this.save_btn.TabIndex = 83;
            this.save_btn.Text = "Save";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Textcolor = System.Drawing.Color.White;
            this.save_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
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
            this.load_btn.Location = new System.Drawing.Point(132, 258);
            this.load_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.load_btn.Name = "load_btn";
            this.load_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.load_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.load_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.load_btn.selected = false;
            this.load_btn.Size = new System.Drawing.Size(154, 43);
            this.load_btn.TabIndex = 84;
            this.load_btn.Text = "Load";
            this.load_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.load_btn.Textcolor = System.Drawing.Color.White;
            this.load_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // allpresent_checkbox
            // 
            this.allpresent_checkbox.AutoSize = true;
            this.allpresent_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allpresent_checkbox.Location = new System.Drawing.Point(383, 101);
            this.allpresent_checkbox.Name = "allpresent_checkbox";
            this.allpresent_checkbox.Size = new System.Drawing.Size(95, 19);
            this.allpresent_checkbox.TabIndex = 87;
            this.allpresent_checkbox.Text = "All Present";
            this.allpresent_checkbox.UseVisualStyleBackColor = true;
            this.allpresent_checkbox.CheckedChanged += new System.EventHandler(this.allpresent_checkbox_CheckedChanged);
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
            this.update_btn.Location = new System.Drawing.Point(559, 506);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(154, 43);
            this.update_btn.TabIndex = 88;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Textcolor = System.Drawing.Color.White;
            this.update_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // attendanceExistLabel
            // 
            this.attendanceExistLabel.AutoSize = true;
            this.attendanceExistLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceExistLabel.Location = new System.Drawing.Point(90, 402);
            this.attendanceExistLabel.Name = "attendanceExistLabel";
            this.attendanceExistLabel.Size = new System.Drawing.Size(196, 48);
            this.attendanceExistLabel.TabIndex = 89;
            this.attendanceExistLabel.Text = "Attendance Already Marked\r\n\r\n\r\n";
            this.attendanceExistLabel.Visible = false;
            // 
            // attendance_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 583);
            this.Controls.Add(this.attendanceExistLabel);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.allpresent_checkbox);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.attendance_dgv);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.class_cmbbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.section_cmbbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "attendance_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "attendance_form";
            this.Load += new System.EventHandler(this.attendance_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox section_cmbbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox class_cmbbox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker date;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCustomDataGrid attendance_dgv;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private Bunifu.Framework.UI.BunifuFlatButton load_btn;
        private System.Windows.Forms.CheckBox allpresent_checkbox;
        private Bunifu.Framework.UI.BunifuFlatButton update_btn;
        private System.Windows.Forms.Label attendanceExistLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendanceid;
        private System.Windows.Forms.DataGridViewComboBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sectionid;
    }
}