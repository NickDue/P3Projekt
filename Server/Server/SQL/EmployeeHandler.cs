using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using Renci.SshNet.Messages.Connection;

namespace Server.SQL
{
    public class EmployeeHandler
    {
        private const string SqlLogin = @"server=localhost;userid="+SQLCredentials.MySQLUsername+";password="+SQLCredentials.MySQLPassword+";database=myhome";
        

        public string DeleteEmployeeFromDB(int id)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();
                string query = "SELECT * FROM users WHERE id = " + id;
                using var command = new MySqlCommand(query, con);
                using MySqlDataReader reader = command.ExecuteReader();
                int DbID = 0;
                while (reader.Read())
                {
                    DbID = reader.GetInt32(0);
                }
                reader.Close();

                if (DbID == 0)
                {
                    return "ERROR: Employee doesn't exist in the database.";
                }
                query = "DELETE FROM users where id = " + id;
                using var cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return "Removed user associated with id: " + id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "ERROR: Employee doesn't exist in the database.";
            }
        }

        public string AddUserToDB(int id, string pw, string name, string role)
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
                     con.Close();
                     return "ERROR: Employee already exists.";
                 }

                 var sql = "INSERT INTO users(id, username, password, role, register_date) values (@id, @username, @password, @role, @register_date)";
                     
                 using var cmd = new MySqlCommand(sql, con);
         
                 cmd.Parameters.AddWithValue("@id", id);
                 cmd.Parameters.AddWithValue("@username", name);
                 cmd.Parameters.AddWithValue("@password", pw);
                 //TODO: Make sure the worker role only can be "OfficeWorker" or "FloorWorker"
                 cmd.Parameters.AddWithValue("@role", role);
                 cmd.Parameters.AddWithValue("@register_date", DateTime.Now);
                 cmd.Prepare();
         
                 cmd.ExecuteNonQuery();

                 return "Added employee.";
            }
            catch (Exception e)
            {
                 Console.WriteLine(e);
                 return "ERROR: Employee already exists.";
            }
        }

        public string ChangeUserCredentials(int id, string name, string role, string password)
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

                if (ids == 0)
                {
                    con.Close();
                    return "ERROR: Employee doesn't exists.";
                }

                string[] newValues = new[] {$"username = '{name}'",$"role = '{role}'",$"password = '{password}'"};
                foreach (string str in newValues)
                {
                    query = $"UPDATE users SET {str} WHERE id = {id}";
                    using var cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            //query = "UPDATE users SET " + typeToAlter + " = '" + newValue + "' WHERE id = " + id + ";";
            return "Edited employee";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "ERROR";
            }

            return "ERROR";
        }

        public string AuthenticateUser(string id, string pw)
        {
            try
            {
                int ids;
                bool testIntId = Int32.TryParse(id, out ids);
                if(!testIntId)
                    return "ERROR: Incorrect information.";
                using var con = new MySqlConnection(SqlLogin);
                con.Open();
                string query = "SELECT * FROM users where password = '" + pw + "' and id = '"+id +"';";
                using var cmd = new MySqlCommand(query, con);
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == ids && reader.GetString(2).Equals(pw))
                    {
                        return reader.GetInt32(0) + "!" + reader.GetString(1) + "!" + reader.GetString(2) + "!" +
                               reader.GetString(3);
                    }
                }
                return "ERROR: Incorrect information.";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public string GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = "SELECT * FROM users";
            using var cmd = new MySqlCommand(query, con);
            using MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                if(employee != null)
                    employees.Add(employee);
            }
            reader.Close();
            string result = "";
            foreach (Employee e in employees)
            {
                result += e.employeeName + "!" + e.role + "!" + e.employeeID + "\n";
            }

            if (!string.IsNullOrEmpty(result))
                return result;
            return "ERROR";
        }
    }
}