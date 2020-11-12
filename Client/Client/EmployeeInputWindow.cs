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
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            ClearInformation();
            this.Hide();

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SetInformation();

        }



        private void SetInformation()
        {
            if (CheckPasswordValidity() == true)
            {
                NameInputString = NameInput.Text;
                PasswordInputString = EnterPassword.Text;

                if (GetRole() == null)
                {
                    MessageBox.Show("Please select a role");
                }
                else
                {
                    RoleInputString = GetRole();
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match","");
            }
        }

        private bool CheckPasswordValidity()
        {
            if (EnterPassword.Text.Equals(ConfirmPassword.Text) && string.IsNullOrEmpty(EnterPassword.Text) == false && string.IsNullOrEmpty(ConfirmPassword.Text) == false)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Passwords do not match","Error");
                return false;
            }
        }

        private string GetRole()
        {
            if(FloorRButton.Checked == true)
            {
                return "FLOOR";
            }
            else if(OfficeRButton.Checked = true)
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
            NameInput.Text = "";
            EnterPassword.Text = "";
            ConfirmPassword.Text = "";
            FloorRButton.Checked = false;
            OfficeRButton.Checked = false;
        }




        #region INPUT



        private string _name;
        private string _password;
        private string _role;



        public string NameInputString
        {
            get { return _name; }
            set { _name = value; }
        }


        public string PasswordInputString
        {
            get { return _password; }
            set { _password = value; }
        }


        public string RoleInputString
        {
            get { return _role; }
            set { _role = value; }
        }



        #endregion

    }
}
