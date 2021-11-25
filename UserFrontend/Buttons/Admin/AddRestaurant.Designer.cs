namespace UserFrontend.Buttons.Admin
{
    partial class AddRestaurant
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
            this.btnReturnFromAddRestaurant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromAddRestaurant
            // 
            this.btnReturnFromAddRestaurant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromAddRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromAddRestaurant.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromAddRestaurant.Name = "btnReturnFromAddRestaurant";
            this.btnReturnFromAddRestaurant.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromAddRestaurant.TabIndex = 3;
            this.btnReturnFromAddRestaurant.Text = "Return";
            this.btnReturnFromAddRestaurant.UseVisualStyleBackColor = true;
            this.btnReturnFromAddRestaurant.Click += new System.EventHandler(this.btnReturnFromAddRestaurant_Click);
            // 
            // AddRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(699, 506);
            this.Controls.Add(this.btnReturnFromAddRestaurant);
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "AddRestaurant";
            this.Text = "AddRestaurant";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromAddRestaurant;
    }
}