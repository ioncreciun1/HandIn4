using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;

namespace HandIn_3.Models
{
    public class User
    {
        public ObjectId _id { get; set; }
        
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}