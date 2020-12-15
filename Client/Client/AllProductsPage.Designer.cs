namespace Client
{
    partial class AllProductsPage
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Headline = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AmountLabelOutput = new System.Windows.Forms.Label();
            this.DateLabelOutput = new System.Windows.Forms.Label();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(17, 100);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(172, 29);
            this.AmountLabel.TabIndex = 3;
            this.AmountLabel.Text = "Total amount:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(294, 100);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(74, 29);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date:";
            // 
            // Headline
            // 
            this.Headline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Headline.AutoSize = true;
            this.Headline.Font = new System.Drawing.Font("DIN1451Engschrift", 48F);
            this.Headline.Location = new System.Drawing.Point(337, 20);
            this.Headline.Name = "Headline";
            this.Headline.Size = new System.Drawing.Size(326, 76);
            this.Headline.TabIndex = 0;
            this.Headline.Text = "ALL PRODUCTS";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TopPanel.Controls.Add(this.AmountLabelOutput);
            this.TopPanel.Controls.Add(this.DateLabelOutput);
            this.TopPanel.Controls.Add(this.Headline);
            this.TopPanel.Controls.Add(this.DateLabel);
            this.TopPanel.Controls.Add(this.AmountLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(982, 134);
            this.TopPanel.TabIndex = 9;
            // 
            // AmountLabelOutput
            // 
            this.AmountLabelOutput.AutoSize = true;
            this.AmountLabelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabelOutput.Location = new System.Drawing.Point(195, 100);
            this.AmountLabelOutput.Name = "AmountLabelOutput";
            this.AmountLabelOutput.Size = new System.Drawing.Size(53, 29);
            this.AmountLabelOutput.TabIndex = 4;
            this.AmountLabelOutput.Text = "N/A";
            // 
            // DateLabelOutput
            // 
            this.DateLabelOutput.AutoSize = true;
            this.DateLabelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabelOutput.Location = new System.Drawing.Point(374, 100);
            this.DateLabelOutput.Name = "DateLabelOutput";
            this.DateLabelOutput.Size = new System.Drawing.Size(53, 29);
            this.DateLabelOutput.TabIndex = 4;
            this.DateLabelOutput.Text = "N/A";
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.AllowUserToResizeColumns = false;
            this.ProductGridView.AllowUserToResizeRows = false;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGridView.Location = new System.Drawing.Point(0, 134);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.Size = new System.Drawing.Size(982, 624);
            this.ProductGridView.TabIndex = 10;
            // 
            // AllProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.TopPanel);
            this.Name = "AllProductsPage";
            this.Size = new System.Drawing.Size(982, 758);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label Headline;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Label AmountLabelOutput;
        private System.Windows.Forms.Label DateLabelOutput;
    }
}
