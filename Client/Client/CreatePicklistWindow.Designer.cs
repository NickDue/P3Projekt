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
            this.FunctionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGridView)).BeginInit();
            this.UserInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 48F);
            this.TitleLabel.Location = new System.Drawing.Point(407, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(209, 76);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "PICKLIST";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.CityLabel.Location = new System.Drawing.Point(33, 21);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(54, 26);
            this.CityLabel.TabIndex = 1;
            this.CityLabel.Text = "City";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.PlatformLabel.Location = new System.Drawing.Point(35, 89);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(102, 26);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform";
            // 
            // ExpressLabel
            // 
            this.ExpressLabel.AutoSize = true;
            this.ExpressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpressLabel.Location = new System.Drawing.Point(35, 154);
            this.ExpressLabel.Name = "ExpressLabel";
            this.ExpressLabel.Size = new System.Drawing.Size(97, 25);
            this.ExpressLabel.TabIndex = 1;
            this.ExpressLabel.Text = "Express";
            // 
            // ImportButton
            // 
            this.ImportButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImportButton.AutoSize = true;
            this.ImportButton.Font = new System.Drawing.Font("DIN1451Engschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(687, 10);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(95, 38);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "IMPORT";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GenerateButton.AutoSize = true;
            this.GenerateButton.Font = new System.Drawing.Font("DIN1451Engschrift", 18F);
            this.GenerateButton.Location = new System.Drawing.Point(813, 10);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(133, 38);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "EXPORT TO PDF";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
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
            // ExpressCombobox
            // 
            this.ExpressCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpressCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ExpressCombobox.FormattingEnabled = true;
            this.ExpressCombobox.Location = new System.Drawing.Point(38, 180);
            this.ExpressCombobox.Name = "ExpressCombobox";
            this.ExpressCombobox.Size = new System.Drawing.Size(169, 33);
            this.ExpressCombobox.TabIndex = 6;
            // 
            // PlatformCombobox
            // 
            this.PlatformCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlatformCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PlatformCombobox.FormattingEnabled = true;
            this.PlatformCombobox.Location = new System.Drawing.Point(38, 115);
            this.PlatformCombobox.Name = "PlatformCombobox";
            this.PlatformCombobox.Size = new System.Drawing.Size(169, 33);
            this.PlatformCombobox.TabIndex = 6;
            // 
            // CityCombobox
            // 
            this.CityCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CityCombobox.FormattingEnabled = true;
            this.CityCombobox.Location = new System.Drawing.Point(38, 50);
            this.CityCombobox.Name = "CityCombobox";
            this.CityCombobox.Size = new System.Drawing.Size(169, 33);
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
            this.PicklistView.Location = new System.Drawing.Point(0, 278);
            this.PicklistView.Name = "PicklistView";
            this.PicklistView.Size = new System.Drawing.Size(982, 480);
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
            this.FileDataGridView.AllowUserToDeleteRows = false;
            this.FileDataGridView.AllowUserToResizeRows = false;
            this.FileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDataGridView.Location = new System.Drawing.Point(0, 278);
            this.FileDataGridView.Name = "FileDataGridView";
            this.FileDataGridView.ReadOnly = true;
            this.FileDataGridView.Size = new System.Drawing.Size(982, 480);
            this.FileDataGridView.TabIndex = 5;
            // 
            // UserInputPanel
            // 
            this.UserInputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.UserInputPanel.Controls.Add(this.GenerateButton);
            this.UserInputPanel.Controls.Add(this.ImportButton);
            this.UserInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInputPanel.Location = new System.Drawing.Point(0, 218);
            this.UserInputPanel.Name = "UserInputPanel";
            this.UserInputPanel.Size = new System.Drawing.Size(982, 60);
            this.UserInputPanel.TabIndex = 3;
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
            this.UserInputPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView FileDataGridView;
        private System.Windows.Forms.Panel UserInputPanel;
    }
}
