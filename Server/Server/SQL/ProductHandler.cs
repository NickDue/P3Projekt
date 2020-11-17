using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.SQL
{
    class ProductHandler
    {
        private const string SqlLogin = @"server=localhost;userid=" + SQLCredentials.MySQLUsername + ";password=" + SQLCredentials.MySQLPassword + ";database=myhome";

        public ProductDescription GetProductByID(string id, string colliNumber, string colliAmount)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();

                string query = "SELECT * FROM products WHERE colli_id = " + id + " AND colli_number = " + colliNumber + " AND colli_total = " + colliAmount + ";";
                using var cmd = new MySqlCommand(query, con);
                ProductDescription product = null;
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (product == null)
                    {
                        product = new ProductDescription(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                                                         reader.GetDouble(5), reader.GetDouble(6), reader.GetString(7), reader.GetString(8));
                        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                                                         reader.GetDouble(5), reader.GetDouble(6), reader.GetString(7), reader.GetString(8));
                    }
                }

                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
