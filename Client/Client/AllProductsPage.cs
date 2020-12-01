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

namespace Client
{
    public partial class AllProductsPage : UserControl
    {
        public AllProductsPage()
        {
            InitializeComponent();
            update();
        }

        private void update()
        {
            ProductGridView.ColumnCount = 4;
            ProductGridView.Columns[0].Name = "ProductID";
            ProductGridView.Columns[1].Name = "Product name";
            ProductGridView.Columns[2].Name = "Color";
            ProductGridView.Columns[3].Name = "Location";
            AddNewRow();
            
        }
        private void AddNewRow()
        {
            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("2");
            row.Add("3");
            row.Add("4");
            ProductGridView.Rows.Add(row.ToArray());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
