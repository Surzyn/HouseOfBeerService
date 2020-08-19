using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class PubsRepository
    {
        private const string CONNECTION_STRING = "Data Source=DESKTOP-5KOF6PB\\SQLEXPRESS;Initial Catalog=HouseOfBeer;Integrated Security=True";

        public List<FavouritePub> GetFavouritePubs()
        {
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = @"select Id, Name, Rate
                                        from[HouseOfBeer].[dbo].[Pubs]
                                        where IsFavourite = 1";
                command.Connection = con;
                con.Open();

                SqlDataReader reader = command.ExecuteReader();

                var pubs = new List<FavouritePub>();
                while (reader.Read())
                {
                    var pub = new FavouritePub();
                    pub.Id = (int)reader["id"];
                    pub.Name = (string)reader["name"];
                    pub.Rate = (int)reader["rate"];
                    pubs.Add(pub);
                }

                return pubs;
            }
        }
    }
}
