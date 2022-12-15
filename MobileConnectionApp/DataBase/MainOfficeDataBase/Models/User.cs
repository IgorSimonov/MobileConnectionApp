#nullable enable
using System;

namespace MobileConnectionApp.DataBase.MainOfficeDataBase.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public string? Patronymicf { get; set; }
    }
}