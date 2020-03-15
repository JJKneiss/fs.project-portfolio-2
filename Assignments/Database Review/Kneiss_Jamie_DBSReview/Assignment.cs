using System;
using Library;
using MySql.Data.MySqlClient;
namespace Kneiss_Jamie_DBSReview
{
    public class Assignment
    {
        public Assignment()
        {
            Connect();
        }
        private void Connect()
        {
            // MySQL Database Connection String
            string cs = @"server=127.0.0.1;userid=root;password=root;database=SampleAPI;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;
            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);
                conn.Open();
                string city = Validation.ValidateString("Enter your City: ", 2);
                City myCity = new City(city);
                myCity.Display(conn);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            Console.WriteLine("Done");
        }
    }
}
