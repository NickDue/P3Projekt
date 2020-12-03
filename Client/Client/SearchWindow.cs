using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.TCP;

namespace Client
{
    public partial class SearchWindow : UserControl
    {
        private List<string> EditedValues = new List<string>();
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
            //Clearfunc(); //Removed for testing
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
            // Product number validation
            try
            {
                Int32.Parse(ProductNumBox.Text);

                if (ProductNumBox.Text.Length != 5)
                {
                    MessageBox.Show("Product number has to be 5 numbers", "error");
                }
                else
                {
                    EditedValues.Add($"colli_id = {ProductNumBox.Text}");
                    //ProductNumLabel.Text = ProductNumBox.Text;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Product number has to be a number", "error");
                ProductNumBox.Text = ProductNumLabel.Text;
            }
            //amount Validation
            try
            {
                if (Int32.Parse(amountBox.Text) <= 0 || amountBox.Text.Length > 4)
                {
                    MessageBox.Show("Amount should be more than 0 and less than 9999", "error");
                    EditedValues.Add($"amount = {amountBox.Text}");
                    //amountBox.Text = AmountLabel.Text;
                }
                else
                {
                    EditedValues.Add($"amount = {amountBox.Text}");
                    //AmountLabel.Text = amountBox.Text;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Amount has to be a number", "error");
                amountBox.Text = AmountLabel.Text;
            }
            // Weight and volume validation
            try
            {
                if (double.Parse(WeightBox.Text) < 0.0 || double.Parse(WeightBox.Text) > 500.0 ||
                    double.Parse(VolumeBox.Text) < 0.0 || double.Parse(VolumeBox.Text) > 5.0)
                {
                    MessageBox.Show("Weight and Volume either too high or too low. HENCE, it also could be '.' instead of ','.", "Error");
                    WeightLabel.Text = WeightLabel.Text;
                    VolumeLabel.Text = VolumeLabel.Text;
                }
                else
                {
                    EditedValues.Add($"weight = {WeightBox.Text}");
                    EditedValues.Add($"volume = {VolumeBox.Text}");
                    //WeightLabel.Text = WeightBox.Text;
                    //VolumeLabel.Text = VolumeBox.Text;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Weight and Volume has to be number with ONLY 1 decimal", "error");
                WeightBox.Text = WeightLabel.Text;
                VolumeBox.Text = VolumeLabel.Text;
            }

            // Product name and color validation
            if(ProductNameBox.Text.Length > 100 || ColorBox.Text.Length > 20)
            {
                MessageBox.Show("Name is to long", "Error");
                ProductNameLabel.Text = ProductNameLabel.Text;
            }
            else
            {
                EditedValues.Add($"name = {ProductNameBox.Text}");
                EditedValues.Add($"color = {ColorBox.Text}");
                //ProductNameLabel.Text = ProductNameBox.Text;
                //ColorLabel.Text = ColorBox.Text;
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
                    string[] colliSplitted = item.Split('/');
                    EditedValues.Add($"colli_number = {colliSplitted[0]}");
                    EditedValues.Add($"colli_total = {colliSplitted[1]}");
                    //PrimaryColliLabel.Text = PrimaryColliBox.Text;
                    break;
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
                EditedValues.Add($"placement = {PrimaryLocationBox.Text}");
                //PrimaryLocationLabel.Text = PrimaryLocationBox.Text;
            }
        }
                                                                    //This ONLY check the value, if no errors = success
        private void Controller()
        {
            int errors = 0;  // Count errors happen

            // Product number validation
            try
            {
                Int32.Parse(ProductNumBox.Text);

                if (ProductNumBox.Text.Length != 5)
                {
                    MessageBox.Show("Product number has to be 5 numbers", "error");
                    ProductNumBox.Text = ProductNumLabel.Text;
                    errors++;
                }
 
            }
            catch (FormatException)
            {
                MessageBox.Show("Product number has to be a number", "error");
                ProductNumBox.Text = ProductNumLabel.Text;
            }
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
            // Weight and volume validation
            try
            {
                if (double.Parse(WeightBox.Text) < 0.0 || double.Parse(WeightBox.Text) > 500.0 ||
                    double.Parse(VolumeBox.Text) < 0.0 || double.Parse(VolumeBox.Text) > 5.0)
                {
                    MessageBox.Show("Weight and Volume either too high or too low. HENCE, it also could be '.' instead of ','.", "Error");
                    WeightBox.Text = WeightLabel.Text;
                    VolumeBox.Text = VolumeLabel.Text;
                    errors++;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Weight and Volume either too high or too low. HENCE, it also could be '.' instead of ','.", "Error");
                MessageBox.Show("Weight and Volume has to be number with ONLY 1 decimal", "error");
                WeightBox.Text = WeightLabel.Text;
                VolumeBox.Text = VolumeLabel.Text;
            }

            // Product name and color validation
            if (ProductNameBox.Text.Length > 100 || ColorBox.Text.Length > 20)
            {
                MessageBox.Show("Name is to long", "Error");
                ProductNameLabel.Text = ProductNameLabel.Text;
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
            Backbutton.Hide();
            SaveButton.Hide();
            OfficeHideFuncBox();
            CheckHide();
            LastCHanceHide();
            
        }
                                                                    //Enter edit-mode
        private void EditButton_Click(object sender, EventArgs e)
        {
            Backbutton.Show();
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
            Backbutton.Hide();
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
            Backbutton.Show();
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
            SendToServer();
            GetProductFromServer();
        }

        private void SendToServer()
        {
            string toSend = "edit product\n";
            EditedValues.Add(UserCredentials.WorkerId.ToString());
            foreach (string str in EditedValues)
            {
                toSend += str + "\n";
            }
            EditedValues.Clear();
            MessageBox.Show(toSend);
            TCPClient client = new TCPClient();
            string response = client.Connect(toSend);
            if (!response.StartsWith("ERROR"))
            {
                MessageBox.Show("Edited product.");
            }
            else
            {
                MessageBox.Show("Failure");
            }
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
            OfficeHideFuncBox();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchInput.Text))
                return;
            GetProductFromServer();
        }

        private void GetProductFromServer()
        {
            string[] splittedInput = SearchInput.Text.Split('-');
            if (splittedInput.Length != 3)
                return;
            string input = $"find product ! {splittedInput[0]} ! {splittedInput[1]} ! {splittedInput[2]} ! {UserCredentials.WorkerId}";
            //string input = "find product ! 21188 ! 01 ! 03";
            TCPClient client = new TCPClient();
            string info = client.Connect(input);
            if (!info.StartsWith("ERROR"))
            {
                string[] splittedOutput = info.Split('!');
                string[] splittedId = splittedOutput[0].Split('-');
                ProductNumLabel.Text = splittedId[0];
                ProductNameLabel.Text = splittedOutput[1];
                VolumeLabel.Text = splittedOutput[2];
                WeightLabel.Text = splittedOutput[3];
                ColorLabel.Text = splittedOutput[4];
                PrimaryLocationLabel.Text = splittedOutput[6];
                AmountLabel.Text = splittedOutput[7];
                PrimaryColliLabel.Text = Int32.Parse(splittedId[1]) + "/" + Int32.Parse(splittedId[2]);
            }
            else
            {
                MessageBox.Show("Product Not Found", "error");
            }
        }
    }
}
