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
    public partial class CreatePicklistWindow : UserControl
    {
        public CreatePicklistWindow()
        {
            InitializeComponent();
        }

        private void CreatePicklistWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // generate picklist to file
        }

        // Textboxes
        private void ProductNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            //PicklistView.Items.Add(new ListViewItem(new[] {ProductNumberTextbox.Text, ProductNameTextbox.Text, LocationTextbox.Text, AmountTextbox.Text }));
        }

        private void ProductNameTextbox_TextChanged(object sender, EventArgs e)
        {
            //PicklistView.Items.Add(new ListViewItem(new[] { ProductNumberTextbox.Text, ProductNameTextbox.Text, LocationTextbox.Text, AmountTextbox.Text }));
        }

        private void LocationTextbox_TextChanged(object sender, EventArgs e)
        {
            //PicklistView.Items.Add(new ListViewItem(new[] { ProductNumberTextbox.Text, ProductNameTextbox.Text, LocationTextbox.Text, AmountTextbox.Text }));
        }

        private void AmountTextbox_TextChanged(object sender, EventArgs e)
        {
            //PicklistView.Items.Add(new ListViewItem(new[] { ProductNumberTextbox.Text, ProductNameTextbox.Text, LocationTextbox.Text, AmountTextbox.Text }));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PicklistView.Items.Add(new ListViewItem(new[] { ProductNumberTextbox.Text, ProductNameTextbox.Text, LocationTextbox.Text, AmountTextbox.Text }));
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            PicklistView.Hide();
            UserInputPanel.Hide();
            
            List<TextBox> storeChoice = new List<TextBox>();
            storeChoice.Add(CityTextbox);
            storeChoice.Add(PlatformTextbox);
            storeChoice.Add(ExpressTextbox);

            string errorPreset = "The following is missing: \n\n";
            string errorMessage = "";

            foreach (TextBox tb in storeChoice)
            {
                errorMessage += (CheckTextBox(tb));
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorPreset + errorMessage, "Error");
            }
            else
            {
                PicklistView.Show();
                UserInputPanel.Show();

                CityTextbox.ReadOnly = true;
                PlatformTextbox.ReadOnly = true;
                ExpressTextbox.ReadOnly = true;
            }

        }

        private string CheckTextBox(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                return tb.Name + "\n";
            }
            else
            {
                return null;
            }
        }
    }
}
