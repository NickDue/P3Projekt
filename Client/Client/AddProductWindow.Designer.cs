namespace Client
{
    partial class AddProductWindow
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
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AmountInput = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ColorInput = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VolumeInput = new System.Windows.Forms.TextBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductNumbetInput = new System.Windows.Forms.TextBox();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.SubmitButton);
            this.TitlePanel.Controls.Add(this.ClearButton);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(982, 254);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitlePanel_Paint);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(849, 195);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(65, 195);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(152, 40);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(694, 55);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Enter new product information";
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.panel6);
            this.ProductPanel.Controls.Add(this.panel5);
            this.ProductPanel.Controls.Add(this.panel4);
            this.ProductPanel.Controls.Add(this.panel3);
            this.ProductPanel.Controls.Add(this.panel2);
            this.ProductPanel.Controls.Add(this.panel1);
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPanel.Location = new System.Drawing.Point(0, 254);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(982, 504);
            this.ProductPanel.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.AmountInput);
            this.panel6.Controls.Add(this.AmountLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 420);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(982, 84);
            this.panel6.TabIndex = 5;
            // 
            // AmountInput
            // 
            this.AmountInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.AmountInput.Location = new System.Drawing.Point(263, 0);
            this.AmountInput.Multiline = true;
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(719, 84);
            this.AmountInput.TabIndex = 1;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(62, 35);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(107, 29);
            this.AmountLabel.TabIndex = 0;
            this.AmountLabel.Text = "Amount:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.WeightInput);
            this.panel5.Controls.Add(this.WeightLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 336);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 84);
            this.panel5.TabIndex = 4;
            // 
            // WeightInput
            // 
            this.WeightInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.WeightInput.Location = new System.Drawing.Point(263, 0);
            this.WeightInput.Multiline = true;
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(719, 84);
            this.WeightInput.TabIndex = 1;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(62, 35);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(101, 29);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "Weight:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ColorInput);
            this.panel4.Controls.Add(this.ColorLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 84);
            this.panel4.TabIndex = 3;
            // 
            // ColorInput
            // 
            this.ColorInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.ColorInput.Location = new System.Drawing.Point(263, 0);
            this.ColorInput.Multiline = true;
            this.ColorInput.Name = "ColorInput";
            this.ColorInput.Size = new System.Drawing.Size(719, 84);
            this.ColorInput.TabIndex = 1;
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(62, 38);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(84, 29);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Color:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.VolumeInput);
            this.panel3.Controls.Add(this.VolumeLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 84);
            this.panel3.TabIndex = 2;
            // 
            // VolumeInput
            // 
            this.VolumeInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.VolumeInput.Location = new System.Drawing.Point(263, 0);
            this.VolumeInput.Multiline = true;
            this.VolumeInput.Name = "VolumeInput";
            this.VolumeInput.Size = new System.Drawing.Size(719, 84);
            this.VolumeInput.TabIndex = 1;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeLabel.Location = new System.Drawing.Point(62, 40);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(108, 29);
            this.VolumeLabel.TabIndex = 0;
            this.VolumeLabel.Text = "Volume:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductNameInput);
            this.panel2.Controls.Add(this.ProductNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 84);
            this.panel2.TabIndex = 1;
            // 
            // ProductNameInput
            // 
            this.ProductNameInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProductNameInput.Location = new System.Drawing.Point(263, 0);
            this.ProductNameInput.Multiline = true;
            this.ProductNameInput.Name = "ProductNameInput";
            this.ProductNameInput.Size = new System.Drawing.Size(719, 84);
            this.ProductNameInput.TabIndex = 1;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(62, 37);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(181, 29);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Product name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProductNumbetInput);
            this.panel1.Controls.Add(this.ProductNumberLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 84);
            this.panel1.TabIndex = 0;
            // 
            // ProductNumbetInput
            // 
            this.ProductNumbetInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProductNumbetInput.Location = new System.Drawing.Point(263, 0);
            this.ProductNumbetInput.Multiline = true;
            this.ProductNumbetInput.Name = "ProductNumbetInput";
            this.ProductNumbetInput.Size = new System.Drawing.Size(719, 84);
            this.ProductNumbetInput.TabIndex = 1;
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNumberLabel.Location = new System.Drawing.Point(60, 34);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(205, 29);
            this.ProductNumberLabel.TabIndex = 0;
            this.ProductNumberLabel.Text = "Product number:";
            // 
            // AddProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.TitlePanel);
            this.Name = "AddProductWindow";
            this.Size = new System.Drawing.Size(982, 758);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ProductPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox AmountInput;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ColorInput;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox VolumeInput;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ProductNameInput;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ProductNumbetInput;
        private System.Windows.Forms.Label ProductNumberLabel;
    }
}
