﻿namespace ResturantFrontend
{
    partial class ViewSales
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PrintRestauratName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Price,
            this.Type});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(256, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(308, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food Rescue";
            // 
            // textBox_PrintRestauratName
            // 
            this.textBox_PrintRestauratName.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_PrintRestauratName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PrintRestauratName.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PrintRestauratName.Location = new System.Drawing.Point(245, 127);
            this.textBox_PrintRestauratName.Name = "textBox_PrintRestauratName";
            this.textBox_PrintRestauratName.Size = new System.Drawing.Size(331, 29);
            this.textBox_PrintRestauratName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(256, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sales";
            // 
            // button_back
            // 
            this.button_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(628, 46);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(112, 53);
            this.button_back.TabIndex = 14;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 581);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_PrintRestauratName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(820, 628);
            this.MinimumSize = new System.Drawing.Size(820, 628);
            this.Text = "ViewSales";
            this.Load += new System.EventHandler(this.ViewSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private Label label1;
        private TextBox textBox_PrintRestauratName;
        private ColumnHeader Name;
        private ColumnHeader Price;
        private ColumnHeader Type;
        private Label label5;
        private Button button_back;
    }
}