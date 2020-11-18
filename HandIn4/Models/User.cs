using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MongoDB.Bson;

namespace HandIn4.Models
{
    public class User
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [Required]
        [JsonPropertyName("UserName")]
        public string UserName { get; set; }
        [Required,MinLength(6)]
        [JsonPropertyName("Password")]
        public string Password { get; set; }
    }
}