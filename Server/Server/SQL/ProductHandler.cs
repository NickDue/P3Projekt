using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.SQL
{
    class ProductHandler
    {
        private const string SqlLogin = @"server=localhost;userid=" + SQLCredentials.MySQLUsername + ";password=" + SQLCredentials.MySQLPassword + ";database=myhome";

        public Product GetProductByID(string id, string colliNumber, string colliAmount)
        {
            using var con = new MySqlConnection(SqlLogin);
            con.Open();

            string query = "SELECT * FROM products WHERE colli_id = " + id + " AND colli_number = " + colliNumber + " AND colli_amount = " + colliAmount + ";";
            using var cmd = new MySqlCommand(query, con);
            Product product = null;
            using MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (product == null)
                {
                    product = new ProductDescription(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetString(6), reader.GetEnumerator(7));
                }
            }

            return product;
        }
    }
}
