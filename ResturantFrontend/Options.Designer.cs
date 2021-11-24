namespace ResturantFrontend
{
    partial class Options
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
            this.button_AddBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ViewSales = new System.Windows.Forms.Button();
            this.textBox_PrintRestauratName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_AddBox
            // 
            this.button_AddBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_AddBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AddBox.Location = new System.Drawing.Point(290, 153);
            this.button_AddBox.Name = "button_AddBox";
            this.button_AddBox.Size = new System.Drawing.Size(144, 43);
            this.button_AddBox.TabIndex = 0;
            this.button_AddBox.Text = "New Foodbox";
            this.button_AddBox.UseVisualStyleBackColor = false;
            this.button_AddBox.Click += new System.EventHandler(this.Button_AddBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Rescue";
            // 
            // button_ViewSales
            // 
            this.button_ViewSales.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_ViewSales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ViewSales.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ViewSales.Location = new System.Drawing.Point(290, 214);
            this.button_ViewSales.Name = "button_ViewSales";
            this.button_ViewSales.Size = new System.Drawing.Size(144, 43);
            this.button_ViewSales.TabIndex = 2;
            this.button_ViewSales.Text = "View Sales";
            this.button_ViewSales.UseVisualStyleBackColor = false;
            // 
            // textBox_PrintRestauratName
            // 
            this.textBox_PrintRestauratName.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_PrintRestauratName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PrintRestauratName.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PrintRestauratName.Location = new System.Drawing.Point(266, 105);
            this.textBox_PrintRestauratName.Name = "textBox_PrintRestauratName";
            this.textBox_PrintRestauratName.Size = new System.Drawing.Size(187, 23);
            this.textBox_PrintRestauratName.TabIndex = 3;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 444);
            this.Controls.Add(this.textBox_PrintRestauratName);
            this.Controls.Add(this.button_ViewSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddBox);
            this.MinimumSize = new System.Drawing.Size(720, 483);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_AddBox;
        private Label label1;
        private Button button_ViewSales;
        private TextBox textBox_PrintRestauratName;
    }
}