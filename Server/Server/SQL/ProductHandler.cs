using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Org.BouncyCastle.Cms;

namespace Server.SQL
{
    class ProductHandler
    {
        private const string SqlLogin = @"server=localhost;userid=" + SQLCredentials.MySQLUsername + ";password=" + SQLCredentials.MySQLPassword + ";database=myhome";
        
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
                    productDescription = new ProductDescription(reader.GetInt32(1), reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetDouble(5),reader.GetDouble(6),reader.GetString(7),reader.GetString(8));
                    product = new Product(productDescription, reader.GetInt32(10), reader.GetString(9));
                }
                con.Close();
                if (product != null && productDescription != null)
                {
                    string result = product.description.id + "-" + product.description.colliNumber + "-" + product.description.colliAmount + "!" +
                        product.description.name + "!" + product.description.volume + "!" + product.description.weight + "!" + product.description.color + "!" + product.description.category + "!" +
                        product.placement+ "!" + product.amount;
                    if(!string.IsNullOrEmpty(result))
                        return result;
                }
                return "ERROR: PRODUCT NOT FOUND!";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return "ERROR OCCOURED!";
            }
        }

        public string AddProductToDatabase(int id, string number, string total, string name, double volume, double weight, string color, string category, string placement)
        {
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
                    return "ERROR: Product with this id already exists.";
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
                cmd.Parameters.AddWithValue("@category", "NONE");
                cmd.Parameters.AddWithValue("@placement", "HAL0-00-00");
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

        public string GetAllProducts()
        {
            string allProducts = "";
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = "SELECT * FROM products;";
            
            using var command = new MySqlCommand(query, con);
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = null;
                ProductDescription productDescription = null;
                string[] plc = reader.GetString(9).Split("-");
                productDescription = new ProductDescription(reader.GetInt32(1), reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetDouble(5),reader.GetDouble(6),reader.GetString(7),reader.GetString(8));
                product = new Product(productDescription, reader.GetInt32(10), new Placement(plc[0],plc[1], Int32.Parse(plc[2])));
                if (product != null && productDescription != null)
                {
                    allProducts += product.description.id + "-" + product.description.colliNumber + "-" + product.description.colliAmount + "!" +
                                         product.description.name + "!" + product.description.volume + "!" + product.description.weight + "!" + product.description.color + "!" + product.description.category + "!" +
                                         product.placement.PrintPlacement() + "!" + product.amount+ "\n";
                }
            }
            reader.Close();
            con.Close();
            return allProducts;
        }
        public string EditProductDetails(string productInfo)
        {
            string[] splitted = productInfo.Split('\n');
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = $"SELECT * FROM products WHERE {splitted[1]} AND {splitted[7]} AND {splitted[8]}";
            using var command = new MySqlCommand(query, con);
            int productIndex = 0;
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                productIndex = reader.GetInt32(0);
                Console.WriteLine(productIndex);
            }
            reader.Close();
            if (productIndex == 0)
            {
                con.Close();
                return "ERROR: Employee doesn't exists.";
            }

            for (int i = 1; i < splitted.Length-2; i++)
            {
                string[] split = splitted[i].Split(" = ");
                query = $"UPDATE products SET {split[0]} = '{split[1]}' WHERE products_index = {productIndex}";
                var cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            return "Edited a product.";
        }

        public string GetRelatedProducts(string id)
        {
            string products = "";
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = $"SELECT * FROM products WHERE colli_id = {id}";
            using var command = new MySqlCommand(query, con);
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                products +=
                    $"{reader.GetString(1)}!{reader.GetString(2)}!{reader.GetString(3)}!{reader.GetString(9)}\n";
            }
            return products;
        }
        public string DeleteProduct(string id, string colli, string total)
        {
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = $"DELETE FROM products where colli_id = {id} AND colli_number = {colli} AND colli_total = {total}";
            using var cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return $"Delete the product with id {id}-{colli}-{total}";
        }
        
    }
}
