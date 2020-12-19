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
using Client.TCP;

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

        private void LogsPage_Load(object sender, EventArgs e)
        {
            LoadFromDatabase();
        }

        private void LoadFromDatabase()
        {
            TCPClient client = new TCPClient();
            string query = $"get logs ! {UserCredentials.WorkerId}";
            string response = client.Connect(query);
            string[] logs = response.Split('\n');
            foreach (string str in logs)
            {
                string[] splittedLog = str.Split('!');

                if (splittedLog.Length == 4)
                {
                    for (int i = 0; i < splittedLog.Length; i++)
                    {
                        if (splittedLog[1].Contains("null"))
                        {
                            string formatLog = splittedLog[1];
                            string[] formatSplitLog = formatLog.Split('-');

                            for (int k = 0; k < formatSplitLog.Length; k++)
                            {
                                if (formatSplitLog[k] == "null")
                                {
                                    formatSplitLog[k] = "";
                                }
                            }
                            splittedLog[1] = string.Join(" ", formatSplitLog);
                        };
                    }
                    AddNewRow(splittedLog[0], splittedLog[1], splittedLog[2], splittedLog[3]);
                }
            }
        }
    }
}
