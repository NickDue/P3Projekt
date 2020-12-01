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
            this.Headline = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Headline
            // 
            this.Headline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Headline.AutoSize = true;
            this.Headline.Font = new System.Drawing.Font("DIN1451Engschrift", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headline.Location = new System.Drawing.Point(124, 16);
            this.Headline.Name = "Headline";
            this.Headline.Size = new System.Drawing.Size(86, 13);
            this.Headline.TabIndex = 0;
            this.Headline.Text = "All products in database";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(3, 111);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(24, 13);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(3, 135);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(52, 13);
            this.AmountLabel.TabIndex = 3;
            this.AmountLabel.Text = "Total amount:";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(65, 184);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(39, 13);
            this.ProductIDLabel.TabIndex = 4;
            this.ProductIDLabel.Text = "ProductID";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(296, 184);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(53, 13);
            this.ProductNameLabel.TabIndex = 6;
            this.ProductNameLabel.Text = "Product name";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(563, 184);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(24, 13);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(784, 184);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(35, 13);
            this.LocationLabel.TabIndex = 8;
            this.LocationLabel.Text = "Location";
            // 
            // TablePanel
            // 
            this.TablePanel.BackColor = System.Drawing.Color.White;
            this.TablePanel.Controls.Add(this.ProductGridView);
            this.TablePanel.Location = new System.Drawing.Point(3, 211);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(976, 519);
            this.TablePanel.TabIndex = 10;
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(976, 519);
            this.ProductGridView.TabIndex = 10;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AllProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Headline);
            this.Name = "AllProductsPage";
            this.Size = new System.Drawing.Size(982, 758);
            this.TablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Headline;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.DataGridView ProductGridView;
    }
}
