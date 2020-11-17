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
            ClearInformation();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            ClearInformation();
            this.Hide();

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            PromptForUserCreation();
        }


        private void PromptForUserCreation()
        {
            if (IsAllFieldsFilled())
            {
                if (CheckPasswordValidity())
                {
                    




                }
            }
        }

        private bool IsAllFieldsFilled()
        {

            string errorPreset = "The following is missing: \n\n";
            string errorMessage = "";

            errorMessage += CheckTextBox(NameInput);
            errorMessage += CheckTextBox(EnterPassword);
            errorMessage += CheckTextBox(ConfirmPassword);
            errorMessage += CheckRadioButtons(FloorRButton, OfficeRButton);
            

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorPreset + errorMessage, "Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        private string CheckRadioButtons(RadioButton rb1, RadioButton rb2)
        {
            if(rb1.Checked == false && rb2.Checked == false)
            {
                return "Role";
            }
            else
            {
                return null;
            }
        }

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



        private bool CheckPasswordValidity()
        {
            if (EnterPassword.Text.Equals(ConfirmPassword.Text) && string.IsNullOrEmpty(EnterPassword.Text) == false)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Error");
                return false;
            }
        }


        private string GetRole()
        {
            if(FloorRButton.Checked == true)
            {
                return "FLOOR";
            }
            else if(OfficeRButton.Checked == true)
            {
                return "OFFICE";
            }
            else
            {
                return null;
            }
        }


        private void ClearInformation()
        {
            NameInput.Text = null;
            EnterPassword.Text = null;
            ConfirmPassword.Text = null;
            FloorRButton.Checked = false;
            OfficeRButton.Checked = false;
        }

    }
}
