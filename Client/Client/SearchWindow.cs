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
    public partial class SearchWindow : UserControl
    {
        public SearchWindow()
        {
            InitializeComponent();
            
        }

        private void HideFunc()
        {
            ProductNumBox.Hide();
            ProductNameBox.Hide();
            VolumeBox.Hide();
            ColorBox.Hide();
            WeightBox.Hide();
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

        private void OfficeShowFunc()
        {
            ProductNumBox.Show();
            ProductNameBox.Show();
            VolumeBox.Show();
            ColorBox.Show();
            WeightBox.Show();
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
            
            if (ProductNumBox.Text == "") 
            { 
                ProductNumBox.Text = ProductNumLabel.Text; 
            }
            
            if (ProductNameBox.Text == "") 
            { 
                ProductNameBox.Text = ProductNameLabel.Text; 
            }
            
            if (VolumeBox.Text == "") 
            { 
                VolumeBox.Text = VolumeLabel.Text; 
            }
            
            if (ColorBox.Text == "") 
            { 
                ColorBox.Text = ColorLabel.Text; 
            }
            
            if (WeightBox.Text == "") 
            { 
                WeightBox.Text = WeightLabel.Text; 
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
                ProductNumLabel.Text = ProductNumBox.Text;
                ProductNameLabel.Text = ProductNameBox.Text;
                VolumeLabel.Text = VolumeBox.Text;
                ColorLabel.Text = ColorBox.Text;
                WeightLabel.Text = WeightBox.Text;
            }
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            SaveButton.Hide();
            HideFunc();
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Show();
            EditButton.Hide();

            if (User.Role.ToUpper() == "FLOOR")
            {
                FloorShowFunc();
            }
            else
            {
                OfficeShowFunc();
            }    
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            EditButton.Show();
            SaveButton.Hide();
            HideFunc();
            CheckIfEmptyBox();
            
        }
    }
}
