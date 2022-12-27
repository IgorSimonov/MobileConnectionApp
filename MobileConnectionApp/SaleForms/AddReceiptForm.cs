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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileConnectionApp.SaleForms
{
    public partial class AddReceiptForm : Form
    {
        private MainOfficeContext _mainOfficeContext;
        private KazanOfficeContext _kazanOfficeContext;
        private PeterburgOfficeContext _peterburgOfficeContext;
        private int? _id;

        public AddReceiptForm(MainOfficeContext mainOfficeContext, int? id = null)
        {
            InitializeComponent();
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var receipt = _mainOfficeContext.Receipts.First(x => x.Id == _id);
                var name = mainOfficeContext.Devices.Where(x => x.Id == receipt.Device.Id).FirstOrDefault().Name;
                var name1 = mainOfficeContext.Clients.Where(x => x.Id == receipt.Client.Id).FirstOrDefault();

                clientBox.Text = $"{name1.Surname} {name1.Name} {name1.Patronymic}"; 
                deviceBox.Text = name;
                priceText.Text = receipt.Price.ToString();
                dateTimePicker1.Text = receipt.DateSale.ToShortDateString();

                addDeviceBtn.Text = "Изменить";
            }
        }
        public AddReceiptForm(MainOfficeContext mainOfficeContext, KazanOfficeContext kazanOfficeContext, int? id = null)
        {
            InitializeComponent();
            _kazanOfficeContext = kazanOfficeContext;
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = kazanOfficeContext.Receipts.First(x => x.Id == _id);
                var name = kazanOfficeContext.Devices.Where(x => x.Id == device.Device.Id).FirstOrDefault().Name;
                var name1 = mainOfficeContext.Clients.Where(x => x.Id == device.ClientId).FirstOrDefault();

                clientBox.Text = $"{name1.Surname} {name1.Name} {name1.Patronymic}";
                deviceBox.Text = name;
                priceText.Text = device.Price.ToString();
                dateTimePicker1.Text = device.DateSale.ToShortDateString();

                addDeviceBtn.Text = "Изменить";
            }
        }
        public AddReceiptForm(MainOfficeContext mainOfficeContext, PeterburgOfficeContext peterburgOfficeContext, int? id = null)
        {
            InitializeComponent();
            _peterburgOfficeContext = peterburgOfficeContext;
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = peterburgOfficeContext.Receipts.First(x => x.Id == _id);
                var name = peterburgOfficeContext.Devices.Where(x => x.Id == device.Device.Id).FirstOrDefault().Name;
                var name1 = mainOfficeContext.Clients.Where(x => x.Id == device.ClientId).FirstOrDefault();

                clientBox.Text = $"{name1.Surname} {name1.Name} {name1.Patronymic}";
                deviceBox.Text = name;
                priceText.Text = device.Price.ToString();
                dateTimePicker1.Text = device.DateSale.ToShortDateString();

                addDeviceBtn.Text = "Изменить";
            }
        }

        private void addDeviceBtn_Click(object sender, EventArgs e)
        {
            var fio = clientBox.Text.ToString().Split(' ');
            var client = _mainOfficeContext.Clients.Where(x => x.Surname == fio[0] & x.Name == fio[1] & x.Patronymic == fio[2]).FirstOrDefault().Id;

            DataBase.MainOfficeDataBase.Models.Receipt Receipt;
            DataBase.MainOfficeDataBase.Models.Device Device; ;

            if (_id != null)
            {
                Device = _mainOfficeContext.Devices.First(x => x.Name == deviceBox.Text.ToString());
                var receipt = _mainOfficeContext.Receipts.Where(x => x.Id == _id).FirstOrDefault();

                receipt.DeviceId = Convert.ToInt32(Device.Id);
                receipt.Price = Convert.ToInt32(priceText.Text);
                receipt.Client.Id = client;

                _mainOfficeContext.Receipts.Update(receipt);
            }
            else
            {
                client = _mainOfficeContext.Clients.Where(x => x.Surname == fio[0] & x.Name == fio[1] & x.Patronymic == fio[2]).FirstOrDefault().Id;
                Device = _mainOfficeContext.Devices.First(x => x.Name == deviceBox.Text.ToString());

                Receipt = new DataBase.MainOfficeDataBase.Models.Receipt(client, Convert.ToInt32(Device.Id), dateTimePicker1.Value, Convert.ToInt32(priceText.Text));
                _mainOfficeContext.Receipts.Add(Receipt);
            }

            Device.StateId = 2;
            _mainOfficeContext.Devices.Update(Device);
            _mainOfficeContext.SaveChanges();
        
            this.Close();
        }

        private void AddReceiptForm_Load(object sender, EventArgs e)
        {
            var devices = _mainOfficeContext.Clients.ToList();

            foreach (var device in devices)
            {
                clientBox.Items.Add($"{device.Surname} {device.Name} {device.Patronymic}");
            }

            if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
            {
                var dev = _mainOfficeContext.Devices.Where(x=> x.State.Id == 3) .ToList();

                foreach (var device in dev)
                {
                    deviceBox.Items.Add($"{device.Name}");
                }
            }
            else
            {
                if(_kazanOfficeContext == null)
                {
                    var dev = _peterburgOfficeContext.Devices.Where(x => x.StateId == 3).ToList();

                    foreach (var device in dev)
                    {
                        deviceBox.Items.Add($"{device.Name}");
                    }
                }
                else
                {
                    var dev = _kazanOfficeContext.Devices.Where(x => x.StateId == 3).ToList();

                    foreach (var device in dev)
                    {
                        deviceBox.Items.Add($"{device.Name}");
                    }
                }
            }
        }
    }
}
