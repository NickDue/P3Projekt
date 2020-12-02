using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class EmployeeEditer : Form
    {
        #region CustomProperties

        private int _id;
        private string _name;
        private string _password;
        private string _role;
        private Image _profilePicture;

        public int ID
        {
            get { return _id; }
            private set { _id = value; workerIDTextbox.Text = value.ToString(); }
        }
        public string EmployeeName
        {
            get { return _name; }
            private set { _name = value; nameTextbox.Text = value; }
        }
        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }
        public string Role
        {
            get { return  _role; }
            private set { _role = value; }
        }
        public Image ProfilePicture
        {
            get { return _profilePicture; }
            private set { _profilePicture = value; }
        }


        #endregion

        public EmployeeEditer()
        {
            InitializeComponent();
        }

        public EmployeeEditer(ListItem item)
        {
            //this is when you need to edit already existing employees
            ID = item.WorkerID;
            EmployeeName = item.Name;
            Role = item.Role;
            ProfilePicture = item.Picture;
        }

        private void EmployeeEditer_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 650);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private bool AreAllFieldsFilled()
        {
            string errorPreset = "The following is missing: \n\n";
            string errorMessage = string.Empty;

            errorMessage += IsTextboxFilled(nameTextbox);
            errorMessage += IsTextboxFilled(passwordTextbox);
            if(passwordTextbox.TextLength < 0)
            {
                errorMessage += IsTextboxFilled(confirmPasswordTextbox);
            }
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
                return tb.Tag + "\n";
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Make us able to drag by holding titlebar
        private void titlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public string GenerateEmployeeString()
        {
            return $"{ID} ! {EmployeeName} ! {Role} ! {Password}";
        }
    }
}
