using Microsoft.EntityFrameworkCore;
using MobileConnectionApp.DataBase.MainOfficeDataBase.Models;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase
{
    public class MainOfficeContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<MapTarifService> MapTarifServices { get; set; } = null!;
        public DbSet<Number> Numbers { get; set; } = null!;
        public DbSet<PrestigeNumber> PrestigeNumbers { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<Sim> Sims { get; set; } = null!;
        public DbSet<State> States { get; set; } = null!;
        public DbSet<Tarif> Tarifs { get; set; } = null!;
        public DbSet<Caller> Callers { get; set; } = null!;
        public DbSet<Contract> Contracts { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Device> Devices { get; set; } = null!;
        public DbSet<TypeDevice> TypeDevices { get; set; } = null!;
        public DbSet<Receipt> Receipts { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5200;Database=MainOffice;Username=igor;Password=dota2");
        }
    }
}