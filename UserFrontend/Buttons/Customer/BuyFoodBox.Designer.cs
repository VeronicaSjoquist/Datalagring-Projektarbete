namespace UserFrontend.Buttons.Customer
{
    partial class BuyFoodBox
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
            this.btnReturnFromBuyFoodBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromBuyFoodBox
            // 
            this.btnReturnFromBuyFoodBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromBuyFoodBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromBuyFoodBox.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromBuyFoodBox.Name = "btnReturnFromBuyFoodBox";
            this.btnReturnFromBuyFoodBox.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromBuyFoodBox.TabIndex = 2;
            this.btnReturnFromBuyFoodBox.Text = "Return";
            this.btnReturnFromBuyFoodBox.UseVisualStyleBackColor = true;
            this.btnReturnFromBuyFoodBox.Click += new System.EventHandler(this.btnReturnFromBuyFoodBox_Click);
            // 
            // BuyFoodBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.btnReturnFromBuyFoodBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "BuyFoodBox";
            this.Text = "BuyFoodBox";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromBuyFoodBox;
    }
}