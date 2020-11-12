using System;

namespace Server.LocalStorage
{
    public class LoadDatabaseFiles
    {
        public static void Load()
        {
            // todo: enter the functions
            LoadProducts();
            //LoadEmployees();
        }

        private static void LoadProducts()
        {
            string toSplit = AccessDatabase.ReadData("Test");
            string[] splitted = toSplit.Split("\n");
            for (int i = 0; i < splitted.Length-1; i++)
            {
                string[] productSplitted = splitted[i].Split("?");
                ProductDescription pd = new ProductDescription(productSplitted[0], productSplitted[1], productSplitted[2], productSplitted[3],
                    Double.Parse(productSplitted[4]), Double.Parse(productSplitted[5]), productSplitted[6], (Category)Enum.Parse(typeof(Category),productSplitted[8])
                    );
                Placement placement = new Placement(productSplitted[8], productSplitted[9], Int32.Parse(productSplitted[10]));
                Product p  = new Product(pd, Int32.Parse(productSplitted[7]),placement);
                LoadedDatabase.AllProducts.Add(productSplitted[0],p);
            }
        }

        private static void LoadEmployees()
        {
            string toSplit = AccessDatabase.ReadData("EmployeeTest");
            string[] splitted = toSplit.Split("\n");
            for (int i = 0; i < splitted.Length - 1; i++)
            {
                string[] employeeSplitted = splitted[i].Split("?");
                //Console.WriteLine(employeeSplitted[0]);
               // Employee em = new Employee(Int32.Parse(employeeSplitted[0]), employeeSplitted[1], employeeSplitted[2], (Employee.Role)Enum.Parse(typeof(Employee.Role),employeeSplitted[3]));
               // LoadedDatabase.Employees.Add(em);
            }
        }
    }
}