namespace UserFrontend.Buttons.Admin
{
    partial class ShowAllCustomers
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
            this.btnReturnFromShowAllCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromShowAllCustomers
            // 
            this.btnReturnFromShowAllCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromShowAllCustomers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromShowAllCustomers.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromShowAllCustomers.Name = "btnReturnFromShowAllCustomers";
            this.btnReturnFromShowAllCustomers.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromShowAllCustomers.TabIndex = 3;
            this.btnReturnFromShowAllCustomers.Text = "Return";
            this.btnReturnFromShowAllCustomers.UseVisualStyleBackColor = true;
            this.btnReturnFromShowAllCustomers.Click += new System.EventHandler(this.btnReturnFromShowAllCustomers_Click);
            // 
            // ShowAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(699, 506);
            this.Controls.Add(this.btnReturnFromShowAllCustomers);
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "ShowAllCustomers";
            this.Text = "ShowAllCustomers";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromShowAllCustomers;
    }
}