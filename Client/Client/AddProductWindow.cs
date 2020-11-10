using System;
using System.Collections.Generic;
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
            ProductNumberInput.Clear();
            ProductNameInput.Clear();
            VolumeInput.Clear();
            ColorInput.Clear();
            WeightInput.Clear();
            AmountInput.Clear();
            // do something
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ValidateInput();
            GenerateProductString();
        }

        // Validates input in fields and displays error message of those missing
        private void ValidateInput()
        {
            List<TextBox> list = new List<TextBox>();
            list.Add(ProductNumberInput);
            list.Add(ProductNameInput);
            list.Add(VolumeInput);
            list.Add(ColorInput);
            list.Add(WeightInput);
            list.Add(AmountInput);

            string errorPreset = "The following is missing: \n\n";
            string errorMessage = "";

            foreach (TextBox tb in list)
            {
                errorMessage += (CheckTextBox(tb));
            }
            
            if(errorMessage.Length > 0)
            {
                MessageBox.Show(errorPreset + errorMessage, "Error");
            }
        }

        // Checks if textbox is empty or whitespace
        private string CheckTextBox(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                return tb.Name + "\n";
            }
            else 
            {
                return null;
            }
        }

        static string Product = "";

        // Assembles a product in one string
        private string GenerateProductString()
        {
            Product = ProductNumberInput.Text + "#" + ProductNameInput.Text + "#" + VolumeInput.Text + "#" + ColorInput.Text + "#" + WeightInput.Text + "#" + AmountInput.Text;

            return Product;
        }

    }
}
