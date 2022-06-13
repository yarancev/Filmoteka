using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmoteka
{
    class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string name;      

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string email;

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string password;

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string number;

        public static string logpass;
        public static string logemail;

        public User(string name, string number, string email, string password)
        {
            this.name = name;            
            this.email = email;
            this.password = password;
            this.number = number;
        }
    }
}
