using Client.Properties;
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
using Client.TCP;

namespace Client
{
    public delegate void EmployeeEditorEventHandler(ListItem employee);
    public partial class EmployeeEditer : Form
    {
        private string Method { get; }
        public event EmployeeEditorEventHandler EditorRequestAccepted;

        #region CustomProperties

        private int _id;
        private string _name;
        private string _password;
        private string _role;

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
            private set { _role = value;}
        }

        private Image profilePicture1;

        public Image GetProfilePicture()
        {
            return profilePicture1;
        }

        private void SetProfilePicture(Image value)
        {
            profilePicture1 = value;
        }

        #endregion

        public EmployeeEditer(string method)
        {
            InitializeComponent();
            Method = method;
        }

        public EmployeeEditer(ListItem item, string method)
        {
            InitializeComponent();

            //this is when you need to edit already existing employees
            ID = item.WorkerID;
            EmployeeName = item.EmployeeName;
            Method = method;
            SetRole(item.Role);
            SetProfilePicture(item.Picture);
        }

        private void SetRole(string role)
        {
            if (role == "FLOOR")
            {
                floorRButton.Checked = true;
            }
            else if(role == "OFFICE")
            {
                officeRButton.Checked = true;
            }
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

            if (errorMessage.Length == 0)
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

        private string GetRole()
        {
            if (floorRButton.Checked == true)
            {
                return "FLOOR";
            }
            else
            {
                return "OFFICE";
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
                    ListItem employee = CreateEmployee();
                    AddUserToDB();
                    EditorRequestAccepted.Invoke(employee);
                    this.Close();
                }
            }
        }

        private void AddUserToDB()
        {
            string name = nameTextbox.Text;
            int id = int.Parse(workerIDTextbox.Text);
            string role = GetRole();
            string password = passwordTextbox.Text;
            TCPClient client = new TCPClient();
            string query = $"{Method} employee ! {name} ! {id} ! {role} ! {password} ! {UserCredentials.WorkerId}";
            string response = client.Connect(query);
            if (!response.StartsWith("ERROR"))
            {
                MessageBox.Show(response, "SUCCESS");
            }
            else
            {
                MessageBox.Show(response, "ERROR");
            }
        }

        private ListItem CreateEmployee()
        {
            ListItem employee = new ListItem(nameTextbox.Text, int.Parse(workerIDTextbox.Text), GetRole(), "NONE", Resources._912214);
            return employee;
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
