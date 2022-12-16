using Microsoft.EntityFrameworkCore;
using MobileConnectionApp.DataBase.PeterburgOfficeDataBase.Models;

namespace MobileConnectionApp.DataBase.PeterburgOfficeDataBase
{
    public class PeterburgOfficeContext: DbContext
    {
        public DbSet<Sim> Sims { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5202;Database=PeterburgOffice;Username=igor;Password=dota2");
        }
    }
}