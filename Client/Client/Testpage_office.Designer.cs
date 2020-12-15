namespace Client
{
    partial class Testpage_office
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ADDbtn = new System.Windows.Forms.Button();
            this.REMOVEbtn = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.GETbtn = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.changebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test page for office";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 337);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(656, 334);
            this.dataGridView.TabIndex = 2;
            // 
            // ADDbtn
            // 
            this.ADDbtn.Location = new System.Drawing.Point(459, 183);
            this.ADDbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(197, 49);
            this.ADDbtn.TabIndex = 3;
            this.ADDbtn.Text = "ADD";
            this.ADDbtn.UseVisualStyleBackColor = true;
            this.ADDbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // REMOVEbtn
            // 
            this.REMOVEbtn.Location = new System.Drawing.Point(457, 257);
            this.REMOVEbtn.Margin = new System.Windows.Forms.Padding(4);
            this.REMOVEbtn.Name = "REMOVEbtn";
            this.REMOVEbtn.Size = new System.Drawing.Size(199, 49);
            this.REMOVEbtn.TabIndex = 4;
            this.REMOVEbtn.Text = "REMOVE";
            this.REMOVEbtn.UseVisualStyleBackColor = true;
            this.REMOVEbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(707, 375);
            this.input1.Margin = new System.Windows.Forms.Padding(4);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(132, 22);
            this.input1.TabIndex = 5;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(707, 443);
            this.input2.Margin = new System.Windows.Forms.Padding(4);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(132, 22);
            this.input2.TabIndex = 6;
            // 
            // GETbtn
            // 
            this.GETbtn.Location = new System.Drawing.Point(47, 302);
            this.GETbtn.Margin = new System.Windows.Forms.Padding(4);
            this.GETbtn.Name = "GETbtn";
            this.GETbtn.Size = new System.Drawing.Size(100, 28);
            this.GETbtn.TabIndex = 7;
            this.GETbtn.Text = "GET";
            this.GETbtn.UseVisualStyleBackColor = true;
            this.GETbtn.Click += new System.EventHandler(this.GETbtn_Click);
            // 
            // employee
            // 
            this.employee.Location = new System.Drawing.Point(457, 105);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(199, 53);
            this.employee.TabIndex = 8;
            this.employee.Text = "ADD EMPLOYEE";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // changebtn
            // 
            this.changebtn.Location = new System.Drawing.Point(707, 105);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(210, 53);
            this.changebtn.TabIndex = 9;
            this.changebtn.Text = "CHANGE A PRODUCT";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // Testpage_office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.GETbtn);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.REMOVEbtn);
            this.Controls.Add(this.ADDbtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Testpage_office";
            this.Size = new System.Drawing.Size(1036, 688);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ADDbtn;
        private System.Windows.Forms.Button REMOVEbtn;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button GETbtn;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button changebtn;
    }
}
