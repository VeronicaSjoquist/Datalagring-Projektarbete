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
            this.btnUnsoldFoodFishBoxes = new System.Windows.Forms.Button();
            this.listUnsoldBoxes = new System.Windows.Forms.ListView();
            this.Food = new System.Windows.Forms.ColumnHeader();
            this.Restaurant = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.btnUnsoldFoodMeatBoxes = new System.Windows.Forms.Button();
            this.btnUnsoldFoodVeganBoxes = new System.Windows.Forms.Button();
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
            // btnUnsoldFoodFishBoxes
            // 
            this.btnUnsoldFoodFishBoxes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUnsoldFoodFishBoxes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUnsoldFoodFishBoxes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnsoldFoodFishBoxes.Location = new System.Drawing.Point(20, 77);
            this.btnUnsoldFoodFishBoxes.Name = "btnUnsoldFoodFishBoxes";
            this.btnUnsoldFoodFishBoxes.Size = new System.Drawing.Size(156, 83);
            this.btnUnsoldFoodFishBoxes.TabIndex = 4;
            this.btnUnsoldFoodFishBoxes.Text = "View UndSold - Fish Boxes";
            this.btnUnsoldFoodFishBoxes.UseVisualStyleBackColor = true;
            this.btnUnsoldFoodFishBoxes.Click += new System.EventHandler(this.btnUnsoldFoodBoxes_Click);
            // 
            // listUnsoldBoxes
            // 
            this.listUnsoldBoxes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Food,
            this.Restaurant,
            this.Price});
            this.listUnsoldBoxes.Location = new System.Drawing.Point(20, 177);
            this.listUnsoldBoxes.Name = "listUnsoldBoxes";
            this.listUnsoldBoxes.Size = new System.Drawing.Size(495, 163);
            this.listUnsoldBoxes.TabIndex = 6;
            this.listUnsoldBoxes.UseCompatibleStateImageBehavior = false;
            this.listUnsoldBoxes.View = System.Windows.Forms.View.Details;
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
            // btnUnsoldFoodMeatBoxes
            // 
            this.btnUnsoldFoodMeatBoxes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUnsoldFoodMeatBoxes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUnsoldFoodMeatBoxes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnsoldFoodMeatBoxes.Location = new System.Drawing.Point(191, 77);
            this.btnUnsoldFoodMeatBoxes.Name = "btnUnsoldFoodMeatBoxes";
            this.btnUnsoldFoodMeatBoxes.Size = new System.Drawing.Size(156, 83);
            this.btnUnsoldFoodMeatBoxes.TabIndex = 7;
            this.btnUnsoldFoodMeatBoxes.Text = "View UndSold - Meat Boxes";
            this.btnUnsoldFoodMeatBoxes.UseVisualStyleBackColor = true;
            this.btnUnsoldFoodMeatBoxes.Click += new System.EventHandler(this.btnUnsoldFoodMeatBoxes_Click);
            // 
            // btnUnsoldFoodVeganBoxes
            // 
            this.btnUnsoldFoodVeganBoxes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUnsoldFoodVeganBoxes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUnsoldFoodVeganBoxes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnsoldFoodVeganBoxes.Location = new System.Drawing.Point(359, 77);
            this.btnUnsoldFoodVeganBoxes.Name = "btnUnsoldFoodVeganBoxes";
            this.btnUnsoldFoodVeganBoxes.Size = new System.Drawing.Size(156, 83);
            this.btnUnsoldFoodVeganBoxes.TabIndex = 8;
            this.btnUnsoldFoodVeganBoxes.Text = "View UndSold - Vegan";
            this.btnUnsoldFoodVeganBoxes.UseVisualStyleBackColor = true;
            this.btnUnsoldFoodVeganBoxes.Click += new System.EventHandler(this.btnUnsoldFoodVeganBoxes_Click);
            // 
            // UnsoldFoodBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.btnUnsoldFoodVeganBoxes);
            this.Controls.Add(this.btnUnsoldFoodMeatBoxes);
            this.Controls.Add(this.listUnsoldBoxes);
            this.Controls.Add(this.btnUnsoldFoodFishBoxes);
            this.Controls.Add(this.btnReturnFromUnsoldFoodBoxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "UnsoldFoodBoxes";
            this.Text = "UnsoldFoodBoxes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromUnsoldFoodBoxes;
        private Button btnUnsoldFoodFishBoxes;
        private ListView listUnsoldBoxes;
        private ColumnHeader Food;
        private ColumnHeader Restaurant;
        private ColumnHeader Price;
        private Button btnUnsoldFoodMeatBoxes;
        private Button btnUnsoldFoodVeganBoxes;
    }
}