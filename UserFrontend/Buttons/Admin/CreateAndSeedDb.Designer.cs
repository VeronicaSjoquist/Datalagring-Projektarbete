namespace UserFrontend.Buttons.Admin
{
    partial class btnCreateAndSeedDb
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
            this.btnReturnFromCreatAnSeedDb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromCreatAnSeedDb
            // 
            this.btnReturnFromCreatAnSeedDb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromCreatAnSeedDb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromCreatAnSeedDb.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromCreatAnSeedDb.Name = "btnReturnFromCreatAnSeedDb";
            this.btnReturnFromCreatAnSeedDb.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromCreatAnSeedDb.TabIndex = 3;
            this.btnReturnFromCreatAnSeedDb.Text = "Return";
            this.btnReturnFromCreatAnSeedDb.UseVisualStyleBackColor = true;
            this.btnReturnFromCreatAnSeedDb.Click += new System.EventHandler(this.btnReturnFromCreatAnSeedDb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create and Seed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateAndSeedDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(699, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturnFromCreatAnSeedDb);
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "btnCreateAndSeedDb";
            this.Text = "CreateAndSeedDb";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromCreatAnSeedDb;
        private Button button1;
    }
}