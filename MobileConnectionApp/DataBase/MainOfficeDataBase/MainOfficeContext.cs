using Microsoft.EntityFrameworkCore;
using MobileConnectionApp.DataBase.MainOfficeDataBase.Models;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase
{
    public class MainOfficeContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5200;Database=MainOffice;Username=igor;Password=dota2");
        }
    }
}