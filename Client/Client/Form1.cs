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
    public partial class MyhomeForm : Form
    {
        public MyhomeForm()
        {
            InitializeComponent();
        }

        private void MyhomeForm_Load(object sender, EventArgs e)
        {
            HideNotSelectedPage();

            if (User.Role.ToUpper() == "FLOOR1")
            {
                NavButton2.Hide();
                NavButton3.Hide();
                NavButton4.Hide();
                NavButton5.Hide();
                NavButton6.Hide();

            }
        }

        private void HighlightSelectedButton(Button button) 
        {
            RemoveHighlightButton();
            button.BackColor = Color.LightGray;
            button.ForeColor = Color.Black;
            
        }
        private void RemoveHighlightButton()
        {
            NavButton1.BackColor = Color.White;
            NavButton1.ForeColor = Color.Black;
            NavButton2.BackColor = Color.White;
            NavButton2.ForeColor = Color.Black;
            NavButton3.BackColor = Color.White;
            NavButton3.ForeColor = Color.Black;
            NavButton4.BackColor = Color.White;
            NavButton4.ForeColor = Color.Black;
            NavButton5.BackColor = Color.White;
            NavButton5.ForeColor = Color.Black;
            NavButton6.BackColor = Color.White;
            NavButton6.ForeColor = Color.Black;
            NavButton7.BackColor = Color.White;
            NavButton7.ForeColor = Color.Black;
        }


        private void NavButton1_Click(object sender, EventArgs e)
        {
            HideNotSelectedPage();
            if(User.Role.ToUpper() == "FLOOR")
            {
                floorSearchPage1.Show();
            }
            else
            {
                searchWindow1.Show();
            }
            
            HighlightSelectedButton(NavButton1);
        }

        private void NavButton2_Click(object sender, EventArgs e)
        {
            HideNotSelectedPage();
            addProductWindow1.Show();
            HighlightSelectedButton(NavButton2);

        }
        private void NavButton3_Click(object sender, EventArgs e)
        {
            HideNotSelectedPage();
            allProductsPage1.Show();
            HighlightSelectedButton(NavButton3);
        }
        private void NavButton4_Click(object sender, EventArgs e)
        {
            HideNotSelectedPage();
            createPicklistWindow1.Show();
            HighlightSelectedButton(NavButton4);
        }
        private void NavButton5_Click(object sender, EventArgs e)
        {
            HideNotSelectedPage();
            employeesWindow1.Show();
            HighlightSelectedButton(NavButton5);

        }
        private void NavButton6_Click(object sender, EventArgs e)
        {
            HideNotSelectedPage();
            logsPage1.Show();
            HighlightSelectedButton(NavButton6);
        }
        private void NavButton7_Click(object sender, EventArgs e)
        {

            HideNotSelectedPage();
            HighlightSelectedButton(NavButton7);
            logOutPage2.Show();
            Timetitle.Show();
            TimeLabel.Show();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();

        }
        private void Navigationbar_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void HideNotSelectedPage()
        {
            floorSearchPage1.Hide();
            searchWindow1.Hide();
            allProductsPage1.Hide();
            logsPage1.Hide();
            employeesWindow1.Hide();
            addProductWindow1.Hide();
            createPicklistWindow1.Hide();
            logOutPage2.Hide();
            TimeLabel.Hide();
            Timetitle.Hide();
        }




        private void MyhomeLabel_Click(object sender, EventArgs e)
        {

        }
        private void LandingPage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
