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

        private void OfficeHideFunc()
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
        private void CheckValidation()
        {
            CheckIfEmptyBox();
            ControlBoxInput();
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
        }

        private void ControlBoxInput()
        {
            if (Int32.TryParse(ProductNumBox.Text, out int _) || Int32.TryParse(amountBox.Text, out int _))
            {
                if (ProductNumBox.Text.Length != 5 || int.Parse(amountBox.Text) <= 0)
                {
                    MessageBox.Show("Product number has to be 5 numbers and amount cant be 0, at least 1 or delete the product if there is no more", "error");
                    ProductNumLabel.Text = ProductNumLabel.Text;
                }
                else
                {
                    AmountLabel.Text = amountBox.Text;
                    PrimaryColliLabel.Text = PrimaryColliBox.Text;
                    PrimaryLocationLabel.Text = PrimaryLocationBox.Text;
                    ProductNumLabel.Text = ProductNumBox.Text;
                }
            }
            else
            {
                MessageBox.Show("NaN", "Error");
                AmountLabel.Text = AmountLabel.Text;
            }

            if(ProductNameBox.Text.Length > 100 || ColorBox.Text.Length > 20)
            {
                MessageBox.Show("Name is to long", "Error");
                ProductNameLabel.Text = ProductNameLabel.Text;
            }
            else
            {
                ProductNameLabel.Text = ProductNameBox.Text;
                ColorLabel.Text = ColorBox.Text;
            }

            if (Double.TryParse(WeightBox.Text, out double _) && double.TryParse(VolumeBox.Text, out double _))
            {
                if(double.Parse(WeightBox.Text) < 0.0 || double.Parse(WeightBox.Text) > 500.0 ||
                   double.Parse(VolumeBox.Text) < 0.0 || double.Parse(VolumeBox.Text) > 5.0)
                {
                    MessageBox.Show("To big or To small a number", "Error");
                    WeightLabel.Text = WeightLabel.Text;
                    VolumeLabel.Text = VolumeLabel.Text;
                }
                else
                {
                    WeightLabel.Text = WeightBox.Text;
                    VolumeBox.Text = VolumeBox.Text;
                }

            }
            else
            {
                MessageBox.Show("NaN", "Error");
                WeightLabel.Text = WeightLabel.Text;
                VolumeLabel.Text = VolumeLabel.Text;
            }
            
        
            
            
        }
        private void Clearfunc()
        {
            ProductNumBox.Text = "";
            ProductNameBox.Text = "";
            VolumeBox.Text = "";
            WeightBox.Text = "";
            ColorBox.Text = "";
            amountBox.Text = "";
            PrimaryColliBox.Text = "";
            PrimaryLocationBox.Text = "";

        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            SaveButton.Hide();
            OfficeHideFunc();
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Show();
            EditButton.Hide();
            OfficeShowFunc();
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            EditButton.Show();
            SaveButton.Hide();
            OfficeHideFunc();
            CheckValidation();
            
        }
    }
}
