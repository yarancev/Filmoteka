using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmoteka
{
    public class Review
    {
        public Review(Films films, User user, string comment)
        {
            Films = films;
            User = user;
            Comment = comment;
        }
        public Films Films { get; set; }
        public User User { get; set; }
        public string Comment { get; set; }
    }
}
