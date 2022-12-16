#nullable enable
namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class MapTarifService
    {
        public int Id { get; set; }
        public Tarif? Tarif { get; set; }
        public Service? Service { get; set; }
    }
}