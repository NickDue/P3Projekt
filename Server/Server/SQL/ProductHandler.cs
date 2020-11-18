using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Cms;

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
                        product = new ProductDescription(reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
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

        public string ProductById(int id, string number, string total)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();

                string query = "SELECT * FROM products WHERE colli_id = " + id + " AND colli_number = " + number + " AND colli_total = " + total + ";";
                using var cmd = new MySqlCommand(query, con);

                Product product = null;
                ProductDescription productDescription = null;

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] plc = reader.GetString(9).Split("-");
                    productDescription = new ProductDescription(reader.GetInt32(1), reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetDouble(5),reader.GetDouble(6),reader.GetString(7),reader.GetString(8));
                    product = new Product(productDescription, reader.GetInt32(10), new Placement(plc[0],plc[2], Int32.Parse(plc[1])));
                }

                if (product != null && productDescription != null)
                {
                    string result = product.description.id + "-" + product.description.colliNumber + "-" + product.description.colliAmount + " ! " +
                        product.description.name + " ! " + product.description.volume + " ! " + product.description.weight + " ! " + product.description.color + " ! " + product.description.category + " ! " +
                        product.placement.PrintPlacement() + " ! " + product.amount;
                    return result;
                }
                
                return "";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return "ERROR OCCOURED!";
            }
        }

        public string AddProductToDatabase(int id, string number, string total, string name, double volume, double weight, string color, string category, string placement)
        {
            // TODO: Enten skal vi lave Logs table om (hvilket jeg tror er nemmmest), ellers spørg imran.
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();

                string query = "SELECT * FROM products WHERE colli_id = " + id + " AND colli_number = " + number + " AND colli_total = " + total + ";";
                using var command = new MySqlCommand(query, con);
                int dbId = 0; 
                string dbNumber = "", dbTotal = "";
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dbId = reader.GetInt32(1);
                    dbNumber = reader.GetString(2);
                    dbTotal = reader.GetString(3);
                }

                reader.Close();

                if (dbId != 0 && !dbNumber.Equals("") && !dbTotal.Equals(""))
                {
                    con.Close();
                    return "Product with this id already exists.";
                }
                var sql = "INSERT INTO products(colli_id, colli_number, colli_total, name, volume, weight, color, category, placement, amount) values (@colli_id, @colli_number, @colli_total, @name, @volume, @weight, @color, @category, @placement, @amount)";
                using var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@colli_id", id);
                cmd.Parameters.AddWithValue("@colli_number", number);
                cmd.Parameters.AddWithValue("@colli_total", total);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@volume", volume);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@color", color);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@placement", placement);
                cmd.Parameters.AddWithValue("@amount", 0);
                cmd.Prepare();
         
                cmd.ExecuteNonQuery();
                return "Added item to database";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "ERROR: Couldn't add product to Database";
            }
            return "ERROR: Couldn't add product to Database";
        }

        public string RemoveProductFromDB(int id, string number, string total)
        {
            try
            {
                using var con = new MySqlConnection(SqlLogin);
                con.Open();
                
                string query = "DELETE FROM products WHERE colli_id = " + id + " AND colli_number = " + number + " AND colli_total = " + total + ";";
                using var cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return "Removed Product";
            }
            catch (Exception e)
            {
                return "ERROR OCCURED";
            }
        }

        
    }
}
