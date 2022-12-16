using System;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Device Device { get; set; }
        public int Price { get; set; }
        public Location Location { get; set; }
        public DateTime DateSale { get; set; }
    }
}