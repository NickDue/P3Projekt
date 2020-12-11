
namespace Client
{
    partial class EmployeeEditer
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
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.officeRButton = new System.Windows.Forms.RadioButton();
            this.floorRButton = new System.Windows.Forms.RadioButton();
            this.roleLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.workerIDTextbox = new System.Windows.Forms.TextBox();
            this.workerIDLabel = new System.Windows.Forms.Label();
            this.titlebarPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.titlebarPanel.Controls.Add(this.titleLabel);
            this.titlebarPanel.Controls.Add(this.closeButton);
            this.titlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(484, 28);
            this.titlebarPanel.TabIndex = 0;
            this.titlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarPanel_MouseDown);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(192, 29);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Employee Editer";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeButton.IconColor = System.Drawing.Color.Black;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 25;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.Location = new System.Drawing.Point(426, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(58, 28);
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.officeRButton);
            this.contentPanel.Controls.Add(this.floorRButton);
            this.contentPanel.Controls.Add(this.roleLabel);
            this.contentPanel.Controls.Add(this.confirmPasswordLabel);
            this.contentPanel.Controls.Add(this.passwordLabel);
            this.contentPanel.Controls.Add(this.nameLabel);
            this.contentPanel.Controls.Add(this.confirmPasswordTextbox);
            this.contentPanel.Controls.Add(this.passwordTextbox);
            this.contentPanel.Controls.Add(this.nameTextbox);
            this.contentPanel.Controls.Add(this.cancelButton);
            this.contentPanel.Controls.Add(this.confirmButton);
            this.contentPanel.Controls.Add(this.workerIDTextbox);
            this.contentPanel.Controls.Add(this.workerIDLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 28);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(484, 483);
            this.contentPanel.TabIndex = 1;
            // 
            // officeRButton
            // 
            this.officeRButton.AutoSize = true;
            this.officeRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeRButton.Location = new System.Drawing.Point(274, 307);
            this.officeRButton.Name = "officeRButton";
            this.officeRButton.Size = new System.Drawing.Size(86, 29);
            this.officeRButton.TabIndex = 5;
            this.officeRButton.Tag = "";
            this.officeRButton.Text = "Office";
            this.officeRButton.UseVisualStyleBackColor = true;
            // 
            // floorRButton
            // 
            this.floorRButton.AutoSize = true;
            this.floorRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorRButton.Location = new System.Drawing.Point(153, 307);
            this.floorRButton.Name = "floorRButton";
            this.floorRButton.Size = new System.Drawing.Size(79, 29);
            this.floorRButton.TabIndex = 4;
            this.floorRButton.Tag = "";
            this.floorRButton.Text = "Floor";
            this.floorRButton.UseVisualStyleBackColor = true;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(67, 313);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(56, 25);
            this.roleLabel.TabIndex = 6;
            this.roleLabel.Text = "Role";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(67, 241);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(184, 25);
            this.confirmPasswordLabel.TabIndex = 6;
            this.confirmPasswordLabel.Text = "Confirm password";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(67, 169);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 25);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(67, 97);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(72, 269);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.PasswordChar = '*';
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(341, 31);
            this.confirmPasswordTextbox.TabIndex = 3;
            this.confirmPasswordTextbox.Tag = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(72, 197);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(341, 31);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.Tag = "Password";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(72, 125);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(341, 31);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.Tag = "Name";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(274, 382);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 35);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.AutoSize = true;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(153, 382);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 35);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // workerIDTextbox
            // 
            this.workerIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerIDTextbox.Location = new System.Drawing.Point(72, 60);
            this.workerIDTextbox.Name = "workerIDTextbox";
            this.workerIDTextbox.Size = new System.Drawing.Size(75, 31);
            this.workerIDTextbox.TabIndex = 2;
            this.workerIDTextbox.TabStop = false;
            // 
            // workerIDLabel
            // 
            this.workerIDLabel.AutoSize = true;
            this.workerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerIDLabel.Location = new System.Drawing.Point(67, 32);
            this.workerIDLabel.Name = "workerIDLabel";
            this.workerIDLabel.Size = new System.Drawing.Size(125, 25);
            this.workerIDLabel.TabIndex = 1;
            this.workerIDLabel.Text = "Worker ID#:";
            // 
            // EmployeeEditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titlebarPanel);
            this.Name = "EmployeeEditer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeEditer";
            this.Load += new System.EventHandler(this.EmployeeEditer_Load);
            this.titlebarPanel.ResumeLayout(false);
            this.titlebarPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebarPanel;
        private FontAwesome.Sharp.IconButton closeButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label workerIDLabel;
        private System.Windows.Forms.TextBox workerIDTextbox;
        private System.Windows.Forms.TextBox confirmPasswordTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton floorRButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.RadioButton officeRButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}