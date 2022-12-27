using Microsoft.EntityFrameworkCore;
using MobileConnectionApp.DataBase.KazanOfficeDataBase.Models;

namespace MobileConnectionApp.DataBase.KazanOfficeDataBase
{
    public class KazanOfficeContext: DbContext
    {
        public DbSet<Sim> Sims { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<TypeDeivce> TypeDevices { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5201;Database=KazanOffice;Username=igor;Password=dota2");
        }
    }
}