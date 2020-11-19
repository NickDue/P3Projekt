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



        private void EmployeeFlowPanel_Load(object sender, EventArgs e)
        {

        }

        void ListItem_WasClicked(object sender, EventArgs e)
        {
            // Deselects all other ListItems
            foreach (ListItem listItem in ItemList)
            {
                listItem.Selected = false;
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //employeeInputWindow1.Show();

            Random rand = new Random();

            AddEmployee("Dunke Dolmer", rand.Next(10000, 99999), "FLOOR", "9/11-2004", Resources._912214);


        }


        private void AddEmployee(string employeeName, int workerID, string role, string lastlog, Image pic)
        {

            ListItem employee = new ListItem
            {
                EmployeeName = employeeName,
                WorkerID = workerID,
                Role = role,
                LastLog = lastlog,
                Picture = pic,
                Selected = false
            };

            employee.WasClicked += ListItem_WasClicked;
            ItemList.Add(employee);
            EmployeeFlowPanel.Controls.Add(employee);
        }

        private void RemoveEmployee()
        {
            ListItem item = GetSelected(ItemList);
            if(item != null)
            {
                EmployeeFlowPanel.Controls.Remove(item);
                ItemList.Remove(item);
            }
        }

        private ListItem GetSelected(List<ListItem> list)
        {
            foreach(ListItem item in list)
            {
                if(item.Selected == true)
                {
                    return item;
                }
            }
            return null;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveEmployee();
        }

    }
}

