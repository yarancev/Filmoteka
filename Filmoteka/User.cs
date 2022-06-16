using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmoteka
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string Name;

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string Email;

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string Password;

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string Number;

        //public static string logpass;
        //public static string logemail;

        public User(string name, string number, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Number = number;
        }
    }
}
