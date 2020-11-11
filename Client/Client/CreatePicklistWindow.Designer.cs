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
            this.CityTextbox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformTextbox = new System.Windows.Forms.TextBox();
            this.ExpressLabel = new System.Windows.Forms.Label();
            this.ExpressTextbox = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.UserInputPanel = new System.Windows.Forms.Panel();
            this.PicklistView = new System.Windows.Forms.ListView();
            this.ProductNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductNumberTextbox = new System.Windows.Forms.TextBox();
            this.ProductNameTextbox = new System.Windows.Forms.TextBox();
            this.LocationTextbox = new System.Windows.Forms.TextBox();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.FunctionPanel.SuspendLayout();
            this.UserInputPanel.SuspendLayout();
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
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
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
            // ProductNumberTextbox
            // 
            this.ProductNumberTextbox.Location = new System.Drawing.Point(4, 11);
            this.ProductNumberTextbox.Name = "ProductNumberTextbox";
            this.ProductNumberTextbox.Size = new System.Drawing.Size(195, 20);
            this.ProductNumberTextbox.TabIndex = 0;
            this.ProductNumberTextbox.TextChanged += new System.EventHandler(this.ProductNumberTextbox_TextChanged);
            // 
            // ProductNameTextbox
            // 
            this.ProductNameTextbox.Location = new System.Drawing.Point(205, 11);
            this.ProductNameTextbox.Name = "ProductNameTextbox";
            this.ProductNameTextbox.Size = new System.Drawing.Size(465, 20);
            this.ProductNameTextbox.TabIndex = 0;
            this.ProductNameTextbox.TextChanged += new System.EventHandler(this.ProductNameTextbox_TextChanged);
            // 
            // LocationTextbox
            // 
            this.LocationTextbox.Location = new System.Drawing.Point(676, 11);
            this.LocationTextbox.Name = "LocationTextbox";
            this.LocationTextbox.Size = new System.Drawing.Size(213, 20);
            this.LocationTextbox.TabIndex = 0;
            this.LocationTextbox.TextChanged += new System.EventHandler(this.LocationTextbox_TextChanged);
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Location = new System.Drawing.Point(895, 11);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(75, 20);
            this.AmountTextbox.TabIndex = 0;
            this.AmountTextbox.TextChanged += new System.EventHandler(this.AmountTextbox_TextChanged);
            // 
            // CreatePicklistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextbox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox PlatformTextbox;
        private System.Windows.Forms.Label ExpressLabel;
        private System.Windows.Forms.TextBox ExpressTextbox;
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
    }
}
