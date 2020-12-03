using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Client.TCP;

namespace Client
{
    public partial class AllProductsPage : UserControl
    {
        public AllProductsPage()
        {
            InitializeComponent();
            AddSampleData();
            AddDatabaseProducts();
            SetDate(DateLabelOutput);
            SetTotalAmount(AmountLabelOutput);
        }

        private void AddSampleData()
        {
            ProductGridView.ColumnCount = 4;
            ProductGridView.Columns[0].Name = "ProductID";
            ProductGridView.Columns[1].Name = "Product name";
            ProductGridView.Columns[2].Name = "Color";
            ProductGridView.Columns[3].Name = "Location";
            //AddNewRow();
        }

        private void AddDatabaseProducts()
        {
            string query = "get products";
            TCPClient client = new TCPClient();
            string repsonse = client.Connect(query);
            string[] products = repsonse.Split('\n');
            foreach (string p in products)
            {
                string[] splittedProduct = p.Split('!');
                if(splittedProduct.Length == 8)
                    AddNewRow(splittedProduct[0], splittedProduct[1],splittedProduct[4],splittedProduct[6]);
            }
        }

        private void AddNewRow(string id, string name, string color, string location)
        {
            ArrayList row = new ArrayList();
            row.Add(id);
            row.Add(name);
            row.Add(color);
            row.Add(location);
            ProductGridView.Rows.Add(row.ToArray());
        }

        private void SetDate(Label label)
        {
            label.Text = DateTime.Now.ToString();
        }

        private void SetTotalAmount(Label label)
        {
            label.Text = ProductGridView.Rows.Count.ToString();
        }
    }
}
