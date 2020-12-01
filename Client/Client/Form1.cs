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

namespace Client
{
    public partial class MyhomeForm : Form
    {

        public MyhomeForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void MyhomeForm_Load(object sender, EventArgs e)
        {

        }


        private void HighlightThisButton(Button button)
        {
            Color myHomeYellow = Color.FromArgb(255, 192, 0);
            button.BackColor = myHomeYellow;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.Black;
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.ForeColor = Color.Black;
            RemoveHighlightFromAllButtons(button);
        }
        private void RemoveHighlightFromAllButtons(Button inputButton)
        {
            foreach (Button button in navBarPanel.Controls.OfType<Button>())
            {
                if(button == inputButton || button == signOutButton)
                {
                    continue;
                }
                else
                {
                    button.BackColor = Color.FromArgb(51, 51, 51);
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.BorderColor = Color.Black;
                    button.FlatAppearance.MouseOverBackColor = default;
                    button.ForeColor = Color.White;
                    button.Tag = false;
                }
            }
        }

        



        private void navButton1_Click(object sender, EventArgs e)
        {
            HighlightThisButton(navButton1);
            contentPanel.Controls.Clear();
            SearchWindow searchWindow = new SearchWindow();
            contentPanel.Controls.Add(searchWindow);
            searchWindow.Dock = DockStyle.Fill;
        }

        private void navButton2_Click(object sender, EventArgs e)
        {
            HighlightThisButton(navButton2);
            contentPanel.Controls.Clear();
            AddProductWindow_vers1 addProductWindow = new AddProductWindow_vers1();
            contentPanel.Controls.Add(addProductWindow);
            addProductWindow.Dock = DockStyle.Fill;
        }

        private void navButton3_Click(object sender, EventArgs e)
        {
            HighlightThisButton(navButton3);
            contentPanel.Controls.Clear();
            AllProductsPage allProductsPage = new AllProductsPage();
            contentPanel.Controls.Add(allProductsPage);
            allProductsPage.Dock = DockStyle.Fill;
        }

        private void navButton4_Click(object sender, EventArgs e)
        {
            HighlightThisButton(navButton4);
            contentPanel.Controls.Clear();
            CreatePicklistWindow createPicklistWindow = new CreatePicklistWindow();
            contentPanel.Controls.Add(createPicklistWindow);
            createPicklistWindow.Dock = DockStyle.Fill;
        }

        private void navButton5_Click(object sender, EventArgs e)
        {
            HighlightThisButton(navButton5);
            contentPanel.Controls.Clear();
            EmployeesWindow employeesWindow = new EmployeesWindow();
            contentPanel.Controls.Add(employeesWindow);
            employeesWindow.Dock = DockStyle.Fill;
        }

        private void navButton6_Click(object sender, EventArgs e)
        {
            HighlightThisButton(navButton6);
            contentPanel.Controls.Clear();
            LogsPage logsPage = new LogsPage();
            contentPanel.Controls.Add(logsPage);
            logsPage.Dock = DockStyle.Fill;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Make us able to drag by holding titlebar
        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void titleBarPanel_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void signOutButton_Click(object sender, EventArgs e)
        {

        }


        /*



       private void NavButton7_Click(object sender, EventArgs e)
       {

          HideNotSelectedPage();
          HighlightSelectedButton(NavButton7);
          logOutPage2.Show();
          Timetitle.Show();
          TimeLabel.Show();
          TimeLabel.Text = DateTime.Now.ToLongTimeString();

       }





       */
    }
}
