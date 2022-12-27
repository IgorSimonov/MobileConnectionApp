using MobileConnectionApp.DataBase.KazanOfficeDataBase;
using MobileConnectionApp.DataBase.MainOfficeDataBase;
using MobileConnectionApp.DataBase.PeterburgOfficeDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MobileConnectionApp.SaleForms
{
    public partial class AddContractForm : Form
    {
        private MainOfficeContext _mainOfficeContext;
        private int? _id;

        public AddContractForm(MainOfficeContext mainOfficeContext, int? id = null)
        {
            InitializeComponent();
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var contract = _mainOfficeContext.Contracts.FirstOrDefault(x => x.Id == _id);

                var client = _mainOfficeContext.Clients.FirstOrDefault(x=> x.Id == contract.ClientId);
                var number = _mainOfficeContext.Numbers.FirstOrDefault(x => x.Id == contract.NumberId);
                var tarif = _mainOfficeContext.Tarifs.FirstOrDefault(x => x.Id == contract.TarifId);
                var sim = _mainOfficeContext.Sims.FirstOrDefault(x => x.Id == contract.SimId);

                clientBox.Text = $"{client.Surname} {client.Name} {client.Patronymic}";
                numberBox.Text = number.Phone;
                tarifBox.Text = tarif.Name;
                simBox.Text = sim.Number;
                priceText.Text = contract.Price.ToString();

                addClient.Text = "Изменить";
            }
        }

        public AddContractForm()
        {
            InitializeComponent();
        }

        private void AddContractForm_Load(object sender, EventArgs e)
        {
            var clients = _mainOfficeContext.Clients.ToList();

            var numbers = _mainOfficeContext.Numbers.Where(x => x.StateId == 3).ToList();
            var tarifs = _mainOfficeContext.Tarifs.ToList();
            var sims = _mainOfficeContext.Sims.Where(x => x.StateId == 3).ToList();

            foreach (var client in clients)
            {
                clientBox.Items.Add($"{client.Surname} {client.Name} {client.Patronymic}");
            }
            
            foreach (var num in numbers)
            {
                numberBox.Items.Add(num.Phone);
            }

             foreach (var tarif in tarifs)
            {
                tarifBox.Items.Add(tarif.Name);
            }

             foreach (var sim in sims)
            {
                simBox.Items.Add(sim.Number);
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            var fio = clientBox.Text.ToString().Split(' ');
            var client = _mainOfficeContext.Clients.Where(x => x.Surname == fio[0] & x.Name == fio[1] & x.Patronymic == fio[2]).FirstOrDefault().Id;

            DataBase.MainOfficeDataBase.Models.Number Number;
            DataBase.MainOfficeDataBase.Models.Sim Sim; 
            DataBase.MainOfficeDataBase.Models.Tarif tarif;

            Sim = _mainOfficeContext.Sims.First(x => x.Number == simBox.Text.ToString());
            Number = _mainOfficeContext.Numbers.First(x => x.Phone == numberBox.Text.ToString());
            tarif = _mainOfficeContext.Tarifs.First(x => x.Name == tarifBox.Text.ToString());

            var presitgePrice = _mainOfficeContext.PrestigeNumbers.Where(x => x.Id == Number.PrestigeNumberId).FirstOrDefault().Price;

            var services = _mainOfficeContext.MapTarifServices.Where(x => x.TarifId == tarif.Id).ToList();

            int sumServ = 0;

            foreach (var ser in services)
            {
                sumServ += _mainOfficeContext.Services.Where(x => x.Id == ser.ServiceId).FirstOrDefault().Price;
            }

            if (_id != null)
            {
                var contract = _mainOfficeContext.Contracts.Where(x => x.Id == _id).FirstOrDefault();

                if (contract.NumberId != Number.Id | contract.TarifId == tarif.Id)
                {
                    var caller = _mainOfficeContext.Callers.Where(x => x.ContractId == contract.Id).FirstOrDefault();

                    var price = sumServ + presitgePrice;
                    caller.Balance -= price;

                    caller.DateLastPay = DateTime.Now;
                    caller.DateToPay = DateTime.Now.AddMonths(1);

                    _mainOfficeContext.Callers.Update(caller);
                }

                contract.NumberId = Number.Id;
                contract.SimId = Sim.Id;
                contract.ClientId = client;
                contract.TarifId = tarif.Id;
                contract.Price = sumServ + presitgePrice;
                contract.DateLastUpdate = DateTime.Now;

                _mainOfficeContext.Contracts.Update(contract);
            }
            else
            {
                client = _mainOfficeContext.Clients.Where(x => x.Surname == fio[0] & x.Name == fio[1] & x.Patronymic == fio[2]).FirstOrDefault().Id;
                var price = sumServ + presitgePrice;

                var contract = new DataBase.MainOfficeDataBase.Models.Contract(client, Number.Id, Sim.Id, tarif.Id, DateTime.Now, DateTime.Now, price);
                _mainOfficeContext.Contracts.Add(contract);
            }

            Sim.StateId = 2;
            Number.StateId = 2;

            _mainOfficeContext.Sims.Update(Sim);
            _mainOfficeContext.Numbers.Update(Number);
            _mainOfficeContext.SaveChanges();

            this.Close();
        }
    }
}
