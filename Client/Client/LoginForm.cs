using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Client.TCP;

namespace Client
{
    public partial class LoginForm : Form
    {
        string username_floor = "floor";
        string password_floor = "floor";
        string username_office = "office";
        string password_office = "office";
        private const bool DBActive = true;
        private const bool Test = true;
        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ControlBox = false;
            this.Text = String.Empty;
            KeyPreview = true;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginFunction();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void LoginFunction()
        {
            if(UsernameBox.Text == username_floor && PasswordBox.Text == password_floor)
            {
                TestForm tform = new TestForm();
                UserCredentials.WorkerRole = username_floor;
                Hide();
                tform.Show();
            }else if(UsernameBox.Text == username_office && PasswordBox.Text == password_office)
            {
                TestForm tform = new TestForm();
                UserCredentials.WorkerRole = username_office;
                Hide();
                tform.Show();
            }
            else
            { 
                if (DBActive)
                {
                    string query = $"authenticate ! {UsernameBox.Text} ! {PasswordBox.Text}";
                    TCPClient client = new TCPClient();
                    string resonse = client.Connect(query);
                        if (!resonse.StartsWith("ERROR"))
                        {
                            string[] splittedResponse = resonse.Split('!');
                            UserCredentials.WorkerId = Int32.Parse(splittedResponse[0]);
                            UserCredentials.WorkerUsername = splittedResponse[1];
                        if (!Test)
                        {
                             UserCredentials.WorkerRole = splittedResponse[3];
                        }   
                            MyhomeForm form = new MyhomeForm();
                            Hide();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unknown User", "Error");
                        }
                }
            }          
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginFunction();
            }
        }
    }
}
