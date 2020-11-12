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
            PicklistView.Hide();
            UserInputPanel.Hide();

            FillComboBox();
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
            ControlUserInput(); 
        }

        private void ControlUserInput()
        {
            List<ComboBox> list = new List<ComboBox>();
            list.Add(CityCombobox);
            list.Add(PlatformCombobox);
            list.Add(ExpressCombobox);

            string errorPreset = "The following is missing: \n\n";
            string errorMessage = "";

            foreach (ComboBox cb in list)
            {
                errorMessage += (CheckComboBox(cb));
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorPreset + errorMessage, "Error");
            }
            else
            {
                PicklistView.Show();
                UserInputPanel.Show();
            }
        }

        // Controls user input
        private string CheckComboBox(ComboBox cb)
        {
            if (string.IsNullOrWhiteSpace(cb.Text))
            {
                return cb.Name + "\n";
            }
            else
            {
                return null;
            }
        }

        // Adds data to the user boxes
        private void FillComboBox()
        {
            foreach (string store in CreateStoreList())
            {
                CityCombobox.Items.Add(store);
            }

            PlatformCombobox.Items.Add("Store order");
            PlatformCombobox.Items.Add("Online order");

            ExpressCombobox.Items.Add("Yes");
            ExpressCombobox.Items.Add("No");
        }

        // Creates and returns a list of stores
        private List<string> CreateStoreList()
        {
            List<string> stores = new List<string>();
            
            stores.Add("Bornholm");
            stores.Add("Broendby");
            stores.Add("Esbjerg");
            stores.Add("Fredericia");
            stores.Add("Frederikshavn"); // Not available currently
            stores.Add("Gladsaxe");
            stores.Add("Herning");
            stores.Add("Hilleroed");
            stores.Add("Hjoerring");
            stores.Add("Holbaek");
            stores.Add("Holstebro");
            stores.Add("Horsens");
            stores.Add("Ishoej");
            stores.Add("Kastrup");
            stores.Add("Kolding");
            stores.Add("Koege");
            stores.Add("Egaa");
            stores.Add("Grenaa");
            stores.Add("Nakskov");
            stores.Add("Nykoebing Falster");
            stores.Add("Naestved");
            stores.Add("Odense");
            stores.Add("Randers");
            stores.Add("Roskilde");
            stores.Add("Sdr. Omme");
            stores.Add("Silkeborg");
            stores.Add("Slagelse");
            stores.Add("Svendborg");
            stores.Add("Soenderborg");
            stores.Add("Thisted");
            stores.Add("Vejle");
            stores.Add("Viborg");
            stores.Add("Aabenraa");
            stores.Add("Aalborg");
            stores.Add("Aarhus");

            return stores;
        }
    }
}
