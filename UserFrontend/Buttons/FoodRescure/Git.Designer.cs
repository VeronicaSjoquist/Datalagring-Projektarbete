namespace UserFrontend.Buttons
{
    partial class Git
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
            this.btnReturnFromGit = new System.Windows.Forms.Button();
            this.btnGitWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnFromGit
            // 
            this.btnReturnFromGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReturnFromGit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnFromGit.Location = new System.Drawing.Point(20, 20);
            this.btnReturnFromGit.Name = "btnReturnFromGit";
            this.btnReturnFromGit.Size = new System.Drawing.Size(94, 29);
            this.btnReturnFromGit.TabIndex = 2;
            this.btnReturnFromGit.Text = "Return";
            this.btnReturnFromGit.UseVisualStyleBackColor = true;
            this.btnReturnFromGit.Click += new System.EventHandler(this.btnReturnFromDescription_Click);
            // 
            // btnGitWeb
            // 
            this.btnGitWeb.Location = new System.Drawing.Point(20, 109);
            this.btnGitWeb.Name = "btnGitWeb";
            this.btnGitWeb.Size = new System.Drawing.Size(94, 29);
            this.btnGitWeb.TabIndex = 3;
            this.btnGitWeb.Text = "Git";
            this.btnGitWeb.UseVisualStyleBackColor = true;
            this.btnGitWeb.Click += new System.EventHandler(this.btnGitWeb_Click);
            // 
            // Git
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.btnGitWeb);
            this.Controls.Add(this.btnReturnFromGit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(717, 553);
            this.Name = "Git";
            this.Text = "Git";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnFromGit;
        private Button btnGitWeb;
    }
}