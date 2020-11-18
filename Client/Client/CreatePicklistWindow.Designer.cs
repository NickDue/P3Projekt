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
            this.PicklistView = new System.Windows.Forms.ListView();
            this.ProductNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileDataGridView = new System.Windows.Forms.DataGridView();
            this.UserInputPanel = new System.Windows.Forms.Panel();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleBox = new System.Windows.Forms.TextBox();
            this.FunctionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).BeginInit();
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
            this.ImportButton.Location = new System.Drawing.Point(773, 8);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(867, 8);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(99, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Export to PDF";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Controls.Add(this.RoleBox);
            this.FunctionPanel.Controls.Add(this.IDBox);
            this.FunctionPanel.Controls.Add(this.EmployeeNameBox);
            this.FunctionPanel.Controls.Add(this.RoleLabel);
            this.FunctionPanel.Controls.Add(this.IDLabel);
            this.FunctionPanel.Controls.Add(this.EmployeeNameLabel);
            this.FunctionPanel.Controls.Add(this.OKButton);
            this.FunctionPanel.Controls.Add(this.ExpressCombobox);
            this.FunctionPanel.Controls.Add(this.PlatformCombobox);
            this.FunctionPanel.Controls.Add(this.CityCombobox);
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
            this.PicklistView.Location = new System.Drawing.Point(0, 257);
            this.PicklistView.Name = "PicklistView";
            this.PicklistView.Size = new System.Drawing.Size(982, 501);
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
            this.FileDataGridView.AllowUserToAddRows = false;
            this.FileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDataGridView.Location = new System.Drawing.Point(0, 257);
            this.FileDataGridView.Name = "FileDataGridView";
            this.FileDataGridView.Size = new System.Drawing.Size(982, 501);
            this.FileDataGridView.TabIndex = 5;
            // 
            // UserInputPanel
            // 
            this.UserInputPanel.Controls.Add(this.GenerateButton);
            this.UserInputPanel.Controls.Add(this.ImportButton);
            this.UserInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInputPanel.Location = new System.Drawing.Point(0, 218);
            this.UserInputPanel.Name = "UserInputPanel";
            this.UserInputPanel.Size = new System.Drawing.Size(982, 39);
            this.UserInputPanel.TabIndex = 3;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(653, 71);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(56, 13);
            this.EmployeeNameLabel.TabIndex = 8;
            this.EmployeeNameLabel.Text = "Employee:";
            // 
            // EmployeeNameBox
            // 
            this.EmployeeNameBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmployeeNameBox.Location = new System.Drawing.Point(715, 68);
            this.EmployeeNameBox.Name = "EmployeeNameBox";
            this.EmployeeNameBox.ReadOnly = true;
            this.EmployeeNameBox.Size = new System.Drawing.Size(236, 20);
            this.EmployeeNameBox.TabIndex = 9;
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(688, 106);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID:";
            // 
            // IDBox
            // 
            this.IDBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IDBox.Location = new System.Drawing.Point(715, 103);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(236, 20);
            this.IDBox.TabIndex = 9;
            // 
            // RoleLabel
            // 
            this.RoleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(677, 141);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(32, 13);
            this.RoleLabel.TabIndex = 8;
            this.RoleLabel.Text = "Role:";
            // 
            // RoleBox
            // 
            this.RoleBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RoleBox.Location = new System.Drawing.Point(715, 138);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.ReadOnly = true;
            this.RoleBox.Size = new System.Drawing.Size(236, 20);
            this.RoleBox.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).EndInit();
            this.UserInputPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ListView PicklistView;
        private System.Windows.Forms.ColumnHeader ProductNumberColumn;
        private System.Windows.Forms.ColumnHeader ProductNameColumn;
        private System.Windows.Forms.ColumnHeader LocationColumn;
        private System.Windows.Forms.ColumnHeader AmountColumn;
        private System.Windows.Forms.ComboBox ExpressCombobox;
        private System.Windows.Forms.ComboBox PlatformCombobox;
        private System.Windows.Forms.ComboBox CityCombobox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridView FileDataGridView;
        private System.Windows.Forms.Panel UserInputPanel;
        private System.Windows.Forms.TextBox RoleBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox EmployeeNameBox;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
    }
}
