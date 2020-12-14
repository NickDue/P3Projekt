
namespace Client
{
    partial class AddProductWindow_vers1
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.textboxPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.pColliMaxBox = new System.Windows.Forms.TextBox();
            this.pColliBox = new System.Windows.Forms.TextBox();
            this.pNumberBox = new System.Windows.Forms.TextBox();
            this.pAmountBox = new System.Windows.Forms.TextBox();
            this.pColorBox = new System.Windows.Forms.TextBox();
            this.pVolumeBox = new System.Windows.Forms.TextBox();
            this.pWeightBox = new System.Windows.Forms.TextBox();
            this.pNameBox = new System.Windows.Forms.TextBox();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.textboxPanel.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1568, 180);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.Font = new System.Drawing.Font("DIN1451Engschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(614, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(393, 76);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ADD PRODUCT";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.textboxPanel);
            this.contentPanel.Controls.Add(this.labelPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 180);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1568, 678);
            this.contentPanel.TabIndex = 1;
            // 
            // textboxPanel
            // 
            this.textboxPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxPanel.Controls.Add(this.clearButton);
            this.textboxPanel.Controls.Add(this.pColliMaxBox);
            this.textboxPanel.Controls.Add(this.pColliBox);
            this.textboxPanel.Controls.Add(this.pNumberBox);
            this.textboxPanel.Controls.Add(this.pAmountBox);
            this.textboxPanel.Controls.Add(this.pColorBox);
            this.textboxPanel.Controls.Add(this.pVolumeBox);
            this.textboxPanel.Controls.Add(this.pWeightBox);
            this.textboxPanel.Controls.Add(this.pNameBox);
            this.textboxPanel.Location = new System.Drawing.Point(878, 35);
            this.textboxPanel.Name = "textboxPanel";
            this.textboxPanel.Size = new System.Drawing.Size(350, 600);
            this.textboxPanel.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("DIN1451Engschrift", 18F);
            this.clearButton.Location = new System.Drawing.Point(80, 550);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 38);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pColliMaxBox
            // 
            this.pColliMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pColliMaxBox.Location = new System.Drawing.Point(286, 50);
            this.pColliMaxBox.Name = "pColliMaxBox";
            this.pColliMaxBox.Size = new System.Drawing.Size(40, 35);
            this.pColliMaxBox.TabIndex = 3;
            // 
            // pColliBox
            // 
            this.pColliBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pColliBox.Location = new System.Drawing.Point(240, 50);
            this.pColliBox.Name = "pColliBox";
            this.pColliBox.Size = new System.Drawing.Size(40, 35);
            this.pColliBox.TabIndex = 2;
            // 
            // pNumberBox
            // 
            this.pNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pNumberBox.Location = new System.Drawing.Point(80, 50);
            this.pNumberBox.MaxLength = 500;
            this.pNumberBox.Name = "pNumberBox";
            this.pNumberBox.Size = new System.Drawing.Size(154, 35);
            this.pNumberBox.TabIndex = 1;
            // 
            // pAmountBox
            // 
            this.pAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAmountBox.Location = new System.Drawing.Point(80, 470);
            this.pAmountBox.Name = "pAmountBox";
            this.pAmountBox.Size = new System.Drawing.Size(246, 35);
            this.pAmountBox.TabIndex = 8;
            // 
            // pColorBox
            // 
            this.pColorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pColorBox.Location = new System.Drawing.Point(80, 210);
            this.pColorBox.Name = "pColorBox";
            this.pColorBox.Size = new System.Drawing.Size(246, 35);
            this.pColorBox.TabIndex = 5;
            // 
            // pVolumeBox
            // 
            this.pVolumeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pVolumeBox.Location = new System.Drawing.Point(80, 290);
            this.pVolumeBox.Name = "pVolumeBox";
            this.pVolumeBox.Size = new System.Drawing.Size(246, 35);
            this.pVolumeBox.TabIndex = 6;
            // 
            // pWeightBox
            // 
            this.pWeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pWeightBox.Location = new System.Drawing.Point(80, 380);
            this.pWeightBox.Name = "pWeightBox";
            this.pWeightBox.Size = new System.Drawing.Size(246, 35);
            this.pWeightBox.TabIndex = 7;
            // 
            // pNameBox
            // 
            this.pNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pNameBox.Location = new System.Drawing.Point(80, 130);
            this.pNameBox.Name = "pNameBox";
            this.pNameBox.Size = new System.Drawing.Size(246, 35);
            this.pNameBox.TabIndex = 4;
            // 
            // labelPanel
            // 
            this.labelPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPanel.Controls.Add(this.label1);
            this.labelPanel.Controls.Add(this.submitButton);
            this.labelPanel.Controls.Add(this.label6);
            this.labelPanel.Controls.Add(this.label5);
            this.labelPanel.Controls.Add(this.label2);
            this.labelPanel.Controls.Add(this.label4);
            this.labelPanel.Controls.Add(this.label3);
            this.labelPanel.Location = new System.Drawing.Point(410, 35);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(350, 600);
            this.labelPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product number:";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkGray;
            this.submitButton.Font = new System.Drawing.Font("DIN1451Engschrift", 18F);
            this.submitButton.Location = new System.Drawing.Point(39, 550);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(95, 38);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(48, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(48, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(48, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(48, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // AddProductWindow_vers1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "AddProductWindow_vers1";
            this.Size = new System.Drawing.Size(1568, 858);
            this.Load += new System.EventHandler(this.AddProductWindow_vers1_Load);
            this.headerPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.textboxPanel.ResumeLayout(false);
            this.textboxPanel.PerformLayout();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.TextBox pAmountBox;
        private System.Windows.Forms.TextBox pVolumeBox;
        private System.Windows.Forms.TextBox pNameBox;
        private System.Windows.Forms.TextBox pWeightBox;
        private System.Windows.Forms.TextBox pColorBox;
        private System.Windows.Forms.TextBox pNumberBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel textboxPanel;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.TextBox pColliMaxBox;
        private System.Windows.Forms.TextBox pColliBox;
    }
}
