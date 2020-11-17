using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            FileDataGridView.Hide();
            UserInputPanel.Hide();

            FillComboBox();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // generate picklist to file
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PicklistView.Items.Add(new ListViewItem(new[] { ProductNumberTextbox.Text, ProductNameTextbox.Text, LocationTextbox.Text, AmountTextbox.Text }));
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ControlUserInput();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            PicklistView.Hide();
            FileDataGridView.Show();
            
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false})
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileDataGridView.DataSource = ReadCsv(ofd.FileName);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Controls for missing user input
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

        // Controls combobox for user input
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

            #region City list
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
            #endregion

            return stores;
        }

        // Reads the .csv file
        public DataTable ReadCsv(string fileName)
        {
            DataTable data = new DataTable("Data");

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" +
                Path.GetDirectoryName(fileName) + "\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                using(OleDbCommand cmd = new OleDbCommand(string.Format("select *from [{0}]", new FileInfo(fileName).Name), conn))
                {
                    conn.Open();
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                }
            }

            return data;
        }
        
    }
}
