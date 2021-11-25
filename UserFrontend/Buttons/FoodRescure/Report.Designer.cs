namespace UserFrontend.Buttons
{
    partial class Report
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
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.btnReturnFromReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromReport;
    }
}