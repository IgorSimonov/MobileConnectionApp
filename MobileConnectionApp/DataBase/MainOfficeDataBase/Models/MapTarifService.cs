#nullable enable
namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class MapTarifService
    {
        public int Id { get; set; }
        public int TarifId { get; set; }
        public Tarif? Tarif { get; set; }
        public int ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}