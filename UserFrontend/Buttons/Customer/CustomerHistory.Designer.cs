namespace UserFrontend.Buttons.Customer
{
    partial class CustomerHistory
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
            this.btnReturnFromCustomerHistory = new System.Windows.Forms.Button();
            this.btnVeronicasHistory = new System.Windows.Forms.Button();
            this.btnKimsHistory = new System.Windows.Forms.Button();
            this.listHistorySold = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Namn = new System.Windows.Forms.ColumnHeader();
            this.Restaurant = new System.Windows.Forms.ColumnHeader();
            this.btnTheosHistory = new System.Windows.Forms.Button();
            this.FoodBox = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnReturnFromCustomerHistory
            // 
            this.btnReturnFromCustomerHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromCustomerHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromCustomerHistory.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromCustomerHistory.Name = "btnReturnFromCustomerHistory";
            this.btnReturnFromCustomerHistory.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromCustomerHistory.TabIndex = 3;
            this.btnReturnFromCustomerHistory.Text = "Return";
            this.btnReturnFromCustomerHistory.UseVisualStyleBackColor = true;
            this.btnReturnFromCustomerHistory.Click += new System.EventHandler(this.btnReturnFromCustomerHistory_Click);
            // 
            // btnVeronicasHistory
            // 
            this.btnVeronicasHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnVeronicasHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVeronicasHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVeronicasHistory.Location = new System.Drawing.Point(360, 69);
            this.btnVeronicasHistory.Name = "btnVeronicasHistory";
            this.btnVeronicasHistory.Size = new System.Drawing.Size(156, 83);
            this.btnVeronicasHistory.TabIndex = 12;
            this.btnVeronicasHistory.Text = "Veronicas History";
            this.btnVeronicasHistory.UseVisualStyleBackColor = true;
            this.btnVeronicasHistory.Click += new System.EventHandler(this.btnVeronicasHistory_Click);
            // 
            // btnKimsHistory
            // 
            this.btnKimsHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnKimsHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKimsHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKimsHistory.Location = new System.Drawing.Point(192, 69);
            this.btnKimsHistory.Name = "btnKimsHistory";
            this.btnKimsHistory.Size = new System.Drawing.Size(156, 83);
            this.btnKimsHistory.TabIndex = 11;
            this.btnKimsHistory.Text = "Kims History";
            this.btnKimsHistory.UseVisualStyleBackColor = true;
            this.btnKimsHistory.Click += new System.EventHandler(this.btnKimsHistory_Click);
            // 
            // listHistorySold
            // 
            this.listHistorySold.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Namn,
            this.Restaurant,
            this.FoodBox,
            this.Price});
            this.listHistorySold.Location = new System.Drawing.Point(21, 169);
            this.listHistorySold.Name = "listHistorySold";
            this.listHistorySold.Size = new System.Drawing.Size(495, 163);
            this.listHistorySold.TabIndex = 10;
            this.listHistorySold.UseCompatibleStateImageBehavior = false;
            this.listHistorySold.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 100;
            // 
            // Restaurant
            // 
            this.Restaurant.Text = "Restaurant";
            this.Restaurant.Width = 100;
            // 
            // btnTheosHistory
            // 
            this.btnTheosHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnTheosHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTheosHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTheosHistory.Location = new System.Drawing.Point(21, 69);
            this.btnTheosHistory.Name = "btnTheosHistory";
            this.btnTheosHistory.Size = new System.Drawing.Size(156, 83);
            this.btnTheosHistory.TabIndex = 9;
            this.btnTheosHistory.Text = "Theos History";
            this.btnTheosHistory.UseVisualStyleBackColor = true;
            this.btnTheosHistory.Click += new System.EventHandler(this.btnTheosHistory_Click);
            // 
            // FoodBox
            // 
            this.FoodBox.Text = "Box";
            this.FoodBox.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnVeronicasHistory);
            this.Controls.Add(this.btnKimsHistory);
            this.Controls.Add(this.listHistorySold);
            this.Controls.Add(this.btnTheosHistory);
            this.Controls.Add(this.btnReturnFromCustomerHistory);
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "CustomerHistory";
            this.Text = "CustomerHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromCustomerHistory;
        private Button btnVeronicasHistory;
        private Button btnKimsHistory;
        private ListView listHistorySold;
        private ColumnHeader ID;
        private ColumnHeader Namn;
        private ColumnHeader Restaurant;
        private ColumnHeader FoodBox;
        private ColumnHeader Price;
        private Button btnTheosHistory;
    }
}