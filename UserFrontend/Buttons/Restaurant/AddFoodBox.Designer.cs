namespace UserFrontend.Buttons.Restaurant
{
    partial class AddFoodBox
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
            this.btnReturnFromAddFoodBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromAddFoodBox
            // 
            this.btnReturnFromAddFoodBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromAddFoodBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromAddFoodBox.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromAddFoodBox.Name = "btnReturnFromAddFoodBox";
            this.btnReturnFromAddFoodBox.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromAddFoodBox.TabIndex = 3;
            this.btnReturnFromAddFoodBox.Text = "Return";
            this.btnReturnFromAddFoodBox.UseVisualStyleBackColor = true;
            this.btnReturnFromAddFoodBox.Click += new System.EventHandler(this.btnReturnFromAddFoodBox_Click);
            // 
            // AddFoodBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.btnReturnFromAddFoodBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "AddFoodBox";
            this.Text = "AddFoodBox";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromAddFoodBox;
    }
}