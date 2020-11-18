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
        }

        // Validates input in fields and displays error message of those missing
        private void ValidateInput()
        {
            List<TextBox> list = new List<TextBox>();

            list.Add(ProductNumberInput);
            list.Add(ColliNumberInput);
            list.Add(ColliTotalInput);
            list.Add(ProductNameInput);
            list.Add(VolumeInput);
            list.Add(ColorInput);
            list.Add(WeightInput);
            list.Add(AmountInput);

            int i = 0;
            List<string> productList = new List<string>();
            string errorPreset = "The following fields are incorrectly filled: \n\n";
            string errorMessage = "";
            
            foreach (TextBox tb in list)
            {
                productList.Add(tb.Text);
                errorMessage += (CheckTextBox(tb));
                i++;
            }
            
            if(errorMessage.Length > 0)
            {
                MessageBox.Show(errorPreset + errorMessage, "Error");
            }
            else
            {
                //var productString = string.Join(Environment.NewLine, productList);
                //MessageBox.Show(productString);
                ConfirmChoice();
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
            Product = ProductNumberInput.Text + "-" + ColliNumberInput.Text + "-" + ColliTotalInput.Text + "#" + ProductNameInput.Text + "#" + VolumeInput.Text + "#" + ColorInput.Text + "#" + WeightInput.Text + "#" + AmountInput.Text;

            return Product;
        } 

        private void ConfirmChoice()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this product?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(GenerateProductString());
                MessageBox.Show("Product added succesfully");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        //Checks if the given input for Product Number is a number. If not, it deletes the line, forcing you to start over
        private void ProductNumberInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ProductNumberInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ProductNumberInput.Text = ProductNumberInput.Text.Remove(ProductNumberInput.Text.Length - ProductNumberInput.Text.Length);
            }
        }

        //Checks if the given input for Colli Number is a number. If not, it deletes the line, forcing you to start over
        private void ColliNumberInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ColliNumberInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ColliNumberInput.Text = ColliNumberInput.Text.Remove(ColliNumberInput.Text.Length - ColliNumberInput.Text.Length);
            }
        }

        //Checks if the given input for Colli Total is a number. If not, it deletes the line, forcing you to start over
        private void ColliTotalInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ColliTotalInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ColliTotalInput.Text = ColliTotalInput.Text.Remove(ColliTotalInput.Text.Length - ColliTotalInput.Text.Length);
            }
        }

        //Checks if the given input for Volume is a number or a decimal. If not, it deletes the line, forcing you to start over
        private void VolumeInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(VolumeInput.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers or decimal points.");
                VolumeInput.Text = VolumeInput.Text.Remove(VolumeInput.Text.Length - VolumeInput.Text.Length);
            }
        }

        //Checks if the given input for Weight is a number or decimal. If not, it deletes the line, forcing you to start over
        private void WeightInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(WeightInput.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers or decimal points.");
                WeightInput.Text = WeightInput.Text.Remove(WeightInput.Text.Length - WeightInput.Text.Length);
            }
        }
    }
}
