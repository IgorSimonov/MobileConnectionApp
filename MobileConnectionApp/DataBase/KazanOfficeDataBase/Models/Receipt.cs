using System;

namespace MobileConnectionApp.DataBase.KazanOfficeDataBase.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Device Device { get; set; }
        public int Price { get; set; }
        public DateTime DateSale { get; set; }
    }
}