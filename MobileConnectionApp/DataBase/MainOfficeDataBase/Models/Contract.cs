#nullable enable
using System;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public Client? Client { get; set; }
        public Number? Number { get; set; }
        public Sim? Sim { get; set; }
        public Tarif? Tarif { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public Location? Location { get; set; }
        public int Price { get; set; }
    }
}