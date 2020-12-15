using MySql.Data.MySqlClient;
using System;

namespace IntegrationTest
{
    public class ProductTests
    {
        private const string SqlLogin = @"server=localhost;userid=" + SQLCredentials.MySQLUsername + ";password=" + SQLCredentials.MySQLPassword + ";database=myhome";

        public string GetLatestProduct()
        {
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = "SELECT * FROM test;";
            using var command = new MySqlCommand(query, con);
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return $"first input = {reader.GetString(1)}, second input = {reader.GetString(2)}";
            }

            return null;
        }

        public string AddTestProduct(string data)
        {
            string[] splittedData = data.Split(" ! ");
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = "INSERT INTO test(product, product_2) values (@product, @product_2)";
            using var cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product", splittedData[1]);
            cmd.Parameters.AddWithValue("@product_2", splittedData[2]);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            return "Added item to database";
        }

        public string DeleteTestProduct()
        {
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = $"DELETE FROM test;";
            using var cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Removed Product(s)";
        }
        public string EditTestProduct(string data)
        {
            string[] splittedData = data.Split(" ! ");
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = $"UPDATE test SET product = '{splittedData[1]}'";
            var cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            query = $"UPDATE test SET product_2 = '{splittedData[2]}'";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Edited a product.";

        }
    }
}