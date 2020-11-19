using System;
using MySql.Data.MySqlClient;
using Renci.SshNet.Messages.Connection;

namespace Server.SQL
{
    public class EmployeeHandler
    {
        private const string SqlLogin = @"server=localhost;userid="+SQLCredentials.MySQLUsername+";password="+SQLCredentials.MySQLPassword+";database=myhome";

        public String GetEmployeeById(int id)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();
                string result = "";
                string query = "SELECT * FROM users WHERE id = " + id;
                using var cmd = new MySqlCommand(query, con);
                Employee employee = null;
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(employee == null)
                        employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    //Console.WriteLine("{0} {1} {2} {3}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }

                if (employee == null)
                    return "Employee doesn't exist in the database.";

                result = employee.employeeID + " ! " + employee.employeeName + " ! " + employee.role + " ! " +
                         employee.password;

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "Error occoured.";
            }
        }

        public void DeleteEmployeeFromDB(int id)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();
                string query = "DELETE FROM users where id = " + id;
                using var cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Removed user associated with id: " + id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void AddUserToDB(int id, string pw, string name, Employee.Role role)
        {
            try
            {
                 using var con = new MySqlConnection(SqlLogin);
                 con.Open();
                         
                 var query = "SELECT * FROM users WHERE id = " +id + ";";
                     
                 using var command = new MySqlCommand(query, con);
                 int ids = 0;
                 using MySqlDataReader reader = command.ExecuteReader();
                 while (reader.Read())
                 {
                     ids = reader.GetInt32(0);
                 }
                 reader.Close();

                 if (ids != 0)
                 {
                     Console.WriteLine("User already associated with this id.");
                     con.Close();
                     return;
                 }

                 var sql = "INSERT INTO users(id, username, password, role, register_date) values (@id, @username, @password, @role, @register_date)";
                     
                 using var cmd = new MySqlCommand(sql, con);
         
                 cmd.Parameters.AddWithValue("@id", id);
                 cmd.Parameters.AddWithValue("@username", name);
                 cmd.Parameters.AddWithValue("@password", pw);
                 cmd.Parameters.AddWithValue("@role", Enum.GetName(typeof(Employee.Role),role));
                 cmd.Parameters.AddWithValue("@register_date", DateTime.Now);
                 cmd.Prepare();
         
                 cmd.ExecuteNonQuery();
       
                 Console.WriteLine("Added user!");
            }
            catch (Exception e)
            {
                 Console.WriteLine(e);
                 throw;
            }
        }

        public void ChangeUserCredentials(int id, string newValue, string typeToAlter)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();
                string query = "UPDATE users SET " + typeToAlter + " = '" + newValue + "' WHERE id = " + id + ";";
                using var cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Changed "+typeToAlter+" of user with id: " + id + ". New password = " +newValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool AuthenticateUser(int id, string pw)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();
                string query = "SELECT * FROM users where password = '" + pw + "';";
                using var cmd = new MySqlCommand(query, con);
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id && reader.GetString(2).Equals(pw))
                        return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}