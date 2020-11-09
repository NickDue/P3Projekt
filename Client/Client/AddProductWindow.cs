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
    public partial class AddProductWindow : UserControl
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void TitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearInput()
        {
            ProductNumberInput.Text = "";
            ProductNameInput.Text = "";
            VolumeInput.Text = "";
            ColorInput.Text = "";
            WeightInput.Text = "";
            AmountInput.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        static string Product = "";

        private string GenerateProductString()
        {
            Product = ProductNumberInput.Text + "#" + ProductNameInput.Text + "#" + VolumeInput.Text + "#" + ColorInput.Text + "#" + WeightInput.Text + "#" + AmountInput.Text;

            return Product;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            GenerateProductString();
        }
    }
}
