#nullable enable
namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public int PassportSeria { get; set; }
        public int PassportNumber { get; set; }
        public Location? Location { get; set; }
    }
}