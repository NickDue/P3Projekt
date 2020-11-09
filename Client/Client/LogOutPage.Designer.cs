namespace Client
{
    partial class LogOutPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.Location = new System.Drawing.Point(287, 80);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(316, 86);
            this.LogOutLabel.TabIndex = 0;
            this.LogOutLabel.Text = "Log out?";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(314, 369);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(250, 153);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // LogOutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LogOutLabel);
            this.Name = "LogOutPage";
            this.Size = new System.Drawing.Size(982, 758);
            this.Load += new System.EventHandler(this.LogOutPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Button LogoutButton;
    }
}
