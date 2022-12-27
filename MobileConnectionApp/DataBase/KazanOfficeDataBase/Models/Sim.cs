#nullable enable
namespace MobileConnectionApp.DataBase.KazanOfficeDataBase.Models
{
    public class Sim
    {
        public Sim(string? number, int stateId)
        {
            Number = number;
            StateId = stateId;
        }

        public int Id { get; set; }
        public string? Number { get; set; }
        public int StateId { get; set; }
    }
}