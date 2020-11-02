namespace Client
{
    partial class MyhomeForm
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
            this.Navigationbar = new System.Windows.Forms.Panel();
            this.NavButton7 = new System.Windows.Forms.Button();
            this.NavButton6 = new System.Windows.Forms.Button();
            this.NavButton5 = new System.Windows.Forms.Button();
            this.NavButton4 = new System.Windows.Forms.Button();
            this.NavButton3 = new System.Windows.Forms.Button();
            this.NavButton2 = new System.Windows.Forms.Button();
            this.NavButton1 = new System.Windows.Forms.Button();
            this.LandingPage = new System.Windows.Forms.Panel();
            this.MyhomeLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.searchWindow1 = new Client.SearchWindow();
            this.Navigationbar.SuspendLayout();
            this.LandingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navigationbar
            // 
            this.Navigationbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Navigationbar.Controls.Add(this.NavButton7);
            this.Navigationbar.Controls.Add(this.NavButton6);
            this.Navigationbar.Controls.Add(this.NavButton5);
            this.Navigationbar.Controls.Add(this.NavButton4);
            this.Navigationbar.Controls.Add(this.NavButton3);
            this.Navigationbar.Controls.Add(this.NavButton2);
            this.Navigationbar.Controls.Add(this.NavButton1);
            this.Navigationbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Navigationbar.Location = new System.Drawing.Point(0, 0);
            this.Navigationbar.Name = "Navigationbar";
            this.Navigationbar.Size = new System.Drawing.Size(202, 761);
            this.Navigationbar.TabIndex = 0;
            this.Navigationbar.Paint += new System.Windows.Forms.PaintEventHandler(this.Navigationbar_Paint);
            // 
            // NavButton7
            // 
            this.NavButton7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NavButton7.Location = new System.Drawing.Point(3, 674);
            this.NavButton7.Name = "NavButton7";
            this.NavButton7.Size = new System.Drawing.Size(186, 75);
            this.NavButton7.TabIndex = 7;
            this.NavButton7.Text = "Log out";
            this.NavButton7.UseVisualStyleBackColor = true;
            this.NavButton7.Click += new System.EventHandler(this.NavButton7_Click);
            // 
            // NavButton6
            // 
            this.NavButton6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton6.Location = new System.Drawing.Point(0, 474);
            this.NavButton6.Name = "NavButton6";
            this.NavButton6.Size = new System.Drawing.Size(186, 75);
            this.NavButton6.TabIndex = 6;
            this.NavButton6.Text = "Logs";
            this.NavButton6.UseVisualStyleBackColor = true;
            this.NavButton6.Click += new System.EventHandler(this.NavButton6_Click);
            // 
            // NavButton5
            // 
            this.NavButton5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton5.Location = new System.Drawing.Point(0, 381);
            this.NavButton5.Name = "NavButton5";
            this.NavButton5.Size = new System.Drawing.Size(186, 75);
            this.NavButton5.TabIndex = 5;
            this.NavButton5.Text = "Employees";
            this.NavButton5.UseVisualStyleBackColor = true;
            this.NavButton5.Click += new System.EventHandler(this.NavButton5_Click);
            // 
            // NavButton4
            // 
            this.NavButton4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton4.Location = new System.Drawing.Point(3, 290);
            this.NavButton4.Name = "NavButton4";
            this.NavButton4.Size = new System.Drawing.Size(186, 75);
            this.NavButton4.TabIndex = 4;
            this.NavButton4.Text = "Create Picklist";
            this.NavButton4.UseVisualStyleBackColor = true;
            this.NavButton4.Click += new System.EventHandler(this.NavButton4_Click);
            // 
            // NavButton3
            // 
            this.NavButton3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton3.Location = new System.Drawing.Point(3, 201);
            this.NavButton3.Name = "NavButton3";
            this.NavButton3.Size = new System.Drawing.Size(186, 65);
            this.NavButton3.TabIndex = 3;
            this.NavButton3.Text = "All product";
            this.NavButton3.UseVisualStyleBackColor = true;
            this.NavButton3.Click += new System.EventHandler(this.NavButton3_Click);
            // 
            // NavButton2
            // 
            this.NavButton2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton2.Location = new System.Drawing.Point(3, 107);
            this.NavButton2.Name = "NavButton2";
            this.NavButton2.Size = new System.Drawing.Size(185, 77);
            this.NavButton2.TabIndex = 2;
            this.NavButton2.Text = "Add product";
            this.NavButton2.UseVisualStyleBackColor = true;
            this.NavButton2.Click += new System.EventHandler(this.NavButton2_Click);
            // 
            // NavButton1
            // 
            this.NavButton1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton1.Location = new System.Drawing.Point(3, 22);
            this.NavButton1.Name = "NavButton1";
            this.NavButton1.Size = new System.Drawing.Size(185, 63);
            this.NavButton1.TabIndex = 1;
            this.NavButton1.Text = "Search";
            this.NavButton1.UseVisualStyleBackColor = true;
            this.NavButton1.Click += new System.EventHandler(this.NavButton1_Click);
            // 
            // LandingPage
            // 
            this.LandingPage.Controls.Add(this.searchWindow1);
            this.LandingPage.Controls.Add(this.MyhomeLabel);
            this.LandingPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LandingPage.Location = new System.Drawing.Point(202, 3);
            this.LandingPage.Name = "LandingPage";
            this.LandingPage.Size = new System.Drawing.Size(982, 758);
            this.LandingPage.TabIndex = 2;
            this.LandingPage.Paint += new System.Windows.Forms.PaintEventHandler(this.LandingPage_Paint);
            // 
            // MyhomeLabel
            // 
            this.MyhomeLabel.AutoSize = true;
            this.MyhomeLabel.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyhomeLabel.Location = new System.Drawing.Point(246, 67);
            this.MyhomeLabel.Name = "MyhomeLabel";
            this.MyhomeLabel.Size = new System.Drawing.Size(495, 56);
            this.MyhomeLabel.TabIndex = 1;
            this.MyhomeLabel.Text = "Welcome to MyHome database";
            this.MyhomeLabel.Click += new System.EventHandler(this.MyhomeLabel_Click);
            // 
            // searchWindow1
            // 
            this.searchWindow1.Location = new System.Drawing.Point(0, -3);
            this.searchWindow1.Name = "searchWindow1";
            this.searchWindow1.Size = new System.Drawing.Size(982, 758);
            this.searchWindow1.TabIndex = 2;
            // 
            // MyhomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.LandingPage);
            this.Controls.Add(this.Navigationbar);
            this.Name = "MyhomeForm";
            this.Text = "Myhome Database";
            this.Load += new System.EventHandler(this.MyhomeForm_Load);
            this.Navigationbar.ResumeLayout(false);
            this.LandingPage.ResumeLayout(false);
            this.LandingPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Navigationbar;
        private System.Windows.Forms.Button NavButton1;
        private System.Windows.Forms.Button NavButton2;
        private System.Windows.Forms.Button NavButton3;
        private System.Windows.Forms.Button NavButton5;
        private System.Windows.Forms.Button NavButton4;
        private System.Windows.Forms.Button NavButton6;
        private System.Windows.Forms.Button NavButton7;
        private System.Windows.Forms.Panel LandingPage;
        private System.Windows.Forms.Label MyhomeLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private SearchWindow searchWindow1;
    }
}

