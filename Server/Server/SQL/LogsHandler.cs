using System;
using System.Xml;
using MySql.Data.MySqlClient;

namespace Server.SQL
{
    public class LogsHandler
    {
        private const string SqlLogin = @"server=localhost;userid="+SQLCredentials.MySQLUsername+";password="+SQLCredentials.MySQLPassword+";database=myhome";

        public void WriteToLog(string pId, string cId, string tId, string uId, string msg)
        {
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query =
                "INSERT INTO logs(product_id, colli_id, total_id, user_id, message, log_date) values (@product_id, @colli_id, @total_id, @user_id, @message, @log_date)";
            using var cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", pId);
            cmd.Parameters.AddWithValue("@colli_id", cId);
            cmd.Parameters.AddWithValue("@total_id", tId);
            cmd.Parameters.AddWithValue("@user_id", uId);
            cmd.Parameters.AddWithValue("@message", msg);
            cmd.Parameters.AddWithValue("@log_date", DateTime.Now);
            cmd.Prepare();
         
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Wrote action to log.");
        }
    }
}