namespace Client
{
    partial class ListItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.WorkerIDPanel = new System.Windows.Forms.Panel();
            this.WorkerIDInput = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.LastLogInput = new System.Windows.Forms.Label();
            this.RoleInput = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.LastLogLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.WorkerIDPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(65, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.Control;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.WorkerIDPanel);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(5);
            this.HeaderPanel.Size = new System.Drawing.Size(294, 208);
            this.HeaderPanel.TabIndex = 9;
            // 
            // WorkerIDPanel
            // 
            this.WorkerIDPanel.Controls.Add(this.WorkerIDInput);
            this.WorkerIDPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkerIDPanel.Location = new System.Drawing.Point(5, 5);
            this.WorkerIDPanel.Name = "WorkerIDPanel";
            this.WorkerIDPanel.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.WorkerIDPanel.Size = new System.Drawing.Size(282, 28);
            this.WorkerIDPanel.TabIndex = 9;
            // 
            // WorkerIDInput
            // 
            this.WorkerIDInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkerIDInput.AutoSize = true;
            this.WorkerIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerIDInput.Location = new System.Drawing.Point(117, 3);
            this.WorkerIDInput.Margin = new System.Windows.Forms.Padding(0);
            this.WorkerIDInput.Name = "WorkerIDInput";
            this.WorkerIDInput.Size = new System.Drawing.Size(42, 24);
            this.WorkerIDInput.TabIndex = 10;
            this.WorkerIDInput.Text = "N/A";
            this.WorkerIDInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Controls.Add(this.LastLogInput);
            this.ContentPanel.Controls.Add(this.RoleInput);
            this.ContentPanel.Controls.Add(this.NameInput);
            this.ContentPanel.Controls.Add(this.NameLabel);
            this.ContentPanel.Controls.Add(this.RoleLabel);
            this.ContentPanel.Controls.Add(this.LastLogLabel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContentPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContentPanel.Location = new System.Drawing.Point(3, 217);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(294, 130);
            this.ContentPanel.TabIndex = 8;
            // 
            // LastLogInput
            // 
            this.LastLogInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastLogInput.AutoSize = true;
            this.LastLogInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLogInput.Location = new System.Drawing.Point(96, 81);
            this.LastLogInput.Margin = new System.Windows.Forms.Padding(10);
            this.LastLogInput.Name = "LastLogInput";
            this.LastLogInput.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.LastLogInput.Size = new System.Drawing.Size(41, 36);
            this.LastLogInput.TabIndex = 7;
            this.LastLogInput.Text = "N/A";
            // 
            // RoleInput
            // 
            this.RoleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleInput.AutoSize = true;
            this.RoleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleInput.Location = new System.Drawing.Point(96, 43);
            this.RoleInput.Margin = new System.Windows.Forms.Padding(10);
            this.RoleInput.Name = "RoleInput";
            this.RoleInput.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.RoleInput.Size = new System.Drawing.Size(41, 36);
            this.RoleInput.TabIndex = 6;
            this.RoleInput.Text = "N/A";
            // 
            // NameInput
            // 
            this.NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInput.AutoSize = true;
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(96, 2);
            this.NameInput.Margin = new System.Windows.Forms.Padding(10);
            this.NameInput.Name = "NameInput";
            this.NameInput.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.NameInput.Size = new System.Drawing.Size(41, 36);
            this.NameInput.TabIndex = 4;
            this.NameInput.Text = "N/A";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(2, 0);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.NameLabel.Size = new System.Drawing.Size(65, 36);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "NAME:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(2, 43);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(10);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.RoleLabel.Size = new System.Drawing.Size(62, 36);
            this.RoleLabel.TabIndex = 2;
            this.RoleLabel.Text = "ROLE:";
            // 
            // LastLogLabel
            // 
            this.LastLogLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastLogLabel.AutoSize = true;
            this.LastLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLogLabel.Location = new System.Drawing.Point(2, 80);
            this.LastLogLabel.Margin = new System.Windows.Forms.Padding(10);
            this.LastLogLabel.Name = "LastLogLabel";
            this.LastLogLabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.LastLogLabel.Size = new System.Drawing.Size(90, 36);
            this.LastLogLabel.TabIndex = 3;
            this.LastLogLabel.Text = "LASTLOG:";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ListItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(300, 350);
            this.Load += new System.EventHandler(this.ListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.WorkerIDPanel.ResumeLayout(false);
            this.WorkerIDPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel WorkerIDPanel;
        private System.Windows.Forms.Label WorkerIDInput;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label LastLogInput;
        private System.Windows.Forms.Label RoleInput;
        private System.Windows.Forms.Label NameInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label LastLogLabel;
    }
}
