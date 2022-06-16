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
        public static Films GetFilm(string film)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("film");
            var foundedFilm = collection.Find(x => x.NameOfFilm == film).FirstOrDefault();
            return foundedFilm;
        }
        public static List<string> GetAllFilmList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            var listFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listFromDB)
            {
                listToReturn.Add(item.NameOfFilm);
            }
            return listToReturn;
        }
        public static List<string> SearchFilm(string nameOfFilm)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            var listFromDB = collection.Find(x => x.NameOfFilm == nameOfFilm).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listFromDB)
            {
                listToReturn.Add(item.NameOfFilm);
            }
            return listToReturn;
        }
        public static List<string> SearchJanrFilm(string nameJanr)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            var listFromDB = collection.Find(x => x.Janr == nameJanr).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listFromDB)
            {
                listToReturn.Add(item.NameOfFilm);
            }
            return listToReturn;
        }
        public static void EditFilm(string nameOfFilm, string review, string newnameOfFilm)
        {
            var std = new MongoClient("mongodb://localhost");
            var database = std.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            var updateName = Builders<Films>.Update.Set(f => f.NameOfFilm, newnameOfFilm);
            var updateReview = Builders<Films>.Update.Set(f => f.Review, review);
            collection.UpdateOne(x => x.NameOfFilm == nameOfFilm, updateName);
            collection.UpdateOne(x => x.NameOfFilm == nameOfFilm, updateReview);
        }
        public static async void DeleteFilm(string nameOfFilm)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            var result = await collection.DeleteOneAsync(p => p.NameOfFilm == nameOfFilm);
        }
        public static void AddReview(Review review)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Review>("Review");
            collection.InsertOne(review);
        }
        public static User UserIsExists(string email, string password)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<User>("Users");
            return collection.Find(x => x.Email == email && x.Password == password).FirstOrDefault();
        }        
    }
}
