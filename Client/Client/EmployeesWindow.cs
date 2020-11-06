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
    public partial class EmployeesWindow : UserControl
    {
        public EmployeesWindow()
        {
            InitializeComponent();
        }


        int amountOfEmloyees = 25;
        private void PopulateEmployeeList()
        {
            ListItem[] ItemList = new ListItem[amountOfEmloyees];

            Random random = new Random();

            foreach (ListItem item in ItemList)
            {
                item.EmployeeName = random.Next(1, 10).ToString();
                item.WorkerID = random.Next(1, 10).ToString();
                item.Role = random.Next(1, 10).ToString();
                item.LastLog = random.Next(1, 10).ToString();


                if(EmployeeFlowPanel.Controls.Count > 0)
                {
                    EmployeeFlowPanel.Controls.Clear();
                }
                else
                {
                    EmployeeFlowPanel.Controls.Add(item);
                }
                


            }


        }

        private void EmployeeFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            PopulateEmployeeList();
        }
    }
}
