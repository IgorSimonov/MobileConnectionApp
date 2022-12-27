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

namespace MobileConnectionApp.StockForms
{
    public partial class ChangeSimForm : Form
    {
        private MainOfficeContext _mainOfficeContext;
        private KazanOfficeContext _kazanOfficeContext;
        private PeterburgOfficeContext _peterburgOfficeContext;
        private int? _id;

        public ChangeSimForm(MainOfficeContext mainOfficeContext, int? id = null)
        {
            InitializeComponent();
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = _mainOfficeContext.Sims.First(x => x.Id == _id);
                var name = mainOfficeContext.States.Where(x => x.Id == device.StateId).FirstOrDefault().Name;

                simNumberTextBox.Text = device.Number;
                changeSimBox.Text = name;
                addSimBtn.Text = "Изменить";
            }
        }
        public ChangeSimForm(MainOfficeContext mainOfficeContext, KazanOfficeContext kazanOfficeContext, int? id = null)
        {
            InitializeComponent();
            _kazanOfficeContext = kazanOfficeContext;
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = _kazanOfficeContext.Sims.First(x => x.Id == _id);

                var name = mainOfficeContext.States.Where(x => x.Id == device.StateId).FirstOrDefault().Name;

                simNumberTextBox.Text = device.Number;
                changeSimBox.Text = name;
                addSimBtn.Text = "Изменить";
            }
        }
        public ChangeSimForm(MainOfficeContext mainOfficeContext, PeterburgOfficeContext peterburgOfficeContext, int? id = null)
        {
            InitializeComponent();
            _peterburgOfficeContext = peterburgOfficeContext;
            _mainOfficeContext = mainOfficeContext;
            _id = id;

            if (_id != null)
            {
                var device = _peterburgOfficeContext.Sims.First(x => x.Id == _id);
                var name = mainOfficeContext.States.Where(x => x.Id == device.StateId).FirstOrDefault().Name;

                simNumberTextBox.Text = device.Number;
                changeSimBox.Text = name;
                addSimBtn.Text = "Изменить";
            }
        }

        public ChangeSimForm()
        {
            InitializeComponent();
        }

        private void ChangeSimForm_Load(object sender, EventArgs e)
        {
            var devices = _mainOfficeContext.States.ToList();

            foreach (var device in devices)
            {
                changeSimBox.Items.Add(device.Name);
            }
        }

        private void addSimBtn_Click(object sender, EventArgs e)
        {
            var id = _mainOfficeContext.States.Where(x => x.Name == changeSimBox.Text.ToString()).FirstOrDefault().Id;

            if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
            {
                DataBase.MainOfficeDataBase.Models.Sim device;

                if (_id != null)
                {
                    device = _mainOfficeContext.Sims.First(x => x.Id == _id);

                    device.Number = simNumberTextBox.Text;
                    device.StateId = id;

                    _mainOfficeContext.Sims.Update(device);
                }
                else
                {
                    device = new DataBase.MainOfficeDataBase.Models.Sim(simNumberTextBox.Text, id);
                    _mainOfficeContext.Sims.Add(device);
                }

                _mainOfficeContext.SaveChanges();
            }
            else
            {
                if (_kazanOfficeContext == null)
                {
                    DataBase.PeterburgOfficeDataBase.Models.Sim device;

                    if (_id != null)
                    {
                        device = _peterburgOfficeContext.Sims.First(x => x.Id == _id);


                        device.Number = simNumberTextBox.Text;
                        device.StateId = id;

                        _peterburgOfficeContext.Sims.Update(device);
                    }
                    else
                    {
                        device = new DataBase.PeterburgOfficeDataBase.Models.Sim(simNumberTextBox.Text, id);
                        _peterburgOfficeContext.Sims.Add(device);
                    }

                    _peterburgOfficeContext.SaveChanges();
                }
                else
                {
                    DataBase.KazanOfficeDataBase.Models.Sim device;

                    if (_id != null)
                    {
                        device = _kazanOfficeContext.Sims.First(x => x.Id == _id);

                        device.Number = simNumberTextBox.Text;
                        device.StateId = id;

                        _kazanOfficeContext.Sims.Update(device);
                    }
                    else
                    {
                        device = new DataBase.KazanOfficeDataBase.Models.Sim(simNumberTextBox.Text, id);
                        _kazanOfficeContext.Sims.Add(device);
                    }

                    _kazanOfficeContext.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
