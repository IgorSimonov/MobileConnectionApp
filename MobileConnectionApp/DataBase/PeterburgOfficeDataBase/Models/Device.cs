#nullable enable

namespace MobileConnectionApp.DataBase.PeterburgOfficeDataBase.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Display { get; set; }
        public string? DisplayDiagonal { get; set; }
        public string? Ram { get; set; }
        public string? Rom { get; set; }
        public string? Color { get; set; }
        public int Price { get; set; }
        public int TypeDeviceId { get; set; }
    }
}