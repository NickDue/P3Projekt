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



        int amountOfEmloyees = 25;
        private void PopulateEmployeeList()
        {
            ListItem[] ItemList = new ListItem[amountOfEmloyees];

            Random random = new Random();

            for(int i = 0; i < ItemList.Length; i++)
            {
                ItemList[i] = new ListItem();
                ItemList[i].EmployeeName = random.Next(1, 10).ToString();
                ItemList[i].WorkerID = random.Next(1, 10).ToString();
                ItemList[i].Role = random.Next(1, 10).ToString();
                ItemList[i].LastLog = random.Next(1, 10).ToString();
                ItemList[i].Picture = Resources._912214;


                if(EmployeeFlowPanel.Controls.Count < 0)
                {
                    EmployeeFlowPanel.Controls.Clear();
                }
                else
                {
                    EmployeeFlowPanel.Controls.Add(ItemList[i]);
                }
                
            }


        }

        private void EmloyeeFlowPanel_Load(object sender, EventArgs e)
        {
            PopulateEmployeeList();
        }
        private void EmployeeFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
