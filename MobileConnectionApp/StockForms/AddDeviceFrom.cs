using Microsoft.EntityFrameworkCore;
using MobileConnectionApp.DataBase.KazanOfficeDataBase;
using MobileConnectionApp.DataBase.KazanOfficeDataBase.Models;
using MobileConnectionApp.DataBase.MainOfficeDataBase;
using MobileConnectionApp.DataBase.MainOfficeDataBase.Models;
using MobileConnectionApp.DataBase.PeterburgOfficeDataBase;
using MobileConnectionApp.DataBase.PeterburgOfficeDataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileConnectionApp.StockForms
{
    public partial class AddDeviceFrom : Form
    {
        private MainOfficeContext _mainOfficeContext;
        private KazanOfficeContext _kazanOfficeContext;
        private PeterburgOfficeContext _peterburgOfficeContext;
        private int? _id;

        public AddDeviceFrom(MainOfficeContext mainOfficeContext, int? id =null)
        {
            InitializeComponent();
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = _mainOfficeContext.Devices.First(x => x.Id == _id);
                var name = mainOfficeContext.TypeDevices.Where(x => x.Id == device.TypeDevice.Id).FirstOrDefault().Name;

                addColorDeviceTextBox.Text = device.Color;
                addDiagonalDeviceTextBox.Text = device.Color;
                addDisplayDeviceTextBox.Text = device.Display;
                addNameDeviceTextBox.Text = device.Name;
                addPriceDeviceTextBox.Text = device.Price.ToString();
                addRamDeviceTextBox.Text = device.Ram;
                addRomDeviceTextBox.Text = device.Rom;
                comboBox1.Text = name;
                addDeviceBtn.Text = "Изменить";
            }
        }
        public AddDeviceFrom(MainOfficeContext mainOfficeContext, KazanOfficeContext kazanOfficeContext, int? id=null)
        {
            InitializeComponent();
            _kazanOfficeContext = kazanOfficeContext;
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = _kazanOfficeContext.Devices.First(x => x.Id == _id);

                var name = mainOfficeContext.TypeDevices.Where(x => x.Id == device.TypeDevice.Id).FirstOrDefault().Name;

                addColorDeviceTextBox.Text = device.Color;
                addDiagonalDeviceTextBox.Text = device.Color;
                addDisplayDeviceTextBox.Text = device.Display;
                addNameDeviceTextBox.Text = device.Name;
                addPriceDeviceTextBox.Text = device.Price.ToString();
                addRamDeviceTextBox.Text = device.Ram;
                addRomDeviceTextBox.Text = device.Rom;
                comboBox1.Text = name;
                addDeviceBtn.Text = "Изменить";

            }
        }
        public AddDeviceFrom(MainOfficeContext mainOfficeContext, PeterburgOfficeContext peterburgOfficeContext, int? id = null)
        {
            InitializeComponent();
            _peterburgOfficeContext = peterburgOfficeContext;
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = _peterburgOfficeContext.Devices.First(x => x.Id == _id);

                var name = mainOfficeContext.TypeDevices.Where(x => x.Id == device.TypeDevice.Id).FirstOrDefault().Name;

                addColorDeviceTextBox.Text = device.Color;
                addDiagonalDeviceTextBox.Text = device.Color;
                addDisplayDeviceTextBox.Text = device.Display;
                addNameDeviceTextBox.Text = device.Name;
                addPriceDeviceTextBox.Text = device.Price.ToString();
                addRamDeviceTextBox.Text = device.Ram;
                addRomDeviceTextBox.Text = device.Rom;
                comboBox1.Text = name;
                addDeviceBtn.Text = "Изменить";

            }
        }

        private void AddDeviceFrom_Load(object sender, EventArgs e)
        {
            var devices = _mainOfficeContext.TypeDevices.ToList();

            foreach (var device in devices)
            {
                comboBox1.Items.Add(device.Name);
            }
        }

        private void addDeviceBtn_Click(object sender, EventArgs e)
        {
            var id = _mainOfficeContext.TypeDevices.Where(x=>x.Name ==  comboBox1.Text.ToString()).FirstOrDefault().Id;

            if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
            {
                DataBase.MainOfficeDataBase.Models.Device device;

                if (_id != null)
                {
                    device = _mainOfficeContext.Devices.First(x => x.Id == _id);

                    device.Name = addNameDeviceTextBox?.Text;
                    device.Price = Convert.ToInt32(addPriceDeviceTextBox.Text);
                    device.TypeDeviceId = id;
                    device.Color= addColorDeviceTextBox?.Text;
                    device.Display = addDisplayDeviceTextBox?.Text;
                    device.DisplayDiagonal = addDiagonalDeviceTextBox?.Text;
                    device.Ram = addRamDeviceTextBox?.Text;
                    device.Rom = addRomDeviceTextBox?.Text;

                    _mainOfficeContext.Devices.Update(device);
                }
                else
                {
                    device = new DataBase.MainOfficeDataBase.Models.Device(addNameDeviceTextBox?.Text, addDisplayDeviceTextBox?.Text, addDiagonalDeviceTextBox?.Text, addRamDeviceTextBox?.Text, addRomDeviceTextBox?.Text, addColorDeviceTextBox?.Text, Convert.ToInt32(addPriceDeviceTextBox.Text), id);
                    _mainOfficeContext.Devices.Add(device);
                }

                _mainOfficeContext.SaveChanges();
            }
            else
            {
                if (_kazanOfficeContext == null)
                {
                    DataBase.PeterburgOfficeDataBase.Models.Device device;

                    if (_id != null)
                    {
                        device = _peterburgOfficeContext.Devices.First(x => x.Id == _id);

                        device.Name = addNameDeviceTextBox?.Text;
                        device.Price = Convert.ToInt32(addPriceDeviceTextBox.Text);
                        device.TypeDeviceId = id;
                        device.Color = addColorDeviceTextBox?.Text;
                        device.Display = addDisplayDeviceTextBox?.Text;
                        device.DisplayDiagonal = addDiagonalDeviceTextBox?.Text;
                        device.Ram = addRamDeviceTextBox?.Text;
                        device.Rom = addRomDeviceTextBox?.Text;

                        _peterburgOfficeContext.Devices.Update(device);
                    }
                    else
                    {
                        device = new DataBase.PeterburgOfficeDataBase.Models.Device(addNameDeviceTextBox?.Text, addDisplayDeviceTextBox?.Text, addDiagonalDeviceTextBox?.Text, addRamDeviceTextBox?.Text, addRomDeviceTextBox?.Text, addColorDeviceTextBox?.Text, Convert.ToInt32(addPriceDeviceTextBox.Text), id);
                        _peterburgOfficeContext.Devices.Add(device);
                    }

                    _peterburgOfficeContext.SaveChanges();
                }
                else
                {
                    DataBase.KazanOfficeDataBase.Models.Device device;

                    if (_id != null)
                    {
                        device = _kazanOfficeContext.Devices.First(x => x.Id == _id);

                        device.Name = addNameDeviceTextBox?.Text;
                        device.Price = Convert.ToInt32(addPriceDeviceTextBox.Text);
                        device.TypeDeviceId = id;
                        device.Color = addColorDeviceTextBox?.Text;
                        device.Display = addDisplayDeviceTextBox?.Text;
                        device.DisplayDiagonal = addDiagonalDeviceTextBox?.Text;
                        device.Ram = addRamDeviceTextBox?.Text;
                        device.Rom = addRomDeviceTextBox?.Text;

                        _kazanOfficeContext.Devices.Update(device);
                    }
                    else
                    {
                        device = new DataBase.KazanOfficeDataBase.Models.Device(addNameDeviceTextBox?.Text, addDisplayDeviceTextBox?.Text, addDiagonalDeviceTextBox?.Text, addRamDeviceTextBox?.Text, addRomDeviceTextBox?.Text, addColorDeviceTextBox?.Text, Convert.ToInt32(addPriceDeviceTextBox.Text), id);
                        _kazanOfficeContext.Devices.Add(device);
                    }

                    _kazanOfficeContext.SaveChanges();
                }
            }

            this.Close();
        }
    }
}
