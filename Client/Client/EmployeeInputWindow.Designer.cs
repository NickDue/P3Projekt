namespace Client
{
    partial class EmployeeInputWindow
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
            this.Header = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Panel();
            this.OfficeRButton = new System.Windows.Forms.RadioButton();
            this.FloorRButton = new System.Windows.Forms.RadioButton();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.EnterPassword = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.WorkerID = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.WorkerIDLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(3);
            this.Header.Size = new System.Drawing.Size(154, 30);
            this.Header.TabIndex = 0;
            this.Header.Text = "Add Employee";
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.SystemColors.Control;
            this.Content.Controls.Add(this.OfficeRButton);
            this.Content.Controls.Add(this.FloorRButton);
            this.Content.Controls.Add(this.ConfirmPasswordLabel);
            this.Content.Controls.Add(this.PasswordLabel);
            this.Content.Controls.Add(this.ConfirmPassword);
            this.Content.Controls.Add(this.EnterPassword);
            this.Content.Controls.Add(this.CancelButton);
            this.Content.Controls.Add(this.ConfirmButton);
            this.Content.Controls.Add(this.button1);
            this.Content.Controls.Add(this.ProfilePicture);
            this.Content.Controls.Add(this.WorkerID);
            this.Content.Controls.Add(this.NameInput);
            this.Content.Controls.Add(this.WorkerIDLabel);
            this.Content.Controls.Add(this.RoleLabel);
            this.Content.Controls.Add(this.NameLabel);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(3, 33);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(494, 564);
            this.Content.TabIndex = 1;
            // 
            // OfficeRButton
            // 
            this.OfficeRButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OfficeRButton.AutoSize = true;
            this.OfficeRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficeRButton.Location = new System.Drawing.Point(174, 470);
            this.OfficeRButton.Name = "OfficeRButton";
            this.OfficeRButton.Size = new System.Drawing.Size(86, 24);
            this.OfficeRButton.TabIndex = 15;
            this.OfficeRButton.Text = "OFFICE";
            this.OfficeRButton.UseVisualStyleBackColor = true;
            // 
            // FloorRButton
            // 
            this.FloorRButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FloorRButton.AutoSize = true;
            this.FloorRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorRButton.Location = new System.Drawing.Point(72, 470);
            this.FloorRButton.Name = "FloorRButton";
            this.FloorRButton.Size = new System.Drawing.Size(82, 24);
            this.FloorRButton.TabIndex = 14;
            this.FloorRButton.Text = "FLOOR";
            this.FloorRButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(57, 373);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(161, 24);
            this.ConfirmPasswordLabel.TabIndex = 13;
            this.ConfirmPasswordLabel.Text = "Confirm password";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(57, 305);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(141, 24);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "Enter password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(61, 400);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(376, 29);
            this.ConfirmPassword.TabIndex = 2;
            this.ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // EnterPassword
            // 
            this.EnterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPassword.Location = new System.Drawing.Point(61, 330);
            this.EnterPassword.Name = "EnterPassword";
            this.EnterPassword.Size = new System.Drawing.Size(376, 29);
            this.EnterPassword.TabIndex = 1;
            this.EnterPassword.UseSystemPasswordChar = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(249, 514);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 28);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(152, 514);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 28);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicture.Location = new System.Drawing.Point(152, 50);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(172, 171);
            this.ProfilePicture.TabIndex = 6;
            this.ProfilePicture.TabStop = false;
            // 
            // WorkerID
            // 
            this.WorkerID.AutoSize = true;
            this.WorkerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerID.Location = new System.Drawing.Point(267, 13);
            this.WorkerID.Margin = new System.Windows.Forms.Padding(0);
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.Padding = new System.Windows.Forms.Padding(5);
            this.WorkerID.Size = new System.Drawing.Size(70, 34);
            this.WorkerID.TabIndex = 5;
            this.WorkerID.Text = "12345";
            // 
            // NameInput
            // 
            this.NameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(61, 260);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(376, 29);
            this.NameInput.TabIndex = 0;
            // 
            // WorkerIDLabel
            // 
            this.WorkerIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkerIDLabel.AutoSize = true;
            this.WorkerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerIDLabel.Location = new System.Drawing.Point(148, 13);
            this.WorkerIDLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WorkerIDLabel.Name = "WorkerIDLabel";
            this.WorkerIDLabel.Padding = new System.Windows.Forms.Padding(5);
            this.WorkerIDLabel.Size = new System.Drawing.Size(123, 34);
            this.WorkerIDLabel.TabIndex = 2;
            this.WorkerIDLabel.Text = "Worker ID: #";
            // 
            // RoleLabel
            // 
            this.RoleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(57, 442);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(49, 24);
            this.RoleLabel.TabIndex = 1;
            this.RoleLabel.Text = "Role";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(57, 233);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 24);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(466, 1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 30);
            this.Close.TabIndex = 2;
            this.Close.TabStop = false;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // EmployeeInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Header);
            this.Name = "EmployeeInputWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.EmployeeInputWindow_Load);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label WorkerIDLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label WorkerID;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.TextBox EnterPassword;
        private System.Windows.Forms.RadioButton OfficeRButton;
        private System.Windows.Forms.RadioButton FloorRButton;
    }
}
