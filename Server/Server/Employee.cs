namespace Server
{
    public class Employee
    {
        public int _employeeID { get; set; }
        public string _password { get; set; }
        public string _employeeName { get; set; }
        public Role _role { get; set; }

        public Employee(int employeeID, string password, string employeeName, Role role)
        {
            _employeeID = employeeID;
            _password = password;
            _employeeName = employeeName;
            _role = role;
        }

        void CreateEmployee(int employeeID, string password, string name, string role)
        {

        }

        public enum Role
        {
            floorWorker,
            officeWorker
        }
    }
}
