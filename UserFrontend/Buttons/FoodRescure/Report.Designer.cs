namespace UserFrontend.Buttons
{
    partial class btnGitReport
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
            this.btnReturnFromReport = new System.Windows.Forms.Button();
            this.btnGitReportWeb = new System.Windows.Forms.Button();
            this.labelReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnFromReport
            // 
            this.btnReturnFromReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromReport.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromReport.Name = "btnReturnFromReport";
            this.btnReturnFromReport.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromReport.TabIndex = 2;
            this.btnReturnFromReport.Text = "Return";
            this.btnReturnFromReport.UseVisualStyleBackColor = true;
            this.btnReturnFromReport.Click += new System.EventHandler(this.btnReturnFromDescription_Click);
            // 
            // btnGitReportWeb
            // 
            this.btnGitReportWeb.Location = new System.Drawing.Point(120, 20);
            this.btnGitReportWeb.Name = "btnGitReportWeb";
            this.btnGitReportWeb.Size = new System.Drawing.Size(94, 29);
            this.btnGitReportWeb.TabIndex = 4;
            this.btnGitReportWeb.Text = "Report";
            this.btnGitReportWeb.UseVisualStyleBackColor = true;
            this.btnGitReportWeb.Click += new System.EventHandler(this.btnGitReportWeb_Click);
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReport.ForeColor = System.Drawing.SystemColors.Window;
            this.labelReport.Location = new System.Drawing.Point(20, 52);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(335, 30);
            this.labelReport.TabIndex = 16;
            this.labelReport.Text = "Press Report to see report on GitHub";
            // 
            // btnGitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.btnGitReportWeb);
            this.Controls.Add(this.btnReturnFromReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "btnGitReport";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReturnFromReport;
        private Button btnGitReportWeb;
        private Label labelReport;
    }
}