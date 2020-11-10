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
            this.components = new System.ComponentModel.Container();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.AmountPanel = new System.Windows.Forms.Panel();
            this.AmountInput = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.WeightPanel = new System.Windows.Forms.Panel();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.ColorInput = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.VolumePanel = new System.Windows.Forms.Panel();
            this.VolumeInput = new System.Windows.Forms.TextBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.ProductNamePanel = new System.Windows.Forms.Panel();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNumberPanel = new System.Windows.Forms.Panel();
            this.ProductNumberInput = new System.Windows.Forms.TextBox();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TitlePanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.AmountPanel.SuspendLayout();
            this.WeightPanel.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            this.VolumePanel.SuspendLayout();
            this.ProductNamePanel.SuspendLayout();
            this.ProductNumberPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
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
            this.ProductPanel.Controls.Add(this.AmountPanel);
            this.ProductPanel.Controls.Add(this.WeightPanel);
            this.ProductPanel.Controls.Add(this.ColorPanel);
            this.ProductPanel.Controls.Add(this.VolumePanel);
            this.ProductPanel.Controls.Add(this.ProductNamePanel);
            this.ProductPanel.Controls.Add(this.ProductNumberPanel);
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPanel.Location = new System.Drawing.Point(0, 254);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(982, 504);
            this.ProductPanel.TabIndex = 1;
            // 
            // AmountPanel
            // 
            this.AmountPanel.Controls.Add(this.AmountInput);
            this.AmountPanel.Controls.Add(this.AmountLabel);
            this.AmountPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AmountPanel.Location = new System.Drawing.Point(0, 420);
            this.AmountPanel.Name = "AmountPanel";
            this.AmountPanel.Size = new System.Drawing.Size(982, 84);
            this.AmountPanel.TabIndex = 5;
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
            // WeightPanel
            // 
            this.WeightPanel.Controls.Add(this.WeightInput);
            this.WeightPanel.Controls.Add(this.WeightLabel);
            this.WeightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeightPanel.Location = new System.Drawing.Point(0, 336);
            this.WeightPanel.Name = "WeightPanel";
            this.WeightPanel.Size = new System.Drawing.Size(982, 84);
            this.WeightPanel.TabIndex = 4;
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
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.ColorInput);
            this.ColorPanel.Controls.Add(this.ColorLabel);
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorPanel.Location = new System.Drawing.Point(0, 252);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(982, 84);
            this.ColorPanel.TabIndex = 3;
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
            // VolumePanel
            // 
            this.VolumePanel.Controls.Add(this.VolumeInput);
            this.VolumePanel.Controls.Add(this.VolumeLabel);
            this.VolumePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VolumePanel.Location = new System.Drawing.Point(0, 168);
            this.VolumePanel.Name = "VolumePanel";
            this.VolumePanel.Size = new System.Drawing.Size(982, 84);
            this.VolumePanel.TabIndex = 2;
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
            // ProductNamePanel
            // 
            this.ProductNamePanel.Controls.Add(this.ProductNameInput);
            this.ProductNamePanel.Controls.Add(this.ProductNameLabel);
            this.ProductNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductNamePanel.Location = new System.Drawing.Point(0, 84);
            this.ProductNamePanel.Name = "ProductNamePanel";
            this.ProductNamePanel.Size = new System.Drawing.Size(982, 84);
            this.ProductNamePanel.TabIndex = 1;
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
            // ProductNumberPanel
            // 
            this.ProductNumberPanel.Controls.Add(this.ProductNumberInput);
            this.ProductNumberPanel.Controls.Add(this.ProductNumberLabel);
            this.ProductNumberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductNumberPanel.Location = new System.Drawing.Point(0, 0);
            this.ProductNumberPanel.Name = "ProductNumberPanel";
            this.ProductNumberPanel.Size = new System.Drawing.Size(982, 84);
            this.ProductNumberPanel.TabIndex = 0;
            // 
            // ProductNumberInput
            // 
            this.ProductNumberInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProductNumberInput.Location = new System.Drawing.Point(263, 0);
            this.ProductNumberInput.Multiline = true;
            this.ProductNumberInput.Name = "ProductNumberInput";
            this.ProductNumberInput.Size = new System.Drawing.Size(719, 84);
            this.ProductNumberInput.TabIndex = 1;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.AmountPanel.ResumeLayout(false);
            this.AmountPanel.PerformLayout();
            this.WeightPanel.ResumeLayout(false);
            this.WeightPanel.PerformLayout();
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            this.VolumePanel.ResumeLayout(false);
            this.VolumePanel.PerformLayout();
            this.ProductNamePanel.ResumeLayout(false);
            this.ProductNamePanel.PerformLayout();
            this.ProductNumberPanel.ResumeLayout(false);
            this.ProductNumberPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel AmountPanel;
        private System.Windows.Forms.TextBox AmountInput;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Panel WeightPanel;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.TextBox ColorInput;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Panel VolumePanel;
        private System.Windows.Forms.TextBox VolumeInput;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Panel ProductNamePanel;
        private System.Windows.Forms.TextBox ProductNameInput;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Panel ProductNumberPanel;
        private System.Windows.Forms.TextBox ProductNumberInput;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
