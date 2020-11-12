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
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.WorkerID = new System.Windows.Forms.Label();
            this.RoleInput = new System.Windows.Forms.MaskedTextBox();
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
            this.Content.Controls.Add(this.CancelButton);
            this.Content.Controls.Add(this.ConfirmButton);
            this.Content.Controls.Add(this.button1);
            this.Content.Controls.Add(this.ProfilePicture);
            this.Content.Controls.Add(this.WorkerID);
            this.Content.Controls.Add(this.RoleInput);
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
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(262, 510);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 28);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(169, 510);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 28);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(253, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicture.Location = new System.Drawing.Point(169, 102);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(168, 172);
            this.ProfilePicture.TabIndex = 6;
            this.ProfilePicture.TabStop = false;
            // 
            // WorkerID
            // 
            this.WorkerID.AutoSize = true;
            this.WorkerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerID.Location = new System.Drawing.Point(412, 13);
            this.WorkerID.Margin = new System.Windows.Forms.Padding(0);
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.Padding = new System.Windows.Forms.Padding(5);
            this.WorkerID.Size = new System.Drawing.Size(70, 34);
            this.WorkerID.TabIndex = 5;
            this.WorkerID.Text = "12345";
            // 
            // RoleInput
            // 
            this.RoleInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleInput.Location = new System.Drawing.Point(61, 447);
            this.RoleInput.Name = "RoleInput";
            this.RoleInput.Size = new System.Drawing.Size(376, 29);
            this.RoleInput.TabIndex = 4;
            // 
            // NameInput
            // 
            this.NameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(61, 347);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(376, 29);
            this.NameInput.TabIndex = 3;
            // 
            // WorkerIDLabel
            // 
            this.WorkerIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkerIDLabel.AutoSize = true;
            this.WorkerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerIDLabel.Location = new System.Drawing.Point(293, 13);
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
            this.RoleLabel.Location = new System.Drawing.Point(57, 420);
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
            this.NameLabel.Location = new System.Drawing.Point(57, 320);
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
        private System.Windows.Forms.MaskedTextBox RoleInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label WorkerID;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button button1;
    }
}
