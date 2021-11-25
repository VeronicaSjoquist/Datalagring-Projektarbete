namespace UserFrontend.Buttons.Restaurant
{
    partial class SoldBoxes
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
            this.btnReturnFromSoldBoxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromSoldBoxes
            // 
            this.btnReturnFromSoldBoxes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromSoldBoxes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromSoldBoxes.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromSoldBoxes.Name = "btnReturnFromSoldBoxes";
            this.btnReturnFromSoldBoxes.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromSoldBoxes.TabIndex = 2;
            this.btnReturnFromSoldBoxes.Text = "Return";
            this.btnReturnFromSoldBoxes.UseVisualStyleBackColor = true;
            this.btnReturnFromSoldBoxes.Click += new System.EventHandler(this.btnReturnFromSoldBoxes_Click);
            // 
            // SoldBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.btnReturnFromSoldBoxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "SoldBoxes";
            this.Text = "SoldBoxes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromSoldBoxes;
    }
}