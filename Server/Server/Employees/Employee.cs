using System.Collections.Generic;

namespace Server
{
    public class Employee
    {
        
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public Employee(int employeeID, string employeeName, string password, string role)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.password = password;
            this.role = role;
        }

        void CreateEmployee(int employeeID, string password, string name, string role)
        {

        }

        public enum Role
        {
            FloorWorker,
            OfficeWorker
        }
    }
}
