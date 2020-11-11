using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class EmployeeInputWindow : UserControl
    {
        public EmployeeInputWindow()
        {
            InitializeComponent();
        }

        private void EmployeeInputWindow_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.BringToFront();
            this.Size = new Size(500, 600);

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
