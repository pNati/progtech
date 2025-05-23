using Microsoft.EntityFrameworkCore;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sandwich> Sandwiches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Itt az SQLite adatb�zis hely�t �s nev�t
            options.UseSqlite("Data Source=wpfburgerapp.db");
        }
    }
}
