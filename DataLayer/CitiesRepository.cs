using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CitiesRepository
    {
        private const string CONNECTION_STRING = "Data Source=DESKTOP-5KOF6PB\\SQLEXPRESS;Initial Catalog=HouseOfBeer;Integrated Security=True";

        public City GetCity()
        {
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "Select top(1) * from [HouseOfBeer].[dbo].[Cities]";
                command.Connection = con;
                con.Open();

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                var cityBaseOnDBResult = new City();
                cityBaseOnDBResult.Id = (int)reader["id"];
                cityBaseOnDBResult.Name = (string)reader["name"];
                return cityBaseOnDBResult;
            }
        }

        public List<City> GetAllCities()
        {
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from Cities";
                command.Connection = con;
                con.Open();

                SqlDataReader reader = command.ExecuteReader();

                var result = new List<City>();
                while (reader.Read())
                {
                    var city = new City();
                    city.Id = (int)reader["id"];
                    city.Name = (string)reader["name"];
                    result.Add(city);
                }

                return result;
            }
        }
    }
}
