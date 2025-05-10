using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace GUICust
{
    public class DBConnection : IDisposable
    {
        public MySqlConnection connection;

        public DBConnection()
        {
            string connectionString = "server=localhost;user=root;database=costume_rental;password=Karl09295272324@;";
            connection = new MySqlConnection(connectionString);
        }

        public void Open() => connection.Open();
        public void Close() => connection.Close();

        public bool ValidateUser(string username, string password)
        {
            try
            {
                Open();  // Open connection
                string query = "SELECT COUNT(1) FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int userCount = Convert.ToInt32(cmd.ExecuteScalar()); // Returns 1 if user exists, otherwise 0

                return userCount == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                Close(); // Close the connection
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable); // Fill the DataTable with the results of the query
                }
            }

            return dataTable;
        }
        public void Dispose()
        {
            // Close the connection and release resources
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}

