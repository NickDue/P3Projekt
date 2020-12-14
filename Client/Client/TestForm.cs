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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            if(UserCredentials.WorkerRole == "floor")
            {
                testpage_floor1.Show();
                testpage_office1.Hide();
                button2.Hide();
            }
            else
            {
                testpage_office1.Show();
                testpage_floor1.Hide();
                button2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.Show();
        }
    }
}
