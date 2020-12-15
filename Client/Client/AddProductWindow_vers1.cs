using Client.TCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AddProductWindow_vers1 : UserControl
    {
        public AddProductWindow_vers1()
        {
            InitializeComponent();
        }

        private void AddProductWindow_vers1_Load(object sender, EventArgs e)
        {
            int x, y;
            x = (headerPanel.Size.Width - titleLabel.Size.Width) / 2;
            titleLabel.Location = new Point(x, titleLabel.Location.Y);

            x = ((contentPanel.Size.Width - labelPanel.Size.Width) / 2) - 200;
            y = ((contentPanel.Size.Height - labelPanel.Size.Height) / 2);
            labelPanel.Location = new Point(x, y);

            x = ((contentPanel.Size.Width - textboxPanel.Size.Width) / 2) + 200;
            y = ((contentPanel.Size.Height - textboxPanel.Size.Height) / 2);
            textboxPanel.Location = new Point(x, y);

            x = ((labelPanel.Size.Width - submitButton.Size.Width) / 2);
            submitButton.Location = new Point(x, submitButton.Location.Y);

            x = ((textboxPanel.Size.Width - clearButton.Size.Width) / 2);
            clearButton.Location = new Point(x, clearButton.Location.Y);

            pNumberBox.MaxLength = 5;

            pColliBox.MaxLength = 2;
            pColliMaxBox.MaxLength = 2;


        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            foreach (TextBox tb in textboxPanel.Controls.OfType<TextBox>())
            {
                tb.Text = String.Empty;
            }
        }

        private string GetInputs()
        {
            string pNumber, pName, pColor, pVolume, pWeight, pAmount;
            pNumber = FormatProductNumberString(pNumberBox.Text, pColliBox.Text, pColliMaxBox.Text);
            pName = pNameBox.Text;
            pColor = pColorBox.Text;
            pVolume = pVolumeBox.Text;
            pWeight = pWeightBox.Text;
            pAmount = pAmountBox.Text;
            return GenerateProductString(pNumber, pName, pColor, pVolume, pWeight, pAmount);
        }

        private string FormatProductNumberString(string pNumber, string pColli, string pColliMax)
        {
                        
            return $"{pNumber}-{pColli}-{pColliMax}";
        }

        private string GenerateProductString(string pNumber, string pName, string pColor, string pVolume, string pWeight, string pAmount)
        {
            return $"{pNumber} ! {pName} ! {pVolume} ! {pColor} ! {pWeight} ! {pAmount}";
        }

        private bool ValidateProductNumberInput()
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (regex.IsMatch(pNumberBox.Text) && regex.IsMatch(pColliBox.Text) && regex.IsMatch(pColliMaxBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateNumericInput()
        {
            List<TextBox> numericInputBoxes = GetNumericBoxes();
            bool canCovert;
            
            foreach (TextBox tb in numericInputBoxes)
            {
                canCovert = int.TryParse(tb.Text, out _);
                if (canCovert)
                {
                    continue;
                }
                else
                {
                    canCovert = decimal.TryParse(tb.Text, out _);
                    if(canCovert)
                    {
                        if(tb == pAmountBox)
                        {
                            return false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;

        }

        private List<TextBox> GetNumericBoxes()
        {
            List<TextBox> numericInputBoxes = new List<TextBox>();
            numericInputBoxes.Add(pWeightBox);
            numericInputBoxes.Add(pVolumeBox);
            numericInputBoxes.Add(pAmountBox);
            return numericInputBoxes;
        }
        private bool ValidateInput()
        {
            foreach (TextBox tb in textboxPanel.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    return false;
                }
            }
            if (ValidateProductNumberInput() && ValidateNumericInput())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ConfirmChoice();
            }
            
            else
            {
                MessageBox.Show("you done goofed (incorrect input)");
            }
        }

        private void ConfirmChoice()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this product?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string newProduct = GetInputs();
                MessageBox.Show(newProduct);
                string result = SendProductToServer(newProduct);
                MessageBox.Show(result);
                ClearInputs();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private string SendProductToServer(string product)
        {
            TCPClient client = new TCPClient();
            string serverOutput = client.Connect("add product ! " + product + $" ! {UserCredentials.WorkerId}");
            if (string.IsNullOrEmpty(serverOutput) || serverOutput.StartsWith("ERROR"))
                return "Error, could not add product. Reason, already Exists in the database.";
            return "New Product Added";
        }

    }
}
