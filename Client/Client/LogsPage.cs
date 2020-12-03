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

        public LogsPage()
        {
            InitializeComponent();
        }
        private void AddNewRow(string worker, string product, string message, string date)
        {
            ArrayList row = new ArrayList();
            row.Add(worker);
            row.Add(product);
            row.Add(message);
            row.Add(date);
            ProductGridView.Rows.Add(row.ToArray());
        }
        
        // get logs data
        private void getData()
        {
            DataTable data = new DataTable(); // stores data for DataGridView



        }

        private void LogsPage_Load(object sender, EventArgs e)
        {

        }

        // display logs data
        // search through logs data
        // create product list (testing)

    }
}
