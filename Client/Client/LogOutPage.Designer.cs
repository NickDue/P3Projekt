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
            this.LogOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.Location = new System.Drawing.Point(40, 265);
            this.LogOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(1238, 91);
            this.LogOutLabel.TabIndex = 0;
            this.LogOutLabel.Text = "Are you sure you wish to log out?";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("DIN1451Engschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(487, 524);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(309, 86);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "LOG OUT";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // LogOutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LogOutLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogOutPage";
            this.Size = new System.Drawing.Size(1309, 933);
            this.Load += new System.EventHandler(this.LogOutPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Button LogoutButton;
    }
}
