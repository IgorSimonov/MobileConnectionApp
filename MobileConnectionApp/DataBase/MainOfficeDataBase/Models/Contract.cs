#nullable enable
using System;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Contract
    {
        public Contract(int clientId, int numberId, int simId, int tarifId, DateTime dateCreate, DateTime? dateLastUpdate, int price)
        {
            ClientId = clientId;
            NumberId = numberId;
            SimId = simId;
            TarifId = tarifId;
            DateCreate = dateCreate;
            DateLastUpdate = dateLastUpdate;
            Price = price;
        }

        public int Id { get; set; }
        public int ClientId {get; set; }  
        public Client? Client { get; set; }
        public int NumberId { get; set; }
        public Number? Number { get; set; }
        public int SimId { get; set; }
        public Sim? Sim { get; set; }
        public int TarifId { get; set; }
        public Tarif? Tarif { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateLastUpdate { get; set; }
        public int Price { get; set; }
    }
}