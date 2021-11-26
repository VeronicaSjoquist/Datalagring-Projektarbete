namespace UserFrontend.Buttons
{
    partial class Description
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
            this.textDesciption = new System.Windows.Forms.TextBox();
            this.btnReturnFromDescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDesciption
            // 
            this.textDesciption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDesciption.Location = new System.Drawing.Point(182, 161);
            this.textDesciption.Multiline = true;
            this.textDesciption.Name = "textDesciption";
            this.textDesciption.Size = new System.Drawing.Size(380, 220);
            this.textDesciption.TabIndex = 0;
            this.textDesciption.Text = "This projeckt is to use a database and give it a frontend.\r\nSo right now it is mo" +
    "re about trial and error!\r\n";
            this.textDesciption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDesciption.TextChanged += new System.EventHandler(this.textDesciption_TextChanged);
            // 
            // btnReturnFromDescription
            // 
            this.btnReturnFromDescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromDescription.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromDescription.Name = "btnReturnFromDescription";
            this.btnReturnFromDescription.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromDescription.TabIndex = 1;
            this.btnReturnFromDescription.Text = "Return";
            this.btnReturnFromDescription.UseVisualStyleBackColor = true;
            this.btnReturnFromDescription.Click += new System.EventHandler(this.btnReturnFromDescription_Click);
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.btnReturnFromDescription);
            this.Controls.Add(this.textDesciption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "Description";
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textDesciption;
        private Button btnReturnFromDescription;
    }
}