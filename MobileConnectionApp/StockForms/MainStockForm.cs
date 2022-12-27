using MobileConnectionApp.DataBase.KazanOfficeDataBase;
using MobileConnectionApp.DataBase.MainOfficeDataBase;
using MobileConnectionApp.DataBase.MainOfficeDataBase.Models;
using MobileConnectionApp.DataBase.PeterburgOfficeDataBase;
using MobileConnectionApp.StockForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileConnectionApp
{
    public partial class MainStockForm : Form
    {
        private User _user;
        private MainOfficeContext _mainOfficeContext;
        private KazanOfficeContext _kazanOfficeContext;
        private PeterburgOfficeContext _peterburgOfficeContext;

        public MainStockForm(User user, MainOfficeContext mainOfficeContext)
        {
            InitializeComponent();
            _user = user;
            _mainOfficeContext = mainOfficeContext;

            this.dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 15);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 15);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MainStockForm_Load(object sender, EventArgs e)
        {
            switch (_user.Location.Id)
            {
                case 2:
                    _kazanOfficeContext = new KazanOfficeContext();
                    break;

                case 3:
                    _peterburgOfficeContext = new PeterburgOfficeContext();
                    break;

                default:
                    break;
            }

            userName.Text = $"{_user.Surname} {_user.Name} {_user.Patronymic}";
            userRole.Text = $"{_user.Role.Name}";
            userLocation.Text = $"{_user.Location.Name}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }

        private void phonesBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
            {
                dataGridView1.DataSource = _mainOfficeContext.Devices.ToList();
            }
            else
            {
                if (_kazanOfficeContext == null)
                {
                    dataGridView1.DataSource = _peterburgOfficeContext.Devices.ToList();
                }
                else
                {
                    dataGridView1.DataSource = _kazanOfficeContext.Devices.ToList();
                }
            }

            dataGridView1.Columns.Add("TypeDevic", "Тип");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var name = _mainOfficeContext.TypeDevices.Where(x => x.Id == (int)dataGridView1.Rows[i].Cells[8].Value).FirstOrDefault().Name;

                dataGridView1[12, i].Value = name;
            }

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Дисплей";
            dataGridView1.Columns[3].HeaderText = "Диагональ экрана";
            dataGridView1.Columns[4].HeaderText = "ОЗУ";
            dataGridView1.Columns[5].HeaderText = "ПЗУ";
            dataGridView1.Columns[6].HeaderText = "Цвет";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[7].HeaderText = "Цена";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
            {
                new StockPhonesView(_mainOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
            }
            else
            {
                if (_kazanOfficeContext == null)
                {
                    new StockPhonesView(_peterburgOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
                }
                else
                {
                    new StockPhonesView(_kazanOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
                }
            }
        }

        private void simBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
            {
                dataGridView1.DataSource = _mainOfficeContext.Sims.ToList();
            }
            else
            {
                if (_kazanOfficeContext == null)
                {
                    dataGridView1.DataSource = _peterburgOfficeContext.Sims.ToList();
                }
                else
                {
                    dataGridView1.DataSource = _kazanOfficeContext.Sims.ToList();
                }
            }

            dataGridView1.Columns.Add("Sta", "Состояние");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var name = _mainOfficeContext.States.Where(x => x.Id == (int)dataGridView1.Rows[i].Cells[2].Value).FirstOrDefault().Name;

                dataGridView1[4, i].Value = name;
            }

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Сим карта";
        }

        private void AddDevice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count < 6)
            {
                if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
                {
                    new ChangeSimForm(_mainOfficeContext).ShowDialog();
                }
                else
                {
                    if (_kazanOfficeContext == null)
                    {
                        new ChangeSimForm(_mainOfficeContext, _peterburgOfficeContext).ShowDialog();
                    }
                    else
                    {
                        new ChangeSimForm(_mainOfficeContext, _kazanOfficeContext).ShowDialog();
                    }
                }
            }
            else
            {
                if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
                {
                    new AddDeviceFrom(_mainOfficeContext).ShowDialog();
                }
                else
                {
                    if (_kazanOfficeContext == null)
                    {
                        new AddDeviceFrom(_mainOfficeContext, _peterburgOfficeContext).ShowDialog();
                    }
                    else
                    {
                        new AddDeviceFrom(_mainOfficeContext, _kazanOfficeContext).ShowDialog();
                    }
                }
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count < 6)
            {
                if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
                {
                    new ChangeSimForm(_mainOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
                }
                else
                {
                    if (_kazanOfficeContext == null)
                    {
                        new ChangeSimForm(_mainOfficeContext, _peterburgOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
                    }
                    else
                    {
                        new ChangeSimForm(_mainOfficeContext, _kazanOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
                    }
                }
            }
            else
            {
                if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
                {
                    new AddDeviceFrom(_mainOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
                }
                else
                {
                    if (_kazanOfficeContext == null)
                    {
                        new AddDeviceFrom(_mainOfficeContext, _peterburgOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
                    }
                    else
                    {
                        new AddDeviceFrom(_mainOfficeContext, _kazanOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
                    }
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count < 6)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
                {
                    dataGridView1.DataSource = _mainOfficeContext.Sims.Where(x => x.Number.ToLower() == textBox1.Text.ToLower()).ToList();
                }
                else
                {
                    if (_kazanOfficeContext == null)
                    {
                        dataGridView1.DataSource = _peterburgOfficeContext.Sims.Where(x => x.Number.ToLower() == textBox1.Text.ToLower()).ToList();
                    }
                    else
                    {
                        dataGridView1.DataSource = _kazanOfficeContext.Sims.Where(x => x.Number.ToLower() == textBox1.Text.ToLower()).ToList();
                    }
                }

                dataGridView1.Columns.Add("Sta", "Состояние");

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var name = _mainOfficeContext.States.Where(x => x.Id == (int)dataGridView1.Rows[i].Cells[2].Value).FirstOrDefault().Name;

                    dataGridView1[4, i].Value = name;
                }

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Сим карта";
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                if (_kazanOfficeContext == null && _peterburgOfficeContext == null)
                {
                    dataGridView1.DataSource = _mainOfficeContext.Devices.Where(x => x.Name.ToLower() == textBox1.Text.ToLower()).ToList();
                }
                else
                {
                    if (_kazanOfficeContext == null)
                    {
                        dataGridView1.DataSource = _peterburgOfficeContext.Devices.Where(x => x.Name.ToLower() == textBox1.Text.ToLower()).ToList();
                    }
                    else
                    {
                        dataGridView1.DataSource = _kazanOfficeContext.Devices.Where(x => x.Name.ToLower() == textBox1.Text.ToLower()).ToList();
                    }
                }

                dataGridView1.Columns.Add("TypeDevic", "Тип");

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var name = _mainOfficeContext.TypeDevices.Where(x => x.Id == (int)dataGridView1.Rows[i].Cells[8].Value).FirstOrDefault().Name;

                    dataGridView1[12, i].Value = name;
                }

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].HeaderText = "Дисплей";
                dataGridView1.Columns[3].HeaderText = "Диагональ экрана";
                dataGridView1.Columns[4].HeaderText = "ОЗУ";
                dataGridView1.Columns[5].HeaderText = "ПЗУ";
                dataGridView1.Columns[6].HeaderText = "Цвет";
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[7].HeaderText = "Цена";
                dataGridView1.Columns[8].HeaderText = "Тип";
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
            }
        }
    }
}
