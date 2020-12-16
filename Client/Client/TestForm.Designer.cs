namespace Client
{
    partial class TestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testpage_floor1 = new Client.Testpage_floor();
            this.button1 = new System.Windows.Forms.Button();
            this.testpage_office1 = new Client.Testpage_office();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testpage_floor1
            // 
            this.testpage_floor1.Location = new System.Drawing.Point(0, 1);
            this.testpage_floor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.testpage_floor1.Name = "testpage_floor1";
            this.testpage_floor1.Size = new System.Drawing.Size(793, 456);
            this.testpage_floor1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 146);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testpage_office1
            // 
            this.testpage_office1.Location = new System.Drawing.Point(0, 1);
            this.testpage_office1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.testpage_office1.Name = "testpage_office1";
            this.testpage_office1.Size = new System.Drawing.Size(668, 475);
            this.testpage_office1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 273);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "extra functionalities";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testpage_office1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testpage_floor1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Testpage_floor testpage_floor1;
        private System.Windows.Forms.Button button1;
        private Testpage_office testpage_office1;
        private System.Windows.Forms.Button button2;
    }
}