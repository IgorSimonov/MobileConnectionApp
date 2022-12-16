#nullable enable
namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Sim
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public Location? Location { get; set; }
        public State? State { get; set; }
    }
}