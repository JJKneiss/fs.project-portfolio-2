using System;
using Library;
using MySql.Data.MySqlClient;
namespace Kneiss_Jamie_DBSReview
{
    public class City
    {
        public string CityName;
        public decimal Temp;
        public int Humidity;
        public decimal Pressure;
        public DateTime CreatedDate;

        public City(string city)
        {
            CityName = city;
            Console.WriteLine("Checked in.");
        }
        public void Display(MySqlConnection conn)
        {
            string cs = @"server=127.0.0.1;userid=root;password=root;database=SampleAPI;port=8889";
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                string stm = "SELECT city, temp, humidity, pressure, createdDate " +
                    "FROM weather " +
                    "WHERE city = @city " +
                    "ORDER BY createdDate DESC " +
                    "LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(stm, conn);
                cmd.Parameters.AddWithValue("@city", CityName);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        decimal.TryParse(rdr["temp"].ToString(), out Temp);
                        int.TryParse(rdr["humidity"].ToString(), out Humidity);
                        decimal.TryParse(rdr["pressure"].ToString(), out Pressure);
                        DateTime.TryParse(rdr["createdDate"].ToString(), out CreatedDate);
                    }
                    Console.WriteLine($"\r\nCity: {CityName}\r\n" +
                                      $"Temperature: {Temp}\r\n" +
                                      $"Humidity:  {Humidity}\r\n" +
                                      $"Pressure: {Pressure}\r\n" +
                                      $"Time of Forecast: {CreatedDate}");
                }
                else
                {
                    Console.WriteLine($"No data available for {CityName}.");
                }
                Console.WriteLine("\r\nThank you for checking! Have a good day");
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
        }
    }
}
