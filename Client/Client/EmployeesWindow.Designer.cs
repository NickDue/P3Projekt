namespace Client
{
    partial class EmployeesWindow
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.EmployeeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeInputWindow1 = new Client.EmployeeInputWindow();
            this.HeaderPanel.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(835, 91);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(110, 40);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.TabStop = false;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(603, 91);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 40);
            this.AddButton.TabIndex = 1;
            this.AddButton.TabStop = false;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(16, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(359, 73);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Employees";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.EditButton);
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Controls.Add(this.RemoveButton);
            this.HeaderPanel.Controls.Add(this.AddButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(10);
            this.HeaderPanel.Size = new System.Drawing.Size(974, 146);
            this.HeaderPanel.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(719, 91);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 40);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundPanel.Controls.Add(this.ContentPanel);
            this.BackgroundPanel.Controls.Add(this.HeaderPanel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Padding = new System.Windows.Forms.Padding(3);
            this.BackgroundPanel.Size = new System.Drawing.Size(982, 758);
            this.BackgroundPanel.TabIndex = 2;
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Controls.Add(this.EmployeeFlowPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(3, 149);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(974, 604);
            this.ContentPanel.TabIndex = 1;
            // 
            // EmployeeFlowPanel
            // 
            this.EmployeeFlowPanel.AutoScroll = true;
            this.EmployeeFlowPanel.AutoSize = true;
            this.EmployeeFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeFlowPanel.BackColor = System.Drawing.Color.White;
            this.EmployeeFlowPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeFlowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeFlowPanel.Name = "EmployeeFlowPanel";
            this.EmployeeFlowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.EmployeeFlowPanel.Size = new System.Drawing.Size(972, 602);
            this.EmployeeFlowPanel.TabIndex = 4;
            // 
            // employeeInputWindow1
            // 
            this.employeeInputWindow1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.employeeInputWindow1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.employeeInputWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeInputWindow1.Location = new System.Drawing.Point(241, 142);
            this.employeeInputWindow1.Name = "employeeInputWindow1";
            this.employeeInputWindow1.Padding = new System.Windows.Forms.Padding(3);
            this.employeeInputWindow1.Size = new System.Drawing.Size(500, 600);
            this.employeeInputWindow1.TabIndex = 0;
            // 
            // EmployeesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.employeeInputWindow1);
            this.Controls.Add(this.BackgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmployeesWindow";
            this.Size = new System.Drawing.Size(982, 758);
            this.Load += new System.EventHandler(this.EmployeeFlowPanel_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TitleLabel;
        private EmployeeInputWindow employeeInputWindow1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.FlowLayoutPanel EmployeeFlowPanel;
    }
}
