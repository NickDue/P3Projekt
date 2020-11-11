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
    public partial class LogsPage : UserControl
    {
        public LogsPage()
        {
            InitializeComponent();
            update();
        }
        private void update()
        {
            ArrayList row = new ArrayList();
            DataTable.ColumnCount = 5;
            DataTable.Columns[0].Name = "Worker ID";
            DataTable.Columns[1].Name = "Product";
            DataTable.Columns[2].Name = "Action";
            DataTable.Columns[3].Name = "Old value";
            DataTable.Columns[4].Name = "New value";
            for(int i = 1; i<50; i++)
            { 
                AddNewRow();
                
            }


        }
        private void AddNewRow()
        {
            ArrayList row = new ArrayList();
            row.Add("EMPTY");
            row.Add("EMPTY");
            row.Add("EMPTY");
            row.Add("EMPTY");
            row.Add("EMPTY");
            DataTable.Rows.Add(row.ToArray());
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
