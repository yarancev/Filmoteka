using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmoteka
{
    class DataBaseMethods
    {   
        public static void AddToDatabase(Films Film)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");            
            collection.InsertOne(Film);
        }
        public static void FindNameToDatabase(string nameOfFilm)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            collection.Find(x => x.NameOfFilm == nameOfFilm);
        }
    }
}
