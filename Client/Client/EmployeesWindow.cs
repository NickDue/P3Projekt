using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Properties;

namespace Client
{
    public partial class EmployeesWindow : UserControl
    {
        public EmployeesWindow()
        {
            InitializeComponent();
        }

        private List<ListItem> ItemList = new List<ListItem>();
        
        
        
        /*
        private void PopulateEmployeeList()
        {
            //hej
         
            for (int i = 0; i < ItemList.Count(); i++)
            {

                ItemList[i] = new ListItem();
                ItemList[i].EmployeeName = "Ben Dover";
                ItemList[i].WorkerID = 12345;
                ItemList[i].Role = "FLOOR";
                ItemList[i].LastLog = "01/01-0001";
                ItemList[i].Picture = Resources._912214;


                int itemsPerRow = 3;
                int gap = ((EmployeeFlowPanel.Width - (ItemList[i].Width * itemsPerRow)) / 6) - 1;
                ItemList[i].Margin = new Padding(gap, gap, gap, gap);

                if (EmployeeFlowPanel.Controls.Count < 0)
                {
                    EmployeeFlowPanel.Controls.Clear();
                }
                else
                {
                    EmployeeFlowPanel.Controls.Add(ItemList[i]);
                }   
                
            }
        }
        */

        private void EmloyeeFlowPanel_Load(object sender, EventArgs e)
        {
            Size = new Size(982, 758);
            Padding = new Padding(0, 0, 0, 0);

        }

        

        private void AddButton_Click(object sender, EventArgs e)
        {
            employeeInputWindow1.Show();

        }

        
        private void AddEmployee(string employeeName, int workerID, string role, string lastlog, Image pic)
        {
            
            ListItem employee = new ListItem
            {
                EmployeeName = employeeName,
                WorkerID = workerID,
                Role = role,
                LastLog = lastlog,
                Picture = pic
            };

            ItemList.Add(employee);
            
        }
        
    }
}
