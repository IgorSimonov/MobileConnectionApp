#nullable enable

using MobileConnectionApp.DataBase.MainOfficeDataBase.Models;

namespace MobileConnectionApp.DataBase.PeterburgOfficeDataBase.Models
{
    public class Device
    {
        public Device(string? name, string? display, string? displayDiagonal, string? ram, string? rom, string? color, int price, int typeDeviceId)
        {
            Name = name;
            Display = display;
            DisplayDiagonal = displayDiagonal;
            Ram = ram;
            Rom = rom;
            Color = color;
            Price = price;
            TypeDeviceId = typeDeviceId;
        }

        public Device(int? id, string? name, string? display, string? displayDiagonal, string? ram, string? rom, string? color, int price, int typeDeviceId)
        {
            Id = id;
            Name = name;
            Display = display;
            DisplayDiagonal = displayDiagonal;
            Ram = ram;
            Rom = rom;
            Color = color;
            Price = price;
            TypeDeviceId = typeDeviceId;
        }
        public Device()
        {

        }

        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Display { get; set; }
        public string? DisplayDiagonal { get; set; }
        public string? Ram { get; set; }
        public string? Rom { get; set; }
        public string? Color { get; set; }
        public int Price { get; set; }
        public int StateId { get; set; }
        public int TypeDeviceId { get; set; }
        public TypeDevice? TypeDevice { get; set; }
    }
}