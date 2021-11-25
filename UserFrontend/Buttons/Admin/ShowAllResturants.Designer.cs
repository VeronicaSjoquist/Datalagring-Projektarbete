namespace UserFrontend.Buttons.Admin
{
    partial class ShowAllResturants
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
            this.btnReturnFromShowAllRestaurant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromShowAllRestaurant
            // 
            this.btnReturnFromShowAllRestaurant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromShowAllRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromShowAllRestaurant.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromShowAllRestaurant.Name = "btnReturnFromShowAllRestaurant";
            this.btnReturnFromShowAllRestaurant.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromShowAllRestaurant.TabIndex = 3;
            this.btnReturnFromShowAllRestaurant.Text = "Return";
            this.btnReturnFromShowAllRestaurant.UseVisualStyleBackColor = true;
            this.btnReturnFromShowAllRestaurant.Click += new System.EventHandler(this.btnReturnFromBuyFoodBox_Click);
            // 
            // ShowAllResturants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(699, 506);
            this.Controls.Add(this.btnReturnFromShowAllRestaurant);
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "ShowAllResturants";
            this.Text = "ShowAllResturants";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromShowAllRestaurant;
    }
}