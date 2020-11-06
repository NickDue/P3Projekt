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
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.EmployeeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FunctionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Controls.Add(this.RemoveButton);
            this.FunctionPanel.Controls.Add(this.AddButton);
            this.FunctionPanel.Controls.Add(this.TitleLabel);
            this.FunctionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionPanel.Location = new System.Drawing.Point(0, 0);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(982, 151);
            this.FunctionPanel.TabIndex = 0;
            // 
            // EmployeeFlowPanel
            // 
            this.EmployeeFlowPanel.AutoScroll = true;
            this.EmployeeFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeFlowPanel.Location = new System.Drawing.Point(0, 151);
            this.EmployeeFlowPanel.Name = "EmployeeFlowPanel";
            this.EmployeeFlowPanel.Size = new System.Drawing.Size(982, 607);
            this.EmployeeFlowPanel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(55, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(359, 73);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Employees";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(713, 82);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(854, 82);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeFlowPanel);
            this.Controls.Add(this.FunctionPanel);
            this.Name = "EmployeesWindow";
            this.Size = new System.Drawing.Size(982, 758);
            this.FunctionPanel.ResumeLayout(false);
            this.FunctionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.FlowLayoutPanel EmployeeFlowPanel;
    }
}
