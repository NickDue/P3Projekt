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
        public SearchWindow2()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchInputBox.Text))
                return;
            //GetProductFromServer();
        }

        private bool editMode = false;

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                if (ValidateInput(ProductPanel) && ValidateInput(LocationProductPanel))
                {

                }
            }

            ToggleTextBoxEditMode(ProductPanel, LocationProductPanel);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxInput(LocationProductPanel, ProductPanel);
        }

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

        private void ToggleTextBoxReadOnly(Control control, bool b)
        {
            foreach (TextBox tb in control.Controls.OfType<TextBox>())
            {
                tb.ReadOnly = b;
            }
        }

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

        private List<TextBox> GetNumericBoxes()
        {
            List<TextBox> numericInputBoxes = new List<TextBox>();
            numericInputBoxes.Add(WeightBox);
            numericInputBoxes.Add(VolumeBox);
            numericInputBoxes.Add(AmountBox);
            return numericInputBoxes;
        }

        //private void GetProductFromServer()
        //{
        //    string[] splittedInput = SearchInputBox.Text.Split('-');
        //    if (splittedInput.Length != 3)
        //        return;
        //    string input = $"find product ! {splittedInput[0]} ! {splittedInput[1]} ! {splittedInput[2]}";
        //    //string input = "find product ! 21188 ! 01 ! 03";
        //    TCPClient client = new TCPClient();
        //    string info = client.Connect(input);
        //    if (!info.StartsWith("ERROR"))
        //    {
        //        string[] splittedOutput = info.Split('!');
        //        string[] splittedId = splittedOutput[0].Split('-');
        //        ProductNumLabel.Text = splittedId[0];
        //        ProductNameLabel.Text = splittedOutput[1];
        //        VolumeLabel.Text = splittedOutput[2];
        //        WeightLabel.Text = splittedOutput[3];
        //        ColorLabel.Text = splittedOutput[4];
        //        PrimaryLocationLabel.Text = splittedOutput[6];
        //        AmountLabel.Text = splittedOutput[7];
        //        PrimaryColliLabel.Text = Int32.Parse(splittedId[1]) + "/" + Int32.Parse(splittedId[2]);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Product Not Found", "error");
        //    }

        //}
    }
}
