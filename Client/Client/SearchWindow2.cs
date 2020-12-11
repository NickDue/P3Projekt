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
using System.Collections;

namespace Client
{
    public partial class SearchWindow2 : UserControl
    {
        private List<string> EditedValues = new List<string>();

        public SearchWindow2()
        {
            InitializeComponent();
            //AddSampleProduct();
            //AddLocationsToDataGrid(ProductGridView, "HAL0 - HYLDE 33");
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelEdit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private bool editMode = false;

        private void EditButton_Click(object sender, EventArgs e)
        {
            ToggleTextBoxEditMode(ProductPanel, LocationProductPanel);

            if (!editMode)
            {
                ConfirmChoiceUser();
            }
        }

        // Prompts the user for confirmation before editing product
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

        // Toggles Editmode for TextBoxes
        private void ToggleTextBoxEditMode(Control control1, Control control2)
        {
            ToggleEditMode();
            if (editMode)
            {
                ToggleTextBoxReadOnly(control1, false);
                ToggleTextBoxReadOnly(control2, false);
                EditButton.Text = "Save";
                EditButton.BackColor = Color.Red;
            }

            else
            {
                ToggleTextBoxReadOnly(control1, true);
                ToggleTextBoxReadOnly(control2, true);
                EditButton.Text = "Edit";
                EditButton.BackColor = Color.Green;
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

        // Cancels Edit Mode and clears textboxes
        private void CancelEdit()
        {
            if (editMode)
            {
                ToggleTextBoxEditMode(ProductPanel, LocationProductPanel);
                ClearTextBoxInput(ProductPanel, LocationProductPanel);
            }

            else
            {
                ClearTextBoxInput(ProductPanel, LocationProductPanel);
            }
        }

        // Clears the current text in TextBoxes
        private void ClearTextBoxInput(Control control1, Control control2)
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
                    if (canCovert && !tb.Text.Contains(","))
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
                ProductGridView.Rows.Clear();
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
                GetRelatedProducts(splittedInput[0],splittedInput[1],splittedInput[2]);
            }
            else
            {
                MessageBox.Show("Product Not Found", "error");
            }
        }

        private void GetRelatedProducts(string product_id, string colli, string total)
        {
            string query = $"related ! {product_id}";
            TCPClient client = new TCPClient();
            string info = client.Connect(query);
            string[] splittedProducts = info.Split('\n');
            for (int i = 0; i < splittedProducts.Length-1; i++)
            {
                if (!string.IsNullOrEmpty(splittedProducts[i]))
                {
                    string[] splittedId = splittedProducts[i].Split('!');
                    if (splittedId[1] != colli && splittedId[2] != total)
                    {
                        string product = $"{splittedId[1]}/{splittedId[2]} - Id: {splittedId[0]} - Location: {splittedId[3]}";
                        AddLocationsToDataGrid(ProductGridView, product);
                    } 
                }
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

        private void DeleteProduct()
        {
            string[] splittedInput = SearchInputBox.Text.Split('-');
            if (splittedInput.Length != 3)
                return;
            string input = $"delete product ! {splittedInput[0]} ! {splittedInput[1]} ! {splittedInput[2]} ! {UserCredentials.WorkerId}";
            TCPClient client = new TCPClient();
            string info = client.Connect(input);
            MessageBox.Show(info);
            ClearTextBoxInput(ProductPanel, LocationProductPanel);
            SearchInputBox.Text = String.Empty;
        }

        private void AddLocationsToDataGrid(DataGridView Grid, string location)
        {
            ArrayList row = new ArrayList();

            row.Add(location);

            Grid.Rows.Add(row.ToArray());
        }
    }
}
