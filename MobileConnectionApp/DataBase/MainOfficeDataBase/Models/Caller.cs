#nullable enable
using System;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Caller
    {
        public int Id { get; set; }
        public Contract? Contract { get; set; }
        public int Balance { get; set; }
        public DateTime DateLastPay { get; set; }
        public DateTime DateToPay { get; set; }
    }
}