using Microsoft.EntityFrameworkCore;

namespace MobileConnectionApp.DataBase.PeterburgOfficeDataBase
{
    public class PeterburgOfficeContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5202;Database=MainOffice;Username=igor;Password=dota2");
        }
    }
}