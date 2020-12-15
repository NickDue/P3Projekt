using MySql.Data.MySqlClient;

namespace IntegrationTest
{
    public class EmployeeTest
    {
        private const string SqlLogin = @"server=localhost;userid=" + SQLCredentials.MySQLUsername + ";password=" + SQLCredentials.MySQLPassword + ";database=myhome";

        public string CreateNewEmployeeTest(string data)
        {
            string[] splittedAccount = data.Split(" ! ");
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            var query = "INSERT INTO test(product, product_2) values (@product, @product_2)";
            using var cmd = new MySqlCommand(query, con);
         
            cmd.Parameters.AddWithValue("@product", splittedAccount[1]);
            cmd.Parameters.AddWithValue("@product_2", splittedAccount[2]);
            cmd.Prepare();
         
            cmd.ExecuteNonQuery();
            return "Added new employee";
        }

        public string AuthenticateUser(string data)
        {
            string[] splittedData = data.Split(" ! ");
            using var con = new MySqlConnection(SqlLogin);
            con.Open();
            string query = "SELECT * FROM test where product_2 = '" + splittedData[2] + "' and product = '"+splittedData[1] +"';";
            using var cmd = new MySqlCommand(query, con);
            using MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == splittedData[1] && reader.GetString(2).Equals(splittedData[2]))
                {
                    return reader.GetString(1) + "!" + reader.GetString(2);
                }
            }

            return "COULDN'T FIND USER";
        }
    }
}