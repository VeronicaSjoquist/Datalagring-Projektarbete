namespace UserFrontend.Buttons.Admin
{
    partial class RemoveCustomer
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
            this.btnReturnFromRemoveCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromRemoveCustomer
            // 
            this.btnReturnFromRemoveCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromRemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromRemoveCustomer.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromRemoveCustomer.Name = "btnReturnFromRemoveCustomer";
            this.btnReturnFromRemoveCustomer.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromRemoveCustomer.TabIndex = 3;
            this.btnReturnFromRemoveCustomer.Text = "Return";
            this.btnReturnFromRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnReturnFromRemoveCustomer.Click += new System.EventHandler(this.btnReturnFromRemoveCustomer_Click);
            // 
            // RemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(699, 506);
            this.Controls.Add(this.btnReturnFromRemoveCustomer);
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "RemoveCustomer";
            this.Text = "RemoveCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromRemoveCustomer;
    }
}