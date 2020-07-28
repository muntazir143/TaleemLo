namespace Final_Year_Project
{
    partial class fees_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fees_form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.class_cmbbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.admissionFee_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthly_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.miscellaneous_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.feeStructure_dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.view_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.add_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeStructure_dgv)).BeginInit();
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
            this.panel1.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(429, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Structure";
            // 
            // class_cmbbox
            // 
            this.class_cmbbox.FormattingEnabled = true;
            this.class_cmbbox.Location = new System.Drawing.Point(141, 116);
            this.class_cmbbox.Name = "class_cmbbox";
            this.class_cmbbox.Size = new System.Drawing.Size(250, 21);
            this.class_cmbbox.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Class";
            // 
            // admissionFee_txtbox
            // 
            this.admissionFee_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.admissionFee_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admissionFee_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.admissionFee_txtbox.BorderThickness = 3;
            this.admissionFee_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.admissionFee_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.admissionFee_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admissionFee_txtbox.isPassword = false;
            this.admissionFee_txtbox.Location = new System.Drawing.Point(141, 164);
            this.admissionFee_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.admissionFee_txtbox.Name = "admissionFee_txtbox";
            this.admissionFee_txtbox.Size = new System.Drawing.Size(250, 35);
            this.admissionFee_txtbox.TabIndex = 83;
            this.admissionFee_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.admissionFee_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.admissionFee_txtbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Admission Fee";
            // 
            // monthly_txtbox
            // 
            this.monthly_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.monthly_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monthly_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.monthly_txtbox.BorderThickness = 3;
            this.monthly_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.monthly_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.monthly_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monthly_txtbox.isPassword = false;
            this.monthly_txtbox.Location = new System.Drawing.Point(141, 222);
            this.monthly_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.monthly_txtbox.Name = "monthly_txtbox";
            this.monthly_txtbox.Size = new System.Drawing.Size(250, 35);
            this.monthly_txtbox.TabIndex = 85;
            this.monthly_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.monthly_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthly_txtbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Monthly";
            // 
            // miscellaneous_txtbox
            // 
            this.miscellaneous_txtbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.miscellaneous_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miscellaneous_txtbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.miscellaneous_txtbox.BorderThickness = 3;
            this.miscellaneous_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.miscellaneous_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.miscellaneous_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miscellaneous_txtbox.isPassword = false;
            this.miscellaneous_txtbox.Location = new System.Drawing.Point(141, 278);
            this.miscellaneous_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.miscellaneous_txtbox.Name = "miscellaneous_txtbox";
            this.miscellaneous_txtbox.Size = new System.Drawing.Size(250, 35);
            this.miscellaneous_txtbox.TabIndex = 87;
            this.miscellaneous_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.miscellaneous_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miscellaneous_txtbox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 86;
            this.label5.Text = "Miscellaneous";
            // 
            // feeStructure_dgv
            // 
            this.feeStructure_dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.feeStructure_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.feeStructure_dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.feeStructure_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feeStructure_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feeStructure_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.feeStructure_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeStructure_dgv.DoubleBuffered = true;
            this.feeStructure_dgv.EnableHeadersVisualStyles = false;
            this.feeStructure_dgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.feeStructure_dgv.HeaderForeColor = System.Drawing.Color.White;
            this.feeStructure_dgv.Location = new System.Drawing.Point(423, 116);
            this.feeStructure_dgv.Name = "feeStructure_dgv";
            this.feeStructure_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.feeStructure_dgv.Size = new System.Drawing.Size(612, 412);
            this.feeStructure_dgv.TabIndex = 88;
            this.feeStructure_dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.feeStructure_dgv_RowHeaderMouseDoubleClick_1);
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
            this.view_btn.Location = new System.Drawing.Point(888, 557);
            this.view_btn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.view_btn.Name = "view_btn";
            this.view_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.view_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.view_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.view_btn.selected = false;
            this.view_btn.Size = new System.Drawing.Size(150, 43);
            this.view_btn.TabIndex = 92;
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
            this.delete_btn.Location = new System.Drawing.Point(713, 557);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.delete_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.delete_btn.selected = false;
            this.delete_btn.Size = new System.Drawing.Size(147, 43);
            this.delete_btn.TabIndex = 91;
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
            this.update_btn.Location = new System.Drawing.Point(535, 557);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(146, 43);
            this.update_btn.TabIndex = 90;
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
            this.add_btn.Location = new System.Drawing.Point(357, 557);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.add_btn.Name = "add_btn";
            this.add_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(113)))));
            this.add_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.add_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.add_btn.selected = false;
            this.add_btn.Size = new System.Drawing.Size(154, 43);
            this.add_btn.TabIndex = 89;
            this.add_btn.Text = "Add";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Textcolor = System.Drawing.Color.White;
            this.add_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // fees_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 629);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.feeStructure_dgv);
            this.Controls.Add(this.miscellaneous_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthly_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.admissionFee_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.class_cmbbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fees_form";
            this.Text = "fees_form";
            this.Load += new System.EventHandler(this.fees_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeStructure_dgv)).EndInit();
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
        private Bunifu.Framework.UI.BunifuMetroTextbox miscellaneous_txtbox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox monthly_txtbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox admissionFee_txtbox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid feeStructure_dgv;
        private Bunifu.Framework.UI.BunifuFlatButton view_btn;
        private Bunifu.Framework.UI.BunifuFlatButton delete_btn;
        private Bunifu.Framework.UI.BunifuFlatButton update_btn;
        private Bunifu.Framework.UI.BunifuFlatButton add_btn;
    }
}