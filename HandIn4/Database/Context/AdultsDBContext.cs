using HandIn4.Models;
using Microsoft.EntityFrameworkCore;

namespace HandIn4.Database
{
    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite("Data Source = Users.db");
        }
        
    }
}