using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class EmployeeEditer : Form
    {
        public EmployeeEditer()
        {
            InitializeComponent();
        }



        private void EmployeeEditer_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        public EmployeeEditer(int ID, string name, string role, Image profilePicture)
        {
            //this is when you need to edit already existing employees

        }

        private bool AreAllFieldsFilled()
        {
            string errorPreset = "The following is missing: \n\n";
            string errorMessage = string.Empty;

            errorMessage += IsTextboxFilled(nameTextbox);
            errorMessage += IsTextboxFilled(passwordTextbox);
            errorMessage += IsTextboxFilled(confirmPasswordTextbox);
            errorMessage += IsEitherRadioButtonChecked(floorRButton, officeRButton);

            if (errorMessage.Length < 0)
            {
                return true;

            }
            else
            {
                MessageBox.Show(errorPreset + errorMessage, "Error");
                return false;
            }
        }
        
        private string IsTextboxFilled(TextBox tb)
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

        private string IsEitherRadioButtonChecked(RadioButton rb1, RadioButton rb2)
        {
            if (rb1.Checked == false && rb2.Checked == false)
            {
                return "Role";
            }
            else
            {
                return null;
            }
        }

        private bool DoesPasswordsMatch(TextBox password, TextBox confirmPassword)
        {
            if (password.Text.Equals(confirmPassword.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Error");
                return false;
            }
        }

        private void Clear()
        {
            foreach(TextBox tb in contentPanel.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            PromptForUserCreation();
        }

        private void PromptForUserCreation()
        {
            if (AreAllFieldsFilled())
            {
                if (DoesPasswordsMatch(passwordTextbox, confirmPasswordTextbox))
                {

                }
            }
        }
    }
}
