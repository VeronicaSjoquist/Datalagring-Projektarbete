namespace UserFrontend.Buttons.Customer
{
    partial class UnsoldFoodBoxes
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
            this.btnReturnFromUnsoldFoodBoxes = new System.Windows.Forms.Button();
            this.btnUnsoldFoodBoxes = new System.Windows.Forms.Button();
            this.listUnsold = new System.Windows.Forms.ListView();
            this.Food = new System.Windows.Forms.ColumnHeader();
            this.Restaurant = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnReturnFromUnsoldFoodBoxes
            // 
            this.btnReturnFromUnsoldFoodBoxes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromUnsoldFoodBoxes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromUnsoldFoodBoxes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnFromUnsoldFoodBoxes.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromUnsoldFoodBoxes.Name = "btnReturnFromUnsoldFoodBoxes";
            this.btnReturnFromUnsoldFoodBoxes.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromUnsoldFoodBoxes.TabIndex = 3;
            this.btnReturnFromUnsoldFoodBoxes.Text = "Return";
            this.btnReturnFromUnsoldFoodBoxes.UseVisualStyleBackColor = true;
            this.btnReturnFromUnsoldFoodBoxes.Click += new System.EventHandler(this.btnReturnFromUnsoldFoodBoxes_Click);
            // 
            // btnUnsoldFoodBoxes
            // 
            this.btnUnsoldFoodBoxes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUnsoldFoodBoxes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUnsoldFoodBoxes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnsoldFoodBoxes.Location = new System.Drawing.Point(20, 77);
            this.btnUnsoldFoodBoxes.Name = "btnUnsoldFoodBoxes";
            this.btnUnsoldFoodBoxes.Size = new System.Drawing.Size(156, 83);
            this.btnUnsoldFoodBoxes.TabIndex = 4;
            this.btnUnsoldFoodBoxes.Text = "View UndSold";
            this.btnUnsoldFoodBoxes.UseVisualStyleBackColor = true;
            this.btnUnsoldFoodBoxes.Click += new System.EventHandler(this.btnUnsoldFoodBoxes_Click);
            // 
            // listUnsold
            // 
            this.listUnsold.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Food,
            this.Restaurant,
            this.Price});
            this.listUnsold.Location = new System.Drawing.Point(20, 194);
            this.listUnsold.Name = "listUnsold";
            this.listUnsold.Size = new System.Drawing.Size(484, 163);
            this.listUnsold.TabIndex = 6;
            this.listUnsold.UseCompatibleStateImageBehavior = false;
            this.listUnsold.View = System.Windows.Forms.View.Details;
            // 
            // Food
            // 
            this.Food.Text = "Food";
            this.Food.Width = 175;
            // 
            // Restaurant
            // 
            this.Restaurant.Text = "Restaurant";
            this.Restaurant.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 175;
            // 
            // UnsoldFoodBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.listUnsold);
            this.Controls.Add(this.btnUnsoldFoodBoxes);
            this.Controls.Add(this.btnReturnFromUnsoldFoodBoxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "UnsoldFoodBoxes";
            this.Text = "UnsoldFoodBoxes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromUnsoldFoodBoxes;
        private Button btnUnsoldFoodBoxes;
        private ListView listUnsold;
        private ColumnHeader Food;
        private ColumnHeader Restaurant;
        private ColumnHeader Price;
    }
}