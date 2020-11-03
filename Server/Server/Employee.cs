using System.Collections.Generic;

namespace Server
{
    public class Employee
    {
        public static List<Employee> employeeList = new List<Employee>();

        public int employeeID { get; set; }
        public string password { get; set; }
        public string employeeName { get; set; }
        public Role role { get; set; }

        public Employee(int employeeID, string password, string employeeName, Role role)
        {
            this.employeeID = employeeID;
            this.password = password;
            this.employeeName = employeeName;
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
