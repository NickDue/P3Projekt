namespace Client
{
    partial class SearchWindow
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.LocationPanel = new System.Windows.Forms.Panel();
            this.PrimaryLocationLabel = new System.Windows.Forms.Label();
            this.PrimaryColliLabel = new System.Windows.Forms.Label();
            this.SecondaryLocationPanel = new System.Windows.Forms.Panel();
            this.ScrollBar = new System.Windows.Forms.VScrollBar();
            this.PrimaryLocationBox = new System.Windows.Forms.TextBox();
            this.PrimaryColliBox = new System.Windows.Forms.TextBox();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNumLabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.VolumeBox = new System.Windows.Forms.TextBox();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.ProductNumBox = new System.Windows.Forms.TextBox();
            this.AmountTitle = new System.Windows.Forms.Label();
            this.WeightTitle = new System.Windows.Forms.Label();
            this.ColorTitle = new System.Windows.Forms.Label();
            this.VolumeTitle = new System.Windows.Forms.Label();
            this.ProductNameTitle = new System.Windows.Forms.Label();
            this.ProductNumTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Checkbutton = new System.Windows.Forms.Button();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.NOButton = new System.Windows.Forms.Button();
            this.YESButton = new System.Windows.Forms.Button();
            this.LastChanceLabel = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.LocationPanel.SuspendLayout();
            this.SecondaryLocationPanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(291, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(339, 48);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Enter product ID number";
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(311, 103);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(292, 20);
            this.SearchInput.TabIndex = 1;
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(875, 26);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 64);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LocationPanel
            // 
            this.LocationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LocationPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LocationPanel.Controls.Add(this.PrimaryLocationLabel);
            this.LocationPanel.Controls.Add(this.PrimaryColliLabel);
            this.LocationPanel.Controls.Add(this.SecondaryLocationPanel);
            this.LocationPanel.Controls.Add(this.PrimaryLocationBox);
            this.LocationPanel.Controls.Add(this.PrimaryColliBox);
            this.LocationPanel.Location = new System.Drawing.Point(0, 211);
            this.LocationPanel.Name = "LocationPanel";
            this.LocationPanel.Size = new System.Drawing.Size(491, 547);
            this.LocationPanel.TabIndex = 3;
            // 
            // PrimaryLocationLabel
            // 
            this.PrimaryLocationLabel.AutoSize = true;
            this.PrimaryLocationLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PrimaryLocationLabel.Location = new System.Drawing.Point(256, 71);
            this.PrimaryLocationLabel.Name = "PrimaryLocationLabel";
            this.PrimaryLocationLabel.Size = new System.Drawing.Size(104, 26);
            this.PrimaryLocationLabel.TabIndex = 17;
            this.PrimaryLocationLabel.Text = "H4-12-31";
            // 
            // PrimaryColliLabel
            // 
            this.PrimaryColliLabel.AutoSize = true;
            this.PrimaryColliLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimaryColliLabel.Location = new System.Drawing.Point(13, 71);
            this.PrimaryColliLabel.Name = "PrimaryColliLabel";
            this.PrimaryColliLabel.Size = new System.Drawing.Size(45, 26);
            this.PrimaryColliLabel.TabIndex = 19;
            this.PrimaryColliLabel.Text = "1/2";
            // 
            // SecondaryLocationPanel
            // 
            this.SecondaryLocationPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SecondaryLocationPanel.Controls.Add(this.ScrollBar);
            this.SecondaryLocationPanel.Location = new System.Drawing.Point(3, 182);
            this.SecondaryLocationPanel.Name = "SecondaryLocationPanel";
            this.SecondaryLocationPanel.Size = new System.Drawing.Size(488, 362);
            this.SecondaryLocationPanel.TabIndex = 18;
            // 
            // ScrollBar
            // 
            this.ScrollBar.Location = new System.Drawing.Point(450, 0);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(35, 362);
            this.ScrollBar.TabIndex = 29;
            // 
            // PrimaryLocationBox
            // 
            this.PrimaryLocationBox.Location = new System.Drawing.Point(184, 98);
            this.PrimaryLocationBox.Name = "PrimaryLocationBox";
            this.PrimaryLocationBox.Size = new System.Drawing.Size(208, 20);
            this.PrimaryLocationBox.TabIndex = 17;
            // 
            // PrimaryColliBox
            // 
            this.PrimaryColliBox.Location = new System.Drawing.Point(18, 101);
            this.PrimaryColliBox.Name = "PrimaryColliBox";
            this.PrimaryColliBox.Size = new System.Drawing.Size(45, 20);
            this.PrimaryColliBox.TabIndex = 0;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductPanel.Controls.Add(this.AmountLabel);
            this.ProductPanel.Controls.Add(this.WeightLabel);
            this.ProductPanel.Controls.Add(this.ColorLabel);
            this.ProductPanel.Controls.Add(this.VolumeLabel);
            this.ProductPanel.Controls.Add(this.ProductNameLabel);
            this.ProductPanel.Controls.Add(this.ProductNumLabel);
            this.ProductPanel.Controls.Add(this.amountBox);
            this.ProductPanel.Controls.Add(this.WeightBox);
            this.ProductPanel.Controls.Add(this.ColorBox);
            this.ProductPanel.Controls.Add(this.VolumeBox);
            this.ProductPanel.Controls.Add(this.ProductNameBox);
            this.ProductPanel.Controls.Add(this.ProductNumBox);
            this.ProductPanel.Controls.Add(this.AmountTitle);
            this.ProductPanel.Controls.Add(this.WeightTitle);
            this.ProductPanel.Controls.Add(this.ColorTitle);
            this.ProductPanel.Controls.Add(this.VolumeTitle);
            this.ProductPanel.Controls.Add(this.ProductNameTitle);
            this.ProductPanel.Controls.Add(this.ProductNumTitle);
            this.ProductPanel.Location = new System.Drawing.Point(491, 211);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(491, 547);
            this.ProductPanel.TabIndex = 4;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.AmountLabel.Location = new System.Drawing.Point(306, 474);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(36, 26);
            this.AmountLabel.TabIndex = 25;
            this.AmountLabel.Text = "12";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.WeightLabel.Location = new System.Drawing.Point(306, 380);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(36, 26);
            this.WeightLabel.TabIndex = 24;
            this.WeightLabel.Text = "40";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ColorLabel.Location = new System.Drawing.Point(306, 280);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(51, 26);
            this.ColorLabel.TabIndex = 23;
            this.ColorLabel.Text = "RED";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.VolumeLabel.Location = new System.Drawing.Point(306, 182);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(53, 26);
            this.VolumeLabel.TabIndex = 22;
            this.VolumeLabel.Text = "0,54";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ProductNameLabel.Location = new System.Drawing.Point(246, 95);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(165, 26);
            this.ProductNameLabel.TabIndex = 21;
            this.ProductNameLabel.Text = "NewYorker Sofa";
            // 
            // ProductNumLabel
            // 
            this.ProductNumLabel.AutoSize = true;
            this.ProductNumLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ProductNumLabel.Location = new System.Drawing.Point(287, 22);
            this.ProductNumLabel.Name = "ProductNumLabel";
            this.ProductNumLabel.Size = new System.Drawing.Size(72, 26);
            this.ProductNumLabel.TabIndex = 20;
            this.ProductNumLabel.Text = "13311";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(224, 503);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(208, 20);
            this.amountBox.TabIndex = 16;
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(224, 415);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(208, 20);
            this.WeightBox.TabIndex = 15;
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(224, 318);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(208, 20);
            this.ColorBox.TabIndex = 14;
            // 
            // VolumeBox
            // 
            this.VolumeBox.Location = new System.Drawing.Point(224, 214);
            this.VolumeBox.Name = "VolumeBox";
            this.VolumeBox.Size = new System.Drawing.Size(208, 20);
            this.VolumeBox.TabIndex = 13;
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(224, 131);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(208, 20);
            this.ProductNameBox.TabIndex = 12;
            // 
            // ProductNumBox
            // 
            this.ProductNumBox.Location = new System.Drawing.Point(224, 50);
            this.ProductNumBox.Name = "ProductNumBox";
            this.ProductNumBox.Size = new System.Drawing.Size(208, 20);
            this.ProductNumBox.TabIndex = 11;
            // 
            // AmountTitle
            // 
            this.AmountTitle.AutoSize = true;
            this.AmountTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTitle.Location = new System.Drawing.Point(51, 477);
            this.AmountTitle.Name = "AmountTitle";
            this.AmountTitle.Size = new System.Drawing.Size(81, 22);
            this.AmountTitle.TabIndex = 10;
            this.AmountTitle.Text = "Amount:";
            // 
            // WeightTitle
            // 
            this.WeightTitle.AutoSize = true;
            this.WeightTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTitle.Location = new System.Drawing.Point(51, 384);
            this.WeightTitle.Name = "WeightTitle";
            this.WeightTitle.Size = new System.Drawing.Size(74, 22);
            this.WeightTitle.TabIndex = 9;
            this.WeightTitle.Text = "Weight:";
            // 
            // ColorTitle
            // 
            this.ColorTitle.AutoSize = true;
            this.ColorTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorTitle.Location = new System.Drawing.Point(51, 283);
            this.ColorTitle.Name = "ColorTitle";
            this.ColorTitle.Size = new System.Drawing.Size(60, 22);
            this.ColorTitle.TabIndex = 8;
            this.ColorTitle.Text = "Color:";
            // 
            // VolumeTitle
            // 
            this.VolumeTitle.AutoSize = true;
            this.VolumeTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeTitle.Location = new System.Drawing.Point(51, 179);
            this.VolumeTitle.Name = "VolumeTitle";
            this.VolumeTitle.Size = new System.Drawing.Size(77, 22);
            this.VolumeTitle.TabIndex = 7;
            this.VolumeTitle.Text = "Volume:";
            // 
            // ProductNameTitle
            // 
            this.ProductNameTitle.AutoSize = true;
            this.ProductNameTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTitle.Location = new System.Drawing.Point(51, 98);
            this.ProductNameTitle.Name = "ProductNameTitle";
            this.ProductNameTitle.Size = new System.Drawing.Size(129, 22);
            this.ProductNameTitle.TabIndex = 6;
            this.ProductNameTitle.Text = "Product name:";
            // 
            // ProductNumTitle
            // 
            this.ProductNumTitle.AutoSize = true;
            this.ProductNumTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNumTitle.Location = new System.Drawing.Point(51, 25);
            this.ProductNumTitle.Name = "ProductNumTitle";
            this.ProductNumTitle.Size = new System.Drawing.Size(148, 22);
            this.ProductNumTitle.TabIndex = 0;
            this.ProductNumTitle.Text = "Product number:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Location info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product info:";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(628, 86);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(96, 54);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.UseWaitCursor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Chartreuse;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(849, 103);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(101, 64);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Checkbutton
            // 
            this.Checkbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbutton.Location = new System.Drawing.Point(18, 86);
            this.Checkbutton.Name = "Checkbutton";
            this.Checkbutton.Size = new System.Drawing.Size(133, 60);
            this.Checkbutton.TabIndex = 9;
            this.Checkbutton.Text = "Check";
            this.Checkbutton.UseVisualStyleBackColor = true;
            this.Checkbutton.Click += new System.EventHandler(this.Checkbutton_Click);
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLabel.Location = new System.Drawing.Point(-5, 26);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(703, 48);
            this.CheckLabel.TabIndex = 10;
            this.CheckLabel.Text = "Check here for see if you have entered the right input";
            // 
            // NOButton
            // 
            this.NOButton.BackColor = System.Drawing.Color.DarkRed;
            this.NOButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOButton.Location = new System.Drawing.Point(311, 130);
            this.NOButton.Name = "NOButton";
            this.NOButton.Size = new System.Drawing.Size(103, 37);
            this.NOButton.TabIndex = 11;
            this.NOButton.Text = "NO";
            this.NOButton.UseVisualStyleBackColor = false;
            this.NOButton.Click += new System.EventHandler(this.NOButton_Click);
            // 
            // YESButton
            // 
            this.YESButton.BackColor = System.Drawing.Color.Green;
            this.YESButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YESButton.Location = new System.Drawing.Point(520, 130);
            this.YESButton.Name = "YESButton";
            this.YESButton.Size = new System.Drawing.Size(103, 37);
            this.YESButton.TabIndex = 12;
            this.YESButton.Text = "YES";
            this.YESButton.UseVisualStyleBackColor = false;
            this.YESButton.Click += new System.EventHandler(this.YESButton_Click);
            // 
            // LastChanceLabel
            // 
            this.LastChanceLabel.AutoSize = true;
            this.LastChanceLabel.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastChanceLabel.Location = new System.Drawing.Point(200, 35);
            this.LastChanceLabel.Name = "LastChanceLabel";
            this.LastChanceLabel.Size = new System.Drawing.Size(490, 48);
            this.LastChanceLabel.TabIndex = 13;
            this.LastChanceLabel.Text = "Are you sure to change this product?";
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(875, 26);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 24;
            this.Backbutton.Text = "Back ->";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.LastChanceLabel);
            this.Controls.Add(this.YESButton);
            this.Controls.Add(this.NOButton);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.Checkbutton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.LocationPanel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SearchWindow";
            this.Size = new System.Drawing.Size(982, 758);
            this.Load += new System.EventHandler(this.SearchWindow_Load);
            this.LocationPanel.ResumeLayout(false);
            this.LocationPanel.PerformLayout();
            this.SecondaryLocationPanel.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel LocationPanel;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Label ProductNumTitle;
        private System.Windows.Forms.TextBox ProductNumBox;
        private System.Windows.Forms.Label AmountTitle;
        private System.Windows.Forms.Label WeightTitle;
        private System.Windows.Forms.Label ColorTitle;
        private System.Windows.Forms.Label VolumeTitle;
        private System.Windows.Forms.Label ProductNameTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.TextBox VolumeBox;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.TextBox PrimaryColliBox;
        private System.Windows.Forms.Panel SecondaryLocationPanel;
        private System.Windows.Forms.TextBox PrimaryLocationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.VScrollBar ScrollBar;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label PrimaryLocationLabel;
        private System.Windows.Forms.Label PrimaryColliLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductNumLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Button Checkbutton;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Button NOButton;
        private System.Windows.Forms.Button YESButton;
        private System.Windows.Forms.Label LastChanceLabel;
        private System.Windows.Forms.Button Backbutton;
    }
}
