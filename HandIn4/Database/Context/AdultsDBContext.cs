using HandIn4.Models;
using Microsoft.EntityFrameworkCore;

namespace HandIn4.Database.Context
{
    public class AdultsDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Adult> Adults { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite(@"Data Source = F:\UNIVERSITY\Semester 3\DNT\HandIn4\HandIn4\Adults.db");
        }
        
    }
}