using Microsoft.EntityFrameworkCore;
using MobileConnectionApp.DataBase.KazanOfficeDataBase.Models;

namespace MobileConnectionApp.DataBase.KazanOfficeDataBase
{
    public class KazanOfficeContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5201;Database=KazanOffice;Username=igor;Password=dota2");
        }
    }
}