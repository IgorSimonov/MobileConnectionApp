#nullable enable
using System;

namespace MobileConnectionApp.DataBase.KazanOfficeDataBase.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int NumberId { get; set; }
        public Sim? Sim { get; set; }
        public int TarifId { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public int Price { get; set; }
    }
}