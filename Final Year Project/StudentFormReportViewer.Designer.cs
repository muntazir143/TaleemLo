namespace Final_Year_Project
{
    partial class StudentFormReportViewer
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
            this.StudentReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // StudentReportViewer
            // 
            this.StudentReportViewer.ActiveViewIndex = -1;
            this.StudentReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.StudentReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentReportViewer.Location = new System.Drawing.Point(0, 0);
            this.StudentReportViewer.Name = "StudentReportViewer";
            this.StudentReportViewer.Size = new System.Drawing.Size(800, 450);
            this.StudentReportViewer.TabIndex = 0;
            this.StudentReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // StudentFormReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentReportViewer);
            this.Name = "StudentFormReportViewer";
            this.Text = "Students Report";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer StudentReportViewer;
    }
}