using MobileConnectionApp.DataBase.MainOfficeDataBase;
using MobileConnectionApp.DataBase.MainOfficeDataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace MobileConnectionApp.SaleForms
{
    public partial class AddCallersForm : Form
    {
        private MainOfficeContext _mainOfficeContext;
        private int? _id;

        public AddCallersForm(MainOfficeContext mainOfficeContext, int? id = null)
        {
            InitializeComponent();
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var caller = _mainOfficeContext.Callers.FirstOrDefault(x => x.Id == _id);
                var contract = _mainOfficeContext.Contracts.Where(x => x.Id == caller.ContractId).FirstOrDefault();
                var client = _mainOfficeContext.Clients.Where(x => x.Id == contract.ClientId).FirstOrDefault();

                clientBox.Text = $"{client.Surname} {client.Name} {client.Patronymic}";
                balanceText.Text = caller.Balance.ToString();
                addClient.Text = "Изменить";
            }
        }

        private void addSeriaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCallersForm_Load(object sender, EventArgs e)
        {
            var clients = _mainOfficeContext.Clients.ToList();
            var contracts = _mainOfficeContext.Contracts.ToList();
            var callers = _mainOfficeContext.Callers.ToList();

            List<Contract> Contracts = new List<Contract>();

            foreach (var cont in contracts)
            {
                if (callers.Where(x => x.ContractId == cont.Id).Count() == 0)
                {
                    Contracts.Add(cont);
                }
            }

            List<Client> Clients = new List<Client>();

            foreach (var client in clients)
            {
                if (Contracts.Where(x => x.ClientId == client.Id).Count() == 1)
                {
                    Clients.Add(client);
                }
            }

            foreach (var client in Clients)
            {
                clientBox.Items.Add($"{client.Surname} {client.Name} {client.Patronymic}");
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            var fio = clientBox.Text.ToString().Split(' ');
            var client = _mainOfficeContext.Clients.Where(x => x.Surname == fio[0] & x.Name == fio[1] & x.Patronymic == fio[2]).FirstOrDefault();

            DataBase.MainOfficeDataBase.Models.Caller Caller;

            if (_id != null)
            {
                clientBox.Enabled = false;

                Caller = _mainOfficeContext.Callers.First(x => x.Id == _id);
                Caller.Balance = Convert.ToInt32(balanceText.Text);

                _mainOfficeContext.Callers.Update(Caller);
            }
            else
            {
                var contract = _mainOfficeContext.Contracts.Where(x => x.ClientId == client.Id).First();

                Caller = new DataBase.MainOfficeDataBase.Models.Caller(contract.Id, Convert.ToInt32(balanceText.Text), DateTime.Now, DateTime.Now.AddMonths(1));

                var number = _mainOfficeContext.Numbers.Where(x => x.Id == contract.NumberId).First();

                var presitgePrice = _mainOfficeContext.PrestigeNumbers.Where(x => x.Id == number.PrestigeNumberId).FirstOrDefault().Price;

                var services = _mainOfficeContext.MapTarifServices.Where(x => x.TarifId == contract.TarifId).ToList();

                int sumServ = 0;

                foreach (var ser in services)
                {
                    sumServ += _mainOfficeContext.Services.Where(x => x.Id == ser.ServiceId).FirstOrDefault().Price;
                }

                Caller.Balance = presitgePrice - sumServ;

                _mainOfficeContext.Callers.Add(Caller);
            }

            _mainOfficeContext.SaveChanges();

            this.Close();
        }
    }
}
