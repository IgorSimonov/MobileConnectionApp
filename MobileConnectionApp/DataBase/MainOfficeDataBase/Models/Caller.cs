#nullable enable
using System;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class Caller
    {
        public Caller(int? contractId, int balance, DateTime? dateLastPay, DateTime? dateToPay)
        {
            ContractId = contractId;
            Balance = balance;
            DateLastPay = dateLastPay;
            DateToPay = dateToPay;
        }

        public int Id { get; set; }
        public int? ContractId { get; set; }
        public Contract? Contract { get; set; }
        public int Balance { get; set; }
        public DateTime? DateLastPay { get; set; }
        public DateTime? DateToPay { get; set; }
    }
}