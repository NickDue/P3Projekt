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
using System.Net.Sockets;
using Client.TCP;

namespace Client
{
    public partial class Testpage_office : UserControl
    {

        public Testpage_office()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = mergeInput(input1.Text, input2.Text);
            MessageBox.Show(input);
            addProduct(input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }

        private string mergeInput(string input1, string input2)
        {
            if(input1 == "" || input1 == null || input2 == "" || input2 == null)
            {
                MessageBox.Show("input cannot be empty...");
                return null;
            }
          return input1 + " ! " + input2;
        }
        private void deleteProduct()
        {
            string input = "delete product";
            TCPClient tcpClient = new TCPClient();
            string info = tcpClient.Connect(input);
            MessageBox.Show(info);
        }



        private void addProduct(string inputFromBox)
        {
            string input = "add product ! " + inputFromBox;
            TCPClient client = new TCPClient();
            string info = client.Connect(input);
            MessageBox.Show(info);
        }

        private void PrintToGrid(DataGridView grid, string input)
        {
            grid.Columns.Add("add here", "Input added");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(input);

            grid.Rows.Add(arrayList.ToArray());
        }

        private void getProduct()
        {
            string input = "get product";
            TCPClient client = new TCPClient();
            string info = client.Connect(input);
            PrintToGrid(dataGridView, info);
            MessageBox.Show(info);
        }

        private void GETbtn_Click(object sender, EventArgs e)
        {
            getProduct();
        }

        private void AddEmployee(string inputFromUser)
        {
            string input = "add user ! " + inputFromUser;
            TCPClient client = new TCPClient();
            client.Connect(input);
        }

        private void employee_Click(object sender, EventArgs e)
        {
            string input = mergeInput(input1.Text, input2.Text);
            AddEmployee(input);
        }
    }  
           
}
