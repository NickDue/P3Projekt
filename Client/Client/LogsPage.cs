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
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace Client
{
    public partial class LogsPage : UserControl
    {
        public static string action = "Updated product";
        public LogsPage()
        {
            InitializeComponent();
            update();
        }

        private void update()
        {
        
            DataTable.ColumnCount = 5;
            DataTable.Columns[0].Name = "Worker ID";
            DataTable.Columns[1].Name = "Product";
            DataTable.Columns[2].Name = "Action";
            DataTable.Columns[3].Name = "Old value";
            DataTable.Columns[4].Name = "New value";

            AddNewRow(12223, 12131, action, "123", "144");


        }
        private void AddNewRow(int worker, int product, string action, string oldVal, string newVal)
        {
            ArrayList row = new ArrayList();
            row.Add(worker);
            row.Add(product);
            row.Add(action);
            row.Add(oldVal);
            row.Add(newVal);
            DataTable.Rows.Add(row.ToArray());
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
