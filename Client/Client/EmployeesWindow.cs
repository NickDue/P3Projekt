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
using Client.TCP;

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
            //LoadEmployeesFromDatabase();
        }

        private void LoadEmployeesFromDatabase()
        {
            TCPClient client = new TCPClient();
            string output = client.Connect("get employees");
            string[] splitted = output.Split('\n');
            foreach (string s in splitted)
            {
                string[] employeeData = s.Split('!');
                if(employeeData.Length == 3)
                    AddEmployee(employeeData[0], Int32.Parse(employeeData[2]), employeeData[1],"9/11-2004", Resources._912214);
            }
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
            PromptForUserCreation();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PromptForUserEdit();
        }

        private void PromptForUserCreation()
        {
            EmployeeEditer editor = new EmployeeEditer();
            editor.Show();
            editor.EditorRequestAccepted += CreateEmployee;
        }

        private void CreateEmployee(ListItem employee)
        {
            employee.WasClicked += ListItem_WasClicked;
            ItemList.Add(employee);
            EmployeeFlowPanel.Controls.Add(employee);
        }

        private void PromptForUserEdit()
        {
            ListItem item = GetSelected(ItemList);
            EmployeeEditer editor = new EmployeeEditer(item);
            editor.Show();
            editor.EditorRequestAccepted += EditEmployee;
        }
        
        private void EditEmployee(ListItem employee)
        {
            RemoveEmployee();
            employee.WasClicked += ListItem_WasClicked;
            ItemList.Add(employee);
            EmployeeFlowPanel.Controls.Add(employee);
        }


        private void AddEmployee(string employeeName, int workerID, string role, string lastlog, Image pic)
        {
            ListItem employee = new ListItem(employeeName, workerID, role, lastlog, pic);
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
                if(item.Selected)
                {
                    return item;
                }
            }
            return null;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveEmployeeFromDatabase();
            RemoveEmployee();
        }

        private void RemoveEmployeeFromDatabase()
        {
            ListItem item = GetSelected(ItemList);
            if(item != null)
            {
                string command = "remove employee ! ";
                TCPClient client = new TCPClient();
                command += item.WorkerID;
                string response = client.Connect(command);
                if (!response.StartsWith("ERROR"))
                {
                    EmployeeFlowPanel.Controls.Clear();
                    ItemList.Clear();
                    LoadEmployeesFromDatabase();
                    MessageBox.Show($"Removed employee with ID: {item.WorkerID}");
                }
                else
                {
                    MessageBox.Show("ERROR, COULD NOT REMOVE EMPLOYEE", "error");
                }
                
            }
        }

    }
}

