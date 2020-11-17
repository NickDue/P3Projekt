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
    public partial class FloorSearchPage : UserControl
    {
        public FloorSearchPage()
        {
            InitializeComponent();
        }
        private void FloorHideFunc()
        {
            amountBox.Hide();
            PrimaryLocationBox.Hide();
            PrimaryColliBox.Hide();
        }
        private void FloorShowFunc()
        {
            amountBox.Show();
            PrimaryLocationBox.Show();
            PrimaryColliBox.Show();
        }

        //This is gonna HIDE the YES and NO button
        private void LastCHanceHide()
        {
            NOButton.Hide();
            YESButton.Hide();
            LastChanceLabel.Hide();
        }
        //This is gonna SHOW the YES and NO button
        private void LastChanceShow()
        {
            NOButton.Show();
            YESButton.Show();
            LastChanceLabel.Show();
        }
        //This is gonna HIDE the check button
        private void CheckHide()
        {
            Checkbutton.Hide();
            CheckLabel.Hide();
        }
        //This is gonna SHOW the check button 
        private void CheckShow()
        {
            CheckLabel.Show();
            Checkbutton.Show();
        }
        //This contaion 3 functions and is the final validation 
        private void FinalValidation()
        {
            CheckIfEmptyBox();
            HandlingBoxInput();
            Clearfunc();
        }
        private void CheckIfEmptyBox()
        {
            if (PrimaryColliBox.Text == "")
            {
                PrimaryColliBox.Text = PrimaryColliLabel.Text;
            }

            if (PrimaryLocationBox.Text == "")
            {
                PrimaryLocationBox.Text = PrimaryLocationLabel.Text;
            }

            if (amountBox.Text == "")
            {
                amountBox.Text = AmountLabel.Text;
            }

        }
        private void Clearfunc()
        {
            amountBox.Text = "";
            PrimaryColliBox.Text = "";
            PrimaryLocationBox.Text = "";

        }
        private void HandlingBoxInput()
        {
            //amount Validation
            try
            {
                if (Int32.Parse(amountBox.Text) <= 0 || amountBox.Text.Length > 4)
                {
                    MessageBox.Show("Amount should be more than 0 and less than 9999", "error");
                    amountBox.Text = AmountLabel.Text;
                }
                else
                {
                    AmountLabel.Text = amountBox.Text;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Amount has to be a number", "error");
                amountBox.Text = AmountLabel.Text;
            }
            // Primary colli validation
            string[] colli = { "1/1","1/2", "2/2", "1/3","2/3", "3/3", "1/4", "2/4", "3/4", "4/4",
                                "1/5", "2/5", "3/5", "4/5", "5/5", "1/6", "2/6", "3/6", "4/6", "5/6",
                                "6/6", "1/7","2/7", "3/7","4/7","5/7", "6/7", "7/7","1/8", "2/8", "3/8",
                                "4/8", "5/8", "6/8", "7/8", "8/8","1/9","2/9", "3/9", "4/9","5/9", "6/9",
                                "7/9", "8/9", "9/9"};
            foreach (string item in colli)
            {
                if (PrimaryColliBox.Text != item)
                {
                    PrimaryColliLabel.Text = PrimaryColliLabel.Text;
                }
                else
                {
                    PrimaryColliLabel.Text = PrimaryColliBox.Text;
                }
            }
            if (PrimaryColliBox.Text != PrimaryColliLabel.Text)
            {
                MessageBox.Show("Colli is not valid, make sure it looks like this '1/2'", "invalid type");
            }

            // Primary Location validation
            if (PrimaryLocationBox.Text.Trim().Length > 10)
            {
                MessageBox.Show("Location cannot be longer than 10 character. Max length of Location is ex. 'SP-22-D-04' WITHOUT SPACE");
                PrimaryLocationLabel.Text = PrimaryLocationLabel.Text;
            }
            else
            {
                PrimaryLocationLabel.Text = PrimaryLocationBox.Text;
            }
        }
        private void Controller()
        {
            int errors = 0;
            //amount Validation
            try
            {
                if (Int32.Parse(amountBox.Text) <= 0 || amountBox.Text.Length > 4)
                {
                    MessageBox.Show("Amount should be more than 0 and less than 9999", "error");
                    amountBox.Text = AmountLabel.Text;
                    errors++;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Amount has to be a number", "error");
                amountBox.Text = AmountLabel.Text;
            }
            // Primary colli validation
            string[] colli = { "1/1","1/2", "2/2", "1/3","2/3", "3/3", "1/4", "2/4", "3/4", "4/4",
                                "1/5", "2/5", "3/5", "4/5", "5/5", "1/6", "2/6", "3/6", "4/6", "5/6",
                                "6/6", "1/7","2/7", "3/7","4/7","5/7", "6/7", "7/7","1/8", "2/8", "3/8",
                                "4/8", "5/8", "6/8", "7/8", "8/8","1/9","2/9", "3/9", "4/9","5/9", "6/9",
                                "7/9", "8/9", "9/9"};
            int personal_colli_check = 0;
            foreach (string item in colli)
            {
                if (PrimaryColliBox.Text != item)
                {
                    PrimaryColliLabel.Text = PrimaryColliLabel.Text;

                }
                else
                {
                    personal_colli_check++;
                }


            }
            if (personal_colli_check == 0)
            {
                MessageBox.Show("Colli is not valid, make sure it looks like this '1/2'", "invalid type");
                errors++;

            }

            // Primary Location validation
            if (PrimaryLocationBox.Text.Trim().Length > 10)
            {
                MessageBox.Show("Location cannot be longer than 10 character. Max length of Location is ex. 'SP-22-D-04' WITHOUT SPACE");
                PrimaryLocationLabel.Text = PrimaryLocationLabel.Text;
                errors++;
            }

            //If no errors, SUCCESS
            if (errors == 0)
            {
                MessageBox.Show("SUCCESS", "OK");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Hide();
            FloorHideFunc();
            LastChanceShow();
            CheckHide();
            Backbutton.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Backbutton.Show();
            SaveButton.Show();
            CheckShow();
            EditButton.Hide();
            SearchButton.Hide();
            SearchInput.Hide();
            FloorShowFunc();
        }

        private void FloorSearchPage_Load(object sender, EventArgs e)
        {
            Backbutton.Hide();
            SaveButton.Hide();
            FloorHideFunc();
            LastCHanceHide();
            CheckHide();
        }

        private void Checkbutton_Click(object sender, EventArgs e)
        {
            CheckIfEmptyBox();
            Controller();
            
        }

        private void NOButton_Click(object sender, EventArgs e)
        {
            LastCHanceHide();
            Backbutton.Show();
            SaveButton.Show();
            FloorShowFunc();
            CheckShow();
        }

        private void YESButton_Click(object sender, EventArgs e)
        {
            LastCHanceHide();

            EditButton.Show();
            SearchInput.Show();
            SearchButton.Show();

            FinalValidation();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Backbutton.Hide();
            Clearfunc();
            SaveButton.Hide();
            CheckHide();
            EditButton.Show();
            SearchInput.Show();
            SearchButton.Show();
            FloorHideFunc();
        }
    }
}
