using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Client.TCP;

namespace Client
{
    public partial class SearchWindow2 : UserControl
    {
        private List<string> EditedValues = new List<string>();

        public SearchWindow2()
        {
            InitializeComponent();
            AddSampleProduct();
        }

        private void AddSampleProduct()
        {
            Product p = new Product();

            p.ProductID = 12345;
            p.ProductName = "Cool Chair";
            p.Volume = 11.2;
            p.Color = "Navy";
            p.Weight = 10.5;
            p.Amount = 5;
            p.Location = "HAL1";

            ProductNumberBox.Text = p.ProductID.ToString();
            ProductNameBox.Text = p.ProductName;
            VolumeBox.Text = p.Volume.ToString();
            ColorBox.Text = p.Color;
            WeightBox.Text = p.Weight.ToString();
            AmountBox.Text = p.Amount.ToString();
            LocationBox.Text = p.Location;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchInputBox.Text))
            {
                MessageBox.Show("Invalid input: Please enter product number ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GetProductFromServer();
            }
        }

        private bool editMode = false;

        private void EditButton_Click(object sender, EventArgs e)
        {
            ToggleTextBoxEditMode(ProductPanel, LocationProductPanel);

            if (editMode)
            {
                // do nothing
            }

            else
            {
                ConfirmChoiceUser();
            }
        }

        private void AddAllInformation()
        {
            EditedValues.Add($"colli_id = {ProductNumberBox.Text}");
            EditedValues.Add($"amount = {AmountBox.Text}");
            EditedValues.Add($"weight = {WeightBox.Text}");
            EditedValues.Add($"volume = {VolumeBox.Text}");
            EditedValues.Add($"name = {ProductNameBox.Text}");
            EditedValues.Add($"color = {ColorBox.Text}");
            string[] colliSplitted = LocationColliBox.Text.Split('/');
            EditedValues.Add($"colli_number = {colliSplitted[0]}");
            EditedValues.Add($"colli_total = {colliSplitted[1]}");
            EditedValues.Add($"placement = {LocationBox.Text}");
        }

        private void ConfirmChoiceUser()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit this product?", "Confirm", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                if (ValidateInput(ProductPanel))
                {
                    AddAllInformation();
                    SendToServer();
                    GetProductFromServer();
                }

                else
                {
                    MessageBox.Show("Failed to edit product");
                    ToggleTextBoxEditMode(ProductPanel, LocationProductPanel);
                }

            }

            else if (dialogResult == DialogResult.No)
            {
                ToggleTextBoxEditMode(ProductPanel, LocationProductPanel);
            }
        }



        // Toggles Editmode for TextBoxes
        private void ToggleTextBoxEditMode(Control control1, Control control2)
        {
            ToggleEditMode();
            if (editMode)
            {
                ToggleTextBoxReadOnly(control1, false);
                ToggleTextBoxReadOnly(control2, false);
                EditButton.Text = "Save";
            }

            else
            {
                ToggleTextBoxReadOnly(control1, true);
                ToggleTextBoxReadOnly(control2, true);
                EditButton.Text = "Edit";
            }
        }

        // Toggles ReadOnly in TextBoxes
        private void ToggleTextBoxReadOnly(Control control, bool b)
        {
            foreach (TextBox tb in control.Controls.OfType<TextBox>())
            {
                tb.ReadOnly = b;
            }
        }

        // Toggles the bool editMode
        private void ToggleEditMode()
        {
            if (editMode)
            {
                editMode = false;
            }

            else
            {
                editMode = true;
            }
        }

        // Clears the current text in TextBoxes
        private void ClearTextBoxInput(Control control1, Control control2)
        {
            if (editMode)
            {
                foreach (TextBox tb in control1.Controls.OfType<TextBox>())
                {
                    tb.Text = string.Empty;
                }
                foreach (TextBox tb in control2.Controls.OfType<TextBox>())
                {
                    tb.Text = string.Empty;
                }
            }
        }

        // Checks for null or empty input and returns a bool
        private bool ValidateInput(Control control)
        {
            foreach (TextBox tb in control.Controls.OfType<TextBox>())
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

        // Validates input for product number using regular expression and returning a bool
        private bool ValidateProductNumberInput()
        {
            Regex regex = new Regex(@"^[0-9]+$");

            if (regex.IsMatch(ProductNumberBox.Text))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Validates numeric input for textboxes by returning a bool
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
                    if (canCovert)
                    {
                        if (tb == AmountBox)
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

        // Gets and returns a list of TextBoxes with numeric input
        private List<TextBox> GetNumericBoxes()
        {
            List<TextBox> numericInputBoxes = new List<TextBox>();

            numericInputBoxes.Add(WeightBox);
            numericInputBoxes.Add(VolumeBox);
            numericInputBoxes.Add(AmountBox);

            return numericInputBoxes;
        }

        private void GetProductFromServer()
        {
            string[] splittedInput = SearchInputBox.Text.Split('-');
            if (splittedInput.Length != 3)
                return;
            string input = $"find product ! {splittedInput[0]} ! {splittedInput[1]} ! {splittedInput[2]} ! {UserCredentials.WorkerId}";
            //string input = "find product ! 21188 ! 01 ! 03";
            TCPClient client = new TCPClient();
            string info = client.Connect(input);
            if (!info.StartsWith("ERROR"))
            {
                string[] splittedOutput = info.Split('!');
                string[] splittedId = splittedOutput[0].Split('-');
                ProductNumberBox.Text = splittedId[0];
                ProductNameBox.Text = splittedOutput[1];
                VolumeBox.Text = splittedOutput[2];
                WeightBox.Text = splittedOutput[3];
                ColorBox.Text = splittedOutput[4];
                LocationBox.Text = splittedOutput[6];
                AmountBox.Text = splittedOutput[7];
                LocationColliBox.Text = Int32.Parse(splittedId[1]) + "/" + Int32.Parse(splittedId[2]);
            }
            else
            {
                MessageBox.Show("Product Not Found", "error");
            }
        }


        private void SendToServer()
        {
            string toSend = "edit product\n";
            EditedValues.Add(UserCredentials.WorkerId.ToString());
            foreach (string str in EditedValues)
            {
                toSend += str + "\n";
            }
            EditedValues.Clear();
            //MessageBox.Show(toSend);
            TCPClient client = new TCPClient();
            string response = client.Connect(toSend);
            if (!response.StartsWith("ERROR"))
            {
                MessageBox.Show("Edited product.");
            }
            else
            {
                MessageBox.Show("Failure");
            }
        }
    }
}
