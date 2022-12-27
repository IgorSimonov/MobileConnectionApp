using Microsoft.EntityFrameworkCore;
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

namespace MobileConnectionApp.StockForms
{
    
    public partial class StockPhonesView : Form
    {
        private MainOfficeContext _mainOfficeContext;
        private KazanOfficeContext _kazanOfficeContext;
        private PeterburgOfficeContext _peterburgOfficeContext;
        private int _orderId;

        public StockPhonesView(MainOfficeContext mainOfficeContext, int orderId)
        {
            InitializeComponent();
            _mainOfficeContext = mainOfficeContext;
            _orderId = orderId;

            var device = mainOfficeContext.Devices.Include(y => y.TypeDevice).First(x => x.Id == _orderId);

            namePhone.Text = device.Name;
            phoneDisplay.Text = device.Display;
            colorPhone.Text = device.Color;
            pricePhone.Text = device.Price.ToString();
            ramPhone.Text = device.Ram.ToString();
            romPhone.Text = device.Rom.ToString();
            diagonalPhone.Text = device.DisplayDiagonal.ToString();
            TypeDevice.Text = device.TypeDevice.Name;
        }
        public StockPhonesView(KazanOfficeContext kazanOfficeContext, int orderId)
        {
            InitializeComponent();
            _kazanOfficeContext = kazanOfficeContext;
            _orderId=orderId;

            var device = kazanOfficeContext.Devices.First(x => x.Id == _orderId);

            namePhone.Text = device.Name;
            phoneDisplay.Text = device.Display;
            colorPhone.Text = device.Color;
            pricePhone.Text = device.Price.ToString();
            ramPhone.Text = device.Ram.ToString();
            romPhone.Text = device.Rom.ToString();
            diagonalPhone.Text = device.DisplayDiagonal.ToString();
        }
        public StockPhonesView(PeterburgOfficeContext peterburgOfficeContext, int orderId)
        {
            InitializeComponent();
            _peterburgOfficeContext = peterburgOfficeContext;
            _orderId = orderId;

            var device = peterburgOfficeContext.Devices.First(x => x.Id == _orderId);

            namePhone.Text = device.Name;
            phoneDisplay.Text = device.Display;
            colorPhone.Text = device.Color;
            pricePhone.Text = device.Price.ToString();
            ramPhone.Text = device.Ram.ToString();
            romPhone.Text = device.Rom.ToString();
            diagonalPhone.Text = device.DisplayDiagonal.ToString();
        }

        private void StockPhonesView_Load(object sender, EventArgs e)
        {
        }
    }
}
