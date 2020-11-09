using System;
using MySql.Data.MySqlClient;
using Renci.SshNet.Messages.Connection;

namespace Server.SQL
{
    public class EmployeeHandler
    {
        private const string SqlLogin = @"server=localhost;userid=nick;password=Kongen2020.!;database=myhome";

        public Employee GetEmployeeById(int id)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();

                string query = "SELECT * FROM users WHERE id = " + id;
                using var cmd = new MySqlCommand(query, con);
                Employee employee = null;
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(employee == null)
                        employee = new Employee(reader.GetInt32(0),reader.GetString(2),reader.GetString(1),(Employee.Role)Enum.Parse(typeof(Employee.Role),reader.GetString(3)));
                    //Console.WriteLine("{0} {1} {2} {3}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }

                return employee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return null;


        }
    }
}