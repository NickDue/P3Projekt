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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.EmployeeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RemoveButton.Font = new System.Drawing.Font("DIN1451Engschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddButton.Font = new System.Drawing.Font("DIN1451Engschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 40);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(259, 76);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Employees";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeaderPanel.Controls.Add(this.EditButton);
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Controls.Add(this.RemoveButton);
            this.HeaderPanel.Controls.Add(this.AddButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(982, 146);
            this.HeaderPanel.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EditButton.Font = new System.Drawing.Font("DIN1451Engschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(719, 91);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 40);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.Controls.Add(this.EmployeeFlowPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 146);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(982, 612);
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
            this.EmployeeFlowPanel.Size = new System.Drawing.Size(982, 612);
            this.EmployeeFlowPanel.TabIndex = 4;
            // 
            // EmployeesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmployeesWindow";
            this.Size = new System.Drawing.Size(982, 758);
            this.Load += new System.EventHandler(this.EmployeeFlowPanel_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.FlowLayoutPanel EmployeeFlowPanel;
    }
}
