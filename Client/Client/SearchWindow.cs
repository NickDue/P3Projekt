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
                                                                    //This is gonna HIDE the type boxes
        private void OfficeHideFuncBox()
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
                                                                    //This is gonna SHOW the type boxes
        private void OfficeShowFuncBox()
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
                                                                    //This checks if the type boxes are empty, if yes than keep the current value
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
                                                                    //This clear type boxes input to empty string
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
                                                                    //This check AND change the value if the value is valid
        private void HandlingBoxInput()
        {
            // Product number and amount validation
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

            // Product name and color validation
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
            // Weight and volume validation
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
                                                                    //This ONLY check the value, if no errors = success
        private void Controller()
        {
            int errors = 0;  // Count errors happen

            // Product number and amount validation
            if (Int32.TryParse(ProductNumBox.Text, out int _) || Int32.TryParse(amountBox.Text, out int _))
            {
                if (ProductNumBox.Text.Length != 5 || int.Parse(amountBox.Text) <= 0 || amountBox.Text.Length > 4)
                {
                    MessageBox.Show("Product number has to be 5 numbers.                                                       " + 
                    "Amount cant be 0, at least 1 or delete the product if there is no more", "error... Product number or Amount number does not fit");
                    ProductNumLabel.Text = ProductNumLabel.Text;
                    errors++;
                }

            }
            else
            {
                MessageBox.Show("NaN", "Error");
                AmountLabel.Text = AmountLabel.Text;
                errors++;
            }

            // Product name and color validation
            if (ProductNameBox.Text.Length > 100 || ColorBox.Text.Length > 20)
            {
                MessageBox.Show("Name is to long", "Error");
                ProductNameLabel.Text = ProductNameLabel.Text;
                errors++;
            }

            // Weight and volume validation
            if (Double.TryParse(WeightBox.Text, out double _) && double.TryParse(VolumeBox.Text, out double _))
            {
                if (double.Parse(WeightBox.Text) < 0.0 || double.Parse(WeightBox.Text) > 500.0 ||
                   double.Parse(VolumeBox.Text) < 0.0 || double.Parse(VolumeBox.Text) > 5.0)
                {
                    MessageBox.Show("To big or To small a number", "Error");
                    WeightLabel.Text = WeightLabel.Text;
                    VolumeLabel.Text = VolumeLabel.Text;
                    errors++;
                }


            }
            else
            {
                MessageBox.Show("NaN", "Error");
                WeightLabel.Text = WeightLabel.Text;
                VolumeLabel.Text = VolumeLabel.Text;
                errors++;
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
                                                                    //enter search-mode
        private void SearchWindow_Load(object sender, EventArgs e)
        {
            SaveButton.Hide();
            OfficeHideFuncBox();
            CheckHide();
            LastCHanceHide();
            
        }
                                                                    //Enter edit-mode
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditButton.Hide();
            SearchButton.Hide();
            SearchInput.Hide();

            SaveButton.Show();
            CheckShow();
            OfficeShowFuncBox();
        }
                                                                    // Goes to last change validation
        public void SaveButton_Click(object sender, EventArgs e)
        {
            
            SaveButton.Hide();
            OfficeHideFuncBox();
            CheckHide();

            LastChanceShow();
        }
                                                                    // activate "Controller" for the current input errors
        private void Checkbutton_Click(object sender, EventArgs e)
        {
            CheckIfEmptyBox();
            Controller();
           
        }
                                                                    //Goes back in edit-mode
        private void NOButton_Click(object sender, EventArgs e)
        {
            LastCHanceHide();

            SaveButton.Show();
            OfficeShowFuncBox();
            CheckShow();
        }
                                                                    // activate "FinalValidation" and goes back to search-mode
        private void YESButton_Click(object sender, EventArgs e)
        {
            LastCHanceHide();

            EditButton.Show();
            SearchInput.Show();
            SearchButton.Show();
            
            FinalValidation();
            
            
        }
    }
}
