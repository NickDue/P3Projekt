using System;
using System.Diagnostics.CodeAnalysis;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;

namespace Server.SQL
{
    public class Login
    {
        
        private const string SqlLogin = @"server=localhost;userid=nick;password=Kongen2020.!;database=myhome";
        public void Connect()
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();
                Console.WriteLine($"MySQL version : {con.ServerVersion}");
                SelectTable();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void SelectTable()
        {
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string sql = "SELECT * FROM users WHERE id = 10";
            using var cmd = new MySqlCommand(sql, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1), 
                    rdr.GetString(2));
            }
        }

        public void addUser(string uname)
        {
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            var sql =
                "INSERT INTO users(id, username, password, role, register_date) values (@id, @username, @password, @role, @register_date)";
            
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id", 10);
            cmd.Parameters.AddWithValue("@username", uname);
            cmd.Parameters.AddWithValue("@password", "lort134");
            cmd.Parameters.AddWithValue("@role", "Office");
            cmd.Parameters.AddWithValue("@register_date", DateTime.Now);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("Added user!");
        }

        public void editAttribute()
        {
            using var con = new MySqlConnection(SqlLogin);
            con.Open();

            var sql = "DELETE FROM users WHERE id = 444";
            using var cmd = new MySqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Deleted user!");
        }
    }
}