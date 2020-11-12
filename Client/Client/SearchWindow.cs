using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Instrumentation;


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
                ColorLabel.Text = ColorBox.Text.ToUpper();
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

            string[] colli = { "1/1","1/2", "2/2", "1/3","2/3", "3/3", "1/4", "2/4", "3/4", "4/4",
                                "1/5", "2/5", "3/5", "4/5", "5/5", "1/6", "2/6", "3/6", "4/6", "5/6",
                                "6/6", "1/7","2/7", "3/7","4/7","5/7", "6/7", "7/7","1/8", "2/8", "3/8",
                                "4/8", "5/8", "6/8", "7/8", "8/8","1/9","2/9", "3/9", "4/9","5/9", "6/9",
                                "7/9", "8/9", "9/9"};
            foreach(string item in colli)
            {
                if(PrimaryColliBox.Text != item)
                {
                    PrimaryColliLabel.Text = PrimaryColliLabel.Text;
                }
                else
                {
                    PrimaryColliLabel.Text = PrimaryColliBox.Text;
                }
            }
            if(PrimaryColliBox.Text != PrimaryColliLabel.Text)
            {
                MessageBox.Show("Colli is not valid, make sure it looks like this '1/2'", "invalid type");
            }

           if(PrimaryLocationBox.Text.Trim().Length > 10)
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
            if (Int32.TryParse(ProductNumBox.Text, out int _) || Int32.TryParse(amountBox.Text, out int _))
            {
                if (ProductNumBox.Text.Length != 5 || int.Parse(amountBox.Text) <= 0)
                {
                    MessageBox.Show("Product number has to be 5 numbers and amount cant be 0, at least 1 or delete the product if there is no more", "error");
                    ProductNumLabel.Text = ProductNumLabel.Text;
                }
              
            }
            else
            {
                MessageBox.Show("NaN", "Error");
                AmountLabel.Text = AmountLabel.Text;
            }

            if (ProductNameBox.Text.Length > 100 || ColorBox.Text.Length > 20)
            {
                MessageBox.Show("Name is to long", "Error");
                ProductNameLabel.Text = ProductNameLabel.Text;
            }
         
            if (Double.TryParse(WeightBox.Text, out double _) && double.TryParse(VolumeBox.Text, out double _))
            {
                if (double.Parse(WeightBox.Text) < 0.0 || double.Parse(WeightBox.Text) > 500.0 ||
                   double.Parse(VolumeBox.Text) < 0.0 || double.Parse(VolumeBox.Text) > 5.0)
                {
                    MessageBox.Show("To big or To small a number", "Error");
                    WeightLabel.Text = WeightLabel.Text;
                    VolumeLabel.Text = VolumeLabel.Text;
                }
               

            }
            else
            {
                MessageBox.Show("NaN", "Error");
                WeightLabel.Text = WeightLabel.Text;
                VolumeLabel.Text = VolumeLabel.Text;
            }

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
                
            }
            if (PrimaryColliBox.Text != PrimaryColliLabel.Text)
            {
                MessageBox.Show("Colli is not valid, make sure it looks like this '1/2'", "invalid type");
            }

            if (PrimaryLocationBox.Text.Trim().Length > 10)
            {
                MessageBox.Show("Location cannot be longer than 10 character. Max length of Location is ex. 'SP-22-D-04' WITHOUT SPACE");
                PrimaryLocationLabel.Text = PrimaryLocationLabel.Text;
            }
            
        }
       
        private void LastChance()
        {
            TitleLabel.Hide();
            SearchInputField.Hide();
            SearchButton.Hide();
            YESbutton.Show();
            NObutton.Show();
            LastChanceLabel.Show();
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
            backbutton.Hide();
            SaveButton.Hide();
            OfficeHideFunc();
            LastChanceLabel.Hide();
            YESbutton.Hide();
            NObutton.Hide();

            Checkbutton.Hide();
            CheckLabel.Hide();
            
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            backbutton.Show();
            SaveButton.Show();
            TitleLabel.Hide();
            SearchInputField.Hide();
            SearchButton.Hide();
            EditButton.Hide();
            OfficeShowFunc();

            CheckLabel.Show();
            Checkbutton.Show();
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {      
            backbutton.Hide();
            SaveButton.Hide();
            OfficeHideFunc();
            LastChance();
            Checkbutton.Hide();
            CheckLabel.Hide();

        }

        private void NObutton_Click(object sender, EventArgs e)
        {
            backbutton.Show();
            SaveButton.Show();
            EditButton.Hide();
            OfficeShowFunc();
            LastChanceLabel.Hide();
            YESbutton.Hide();
            NObutton.Hide();

            CheckLabel.Show();
            Checkbutton.Show();
        }

        private void YESbutton_Click(object sender, EventArgs e)
        {
            CheckValidation();
            EditButton.Show();
            TitleLabel.Show();
            SearchInputField.Show();
            SearchButton.Show();
            LastChanceLabel.Hide();
            YESbutton.Hide();
            NObutton.Hide();
            Checkbutton.Hide();
            CheckLabel.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            OfficeHideFunc();
            backbutton.Hide();
            EditButton.Show();
            TitleLabel.Show();
            SearchInputField.Show();
            SearchButton.Show();
            LastChanceLabel.Hide();
            YESbutton.Hide();
            NObutton.Hide();
            SaveButton.Hide();
            Checkbutton.Hide();
            CheckLabel.Hide();
        }

        private void Checkbutton_Click(object sender, EventArgs e)
        {
            CheckIfEmptyBox();
            Controller();
            
        }
    }
}
