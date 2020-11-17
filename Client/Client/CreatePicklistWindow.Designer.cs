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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ExpressLabel = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.ExpressCombobox = new System.Windows.Forms.ComboBox();
            this.PlatformCombobox = new System.Windows.Forms.ComboBox();
            this.CityCombobox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UserInputPanel = new System.Windows.Forms.Panel();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.LocationTextbox = new System.Windows.Forms.TextBox();
            this.ProductNameTextbox = new System.Windows.Forms.TextBox();
            this.ProductNumberTextbox = new System.Windows.Forms.TextBox();
            this.PicklistView = new System.Windows.Forms.ListView();
            this.ProductNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileDataGridView = new System.Windows.Forms.DataGridView();
            this.FunctionPanel.SuspendLayout();
            this.UserInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(38, 91);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(45, 13);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform";
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
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(441, 138);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "IMPORT";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(847, 138);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(99, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate picklist";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Controls.Add(this.OKButton);
            this.FunctionPanel.Controls.Add(this.ExpressCombobox);
            this.FunctionPanel.Controls.Add(this.PlatformCombobox);
            this.FunctionPanel.Controls.Add(this.CityCombobox);
            this.FunctionPanel.Controls.Add(this.AddButton);
            this.FunctionPanel.Controls.Add(this.GenerateButton);
            this.FunctionPanel.Controls.Add(this.ImportButton);
            this.FunctionPanel.Controls.Add(this.ExpressLabel);
            this.FunctionPanel.Controls.Add(this.PlatformLabel);
            this.FunctionPanel.Controls.Add(this.CityLabel);
            this.FunctionPanel.Controls.Add(this.TitleLabel);
            this.FunctionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionPanel.Location = new System.Drawing.Point(0, 0);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(982, 218);
            this.FunctionPanel.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(64, 187);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ExpressCombobox
            // 
            this.ExpressCombobox.FormattingEnabled = true;
            this.ExpressCombobox.Location = new System.Drawing.Point(41, 154);
            this.ExpressCombobox.Name = "ExpressCombobox";
            this.ExpressCombobox.Size = new System.Drawing.Size(121, 21);
            this.ExpressCombobox.TabIndex = 6;
            // 
            // PlatformCombobox
            // 
            this.PlatformCombobox.FormattingEnabled = true;
            this.PlatformCombobox.Location = new System.Drawing.Point(41, 107);
            this.PlatformCombobox.Name = "PlatformCombobox";
            this.PlatformCombobox.Size = new System.Drawing.Size(121, 21);
            this.PlatformCombobox.TabIndex = 6;
            // 
            // CityCombobox
            // 
            this.CityCombobox.FormattingEnabled = true;
            this.CityCombobox.Location = new System.Drawing.Point(41, 56);
            this.CityCombobox.Name = "CityCombobox";
            this.CityCombobox.Size = new System.Drawing.Size(121, 21);
            this.CityCombobox.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(873, 187);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 25);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UserInputPanel
            // 
            this.UserInputPanel.Controls.Add(this.AmountTextbox);
            this.UserInputPanel.Controls.Add(this.LocationTextbox);
            this.UserInputPanel.Controls.Add(this.ProductNameTextbox);
            this.UserInputPanel.Controls.Add(this.ProductNumberTextbox);
            this.UserInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInputPanel.Location = new System.Drawing.Point(0, 218);
            this.UserInputPanel.Name = "UserInputPanel";
            this.UserInputPanel.Size = new System.Drawing.Size(982, 37);
            this.UserInputPanel.TabIndex = 3;
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Location = new System.Drawing.Point(895, 11);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(75, 20);
            this.AmountTextbox.TabIndex = 0;
            // 
            // LocationTextbox
            // 
            this.LocationTextbox.Location = new System.Drawing.Point(676, 11);
            this.LocationTextbox.Name = "LocationTextbox";
            this.LocationTextbox.Size = new System.Drawing.Size(213, 20);
            this.LocationTextbox.TabIndex = 0;
            // 
            // ProductNameTextbox
            // 
            this.ProductNameTextbox.Location = new System.Drawing.Point(205, 11);
            this.ProductNameTextbox.Name = "ProductNameTextbox";
            this.ProductNameTextbox.Size = new System.Drawing.Size(465, 20);
            this.ProductNameTextbox.TabIndex = 0;
            // 
            // ProductNumberTextbox
            // 
            this.ProductNumberTextbox.Location = new System.Drawing.Point(4, 11);
            this.ProductNumberTextbox.Name = "ProductNumberTextbox";
            this.ProductNumberTextbox.Size = new System.Drawing.Size(195, 20);
            this.ProductNumberTextbox.TabIndex = 0;
            // 
            // PicklistView
            // 
            this.PicklistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductNumberColumn,
            this.ProductNameColumn,
            this.LocationColumn,
            this.AmountColumn});
            this.PicklistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicklistView.GridLines = true;
            this.PicklistView.HideSelection = false;
            this.PicklistView.Location = new System.Drawing.Point(0, 255);
            this.PicklistView.Name = "PicklistView";
            this.PicklistView.Size = new System.Drawing.Size(982, 503);
            this.PicklistView.TabIndex = 4;
            this.PicklistView.UseCompatibleStateImageBehavior = false;
            this.PicklistView.View = System.Windows.Forms.View.Details;
            // 
            // ProductNumberColumn
            // 
            this.ProductNumberColumn.Text = "Product Number";
            this.ProductNumberColumn.Width = 202;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.Text = "Product Name";
            this.ProductNameColumn.Width = 471;
            // 
            // LocationColumn
            // 
            this.LocationColumn.Text = "Location";
            this.LocationColumn.Width = 219;
            // 
            // AmountColumn
            // 
            this.AmountColumn.Text = "Amount";
            this.AmountColumn.Width = 159;
            // 
            // FileDataGridView
            // 
            this.FileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDataGridView.Location = new System.Drawing.Point(0, 255);
            this.FileDataGridView.Name = "FileDataGridView";
            this.FileDataGridView.Size = new System.Drawing.Size(982, 503);
            this.FileDataGridView.TabIndex = 5;
            // 
            // CreatePicklistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileDataGridView);
            this.Controls.Add(this.PicklistView);
            this.Controls.Add(this.UserInputPanel);
            this.Controls.Add(this.FunctionPanel);
            this.Name = "CreatePicklistWindow";
            this.Size = new System.Drawing.Size(982, 758);
            this.Load += new System.EventHandler(this.CreatePicklistWindow_Load);
            this.FunctionPanel.ResumeLayout(false);
            this.FunctionPanel.PerformLayout();
            this.UserInputPanel.ResumeLayout(false);
            this.UserInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ExpressLabel;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Panel UserInputPanel;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.TextBox LocationTextbox;
        private System.Windows.Forms.TextBox ProductNameTextbox;
        private System.Windows.Forms.TextBox ProductNumberTextbox;
        private System.Windows.Forms.ListView PicklistView;
        private System.Windows.Forms.ColumnHeader ProductNumberColumn;
        private System.Windows.Forms.ColumnHeader ProductNameColumn;
        private System.Windows.Forms.ColumnHeader LocationColumn;
        private System.Windows.Forms.ColumnHeader AmountColumn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox ExpressCombobox;
        private System.Windows.Forms.ComboBox PlatformCombobox;
        private System.Windows.Forms.ComboBox CityCombobox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridView FileDataGridView;
    }
}
