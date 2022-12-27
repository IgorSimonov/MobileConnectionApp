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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileConnectionApp.SaleForms
{
    public partial class AddClientForm : Form
    {
        private MainOfficeContext _mainOfficeContext;
        private int? _id;

        public AddClientForm(MainOfficeContext mainOfficeContext, int? id = null)
        {
            InitializeComponent();
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = _mainOfficeContext.Clients.First(x => x.Id == _id);
                
                addNameTextBox.Text = device.Name;
                addSurnameTextBox.Text = device.Surname;
                addPatronymicTextBox.Text = device.Patronymic;
                addSeriaTextBox.Text = device.PassportSeria.ToString();
                addNumberTextBox.Text = device.PassportNumber.ToString();
                addClient.Text = "Изменить";
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            DataBase.MainOfficeDataBase.Models.Client device;

            if (_id != null)
            {
                device = _mainOfficeContext.Clients.First(x => x.Id == _id);

                device.Name = addNameTextBox.Text;
                device.Surname = addSurnameTextBox.Text;
                device.Patronymic = addPatronymicTextBox.Text;
                device.PassportSeria = Convert.ToInt32(addSeriaTextBox.Text);
                device.PassportNumber = Convert.ToInt32(addNumberTextBox.Text);

                _mainOfficeContext.Clients.Update(device);
            }
            else
            {
                device = new DataBase.MainOfficeDataBase.Models.Client(addNameTextBox.Text,addSurnameTextBox.Text, addPatronymicTextBox.Text, Convert.ToInt32(addSeriaTextBox.Text), Convert.ToInt32(addNumberTextBox.Text));
                _mainOfficeContext.Clients.Add(device);
            }

            _mainOfficeContext.SaveChanges();

            this.Close();
        }
    }
}
