using System;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Receipt
    {
        public Receipt(int clientId, int deviceId, DateTime dateSale, int price)
        {
            ClientId = clientId;
            DeviceId = deviceId;
            DateSale = dateSale;
            Price = price;
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public DateTime DateSale { get; set; }
        public int Price { get; set; }
    }
}