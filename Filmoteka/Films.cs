using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using System.Windows.Media;
using System.Windows;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Filmoteka
{
    public class Films
    {
        Queue<string> links = new Queue<string>();
        public Films(string nameOfFilm, double rating, string review, string janr, int year, string rejiser, string image)
        {
            NameOfFilm = nameOfFilm;
            Rating = rating;
            Review = review;
            Janr = janr;
            Year = year;
            Rejiser = rejiser;
            Image = image;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [BsonIgnoreIfDefault]
        public string NameOfFilm  { get; set; }
        [BsonIgnoreIfDefault]
        public double Rating { get; set; }
        [BsonIgnoreIfDefault]
        public string Review { get; set; }
        [BsonIgnoreIfDefault]
        public string Janr { get; set; }
        [BsonIgnoreIfDefault]
        public int Year { get; set; }
        [BsonIgnoreIfDefault]
        public string Image { get; set; }
        public string Rejiser { get; set; }        
    }
}
