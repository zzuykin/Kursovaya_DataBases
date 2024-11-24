
using Kursobaya.Storage.Models;
using Microsoft.EntityFrameworkCore;

namespace Kursobaya.Storage.DataBase
{
    public class MyDbContext : DbContext
    {
        public DbSet<Unit> Units { get; set; }

        public DbSet<Detail> Details { get; set; }

        public DbSet<Reliability> Reliabilitys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Kursovaya;Username=postgres;Password=1234");
        }
    }
}
