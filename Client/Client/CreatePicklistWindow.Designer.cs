namespace Client
{
    partial class CreatePicklistWindow
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
            this.ProductNumberPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextbox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformTextbox = new System.Windows.Forms.TextBox();
            this.ExpressLabel = new System.Windows.Forms.Label();
            this.ExpressTextbox = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CreatePicklistScrollbar = new System.Windows.Forms.VScrollBar();
            this.FunctionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Controls.Add(this.GenerateButton);
            this.FunctionPanel.Controls.Add(this.ImportButton);
            this.FunctionPanel.Controls.Add(this.ExpressTextbox);
            this.FunctionPanel.Controls.Add(this.ExpressLabel);
            this.FunctionPanel.Controls.Add(this.PlatformTextbox);
            this.FunctionPanel.Controls.Add(this.PlatformLabel);
            this.FunctionPanel.Controls.Add(this.CityTextbox);
            this.FunctionPanel.Controls.Add(this.CityLabel);
            this.FunctionPanel.Controls.Add(this.TitleLabel);
            this.FunctionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionPanel.Location = new System.Drawing.Point(0, 0);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(982, 218);
            this.FunctionPanel.TabIndex = 0;
            // 
            // ProductNumberPanel
            // 
            this.ProductNumberPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProductNumberPanel.Location = new System.Drawing.Point(0, 218);
            this.ProductNumberPanel.Name = "ProductNumberPanel";
            this.ProductNumberPanel.Size = new System.Drawing.Size(170, 540);
            this.ProductNumberPanel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(392, 73);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(179, 55);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Picklist";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(38, 39);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 1;
            this.CityLabel.Text = "City";
            // 
            // CityTextbox
            // 
            this.CityTextbox.Location = new System.Drawing.Point(41, 56);
            this.CityTextbox.Name = "CityTextbox";
            this.CityTextbox.Size = new System.Drawing.Size(100, 20);
            this.CityTextbox.TabIndex = 2;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(38, 86);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(45, 13);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform";
            // 
            // PlatformTextbox
            // 
            this.PlatformTextbox.Location = new System.Drawing.Point(41, 103);
            this.PlatformTextbox.Name = "PlatformTextbox";
            this.PlatformTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlatformTextbox.TabIndex = 2;
            // 
            // ExpressLabel
            // 
            this.ExpressLabel.AutoSize = true;
            this.ExpressLabel.Location = new System.Drawing.Point(38, 138);
            this.ExpressLabel.Name = "ExpressLabel";
            this.ExpressLabel.Size = new System.Drawing.Size(44, 13);
            this.ExpressLabel.TabIndex = 1;
            this.ExpressLabel.Text = "Express";
            // 
            // ExpressTextbox
            // 
            this.ExpressTextbox.Location = new System.Drawing.Point(41, 155);
            this.ExpressTextbox.Name = "ExpressTextbox";
            this.ExpressTextbox.Size = new System.Drawing.Size(100, 20);
            this.ExpressTextbox.TabIndex = 2;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(441, 138);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "IMPORT";
            this.ImportButton.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(847, 138);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(99, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate picklist";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // CreatePicklistScrollbar
            // 
            this.CreatePicklistScrollbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreatePicklistScrollbar.Location = new System.Drawing.Point(965, 218);
            this.CreatePicklistScrollbar.Name = "CreatePicklistScrollbar";
            this.CreatePicklistScrollbar.Size = new System.Drawing.Size(17, 540);
            this.CreatePicklistScrollbar.TabIndex = 2;
            // 
            // CreatePicklistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreatePicklistScrollbar);
            this.Controls.Add(this.ProductNumberPanel);
            this.Controls.Add(this.FunctionPanel);
            this.Name = "CreatePicklistWindow";
            this.Size = new System.Drawing.Size(982, 758);
            this.Load += new System.EventHandler(this.CreatePicklistWindow_Load);
            this.FunctionPanel.ResumeLayout(false);
            this.FunctionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox ExpressTextbox;
        private System.Windows.Forms.Label ExpressLabel;
        private System.Windows.Forms.TextBox PlatformTextbox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox CityTextbox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ProductNumberPanel;
        private System.Windows.Forms.VScrollBar CreatePicklistScrollbar;
    }
}
