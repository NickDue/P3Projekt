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

            ControlBoxInput();

            amountBox.Text = "";

        }
        private void ControlBoxInput()
        {
            if (int.Parse(amountBox.Text) < int.Parse(AmountLabel.Text))
            {
                MessageBox.Show("Input must be higher", "Error");
                AmountLabel.Text = AmountLabel.Text;

            }
            else
            {
                AmountLabel.Text = amountBox.Text;
                PrimaryColliLabel.Text = PrimaryColliBox.Text;
                PrimaryLocationLabel.Text = PrimaryLocationBox.Text;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            EditButton.Show();
            SaveButton.Hide();
            FloorHideFunc();
            CheckIfEmptyBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Show();
            EditButton.Hide();
        }
    }
}
