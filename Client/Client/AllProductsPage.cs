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
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ProductID";
            dataGridView1.Columns[1].Name = "Product name";
            dataGridView1.Columns[2].Name = "Color";
            dataGridView1.Columns[3].Name = "Location";
            AddNewRow();
            
        }
        private void AddNewRow()
        {
            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("2");
            row.Add("3");
            row.Add("4");
            dataGridView1.Rows.Add(row.ToArray());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
