#nullable enable
namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Number
    {
        public int Id { get; set; }
        public string? Phone { get; set; }
        public int StateId { get; set; }
        public State? State { get; set; }
        public int PrestigeNumberId { get; set; }
        public PrestigeNumber? PrestigeNumber { get; set; }
    }
}