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
    public partial class SearchWindow2 : UserControl
    {
        public SearchWindow2()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EnableTextBoxEditing(ProductPanel);
        }

        private void EnableTextBoxEditing(Control control)
        {
            bool edit = true;

            if (edit)
            {
                foreach (TextBox tb in control.Controls.OfType<TextBox>())
                {
                    tb.ReadOnly = false;
                }

                edit = false;
            }

            else
            {
                foreach (TextBox tb in ProductPanel.Controls.OfType<TextBox>())
                {
                    tb.ReadOnly = true;
                }
            }
        }
    }
}
