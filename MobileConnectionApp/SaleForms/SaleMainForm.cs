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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MobileConnectionApp.SaleForms
{
    public partial class SaleMainForm : Form
    {
        private User _user;
        private MainOfficeContext _mainOfficeContext;
        private KazanOfficeContext _kazanOfficeContext;
        private PeterburgOfficeContext _peterburgOfficeContext;
        public SaleMainForm(User user, MainOfficeContext mainOfficeContext)
        {
            InitializeComponent();
            _user = user;
            _mainOfficeContext = mainOfficeContext;

            this.dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 15);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 15);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SaleMainForm_Load(object sender, EventArgs e)
        {
            userName.Text = $"{_user.Surname} {_user.Name} {_user.Patronymic}";
            userRole.Text = $"{_user.Role.Name}";
            userLocation.Text = $"{_user.Location.Name}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

           dataGridView1.DataSource = _mainOfficeContext.Clients.ToList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Серия паспорта";
            dataGridView1.Columns[5].HeaderText = "Номер паспорта";
        }

        private void callersBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = _mainOfficeContext.Callers.ToList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].HeaderText = "№ контракта";
            dataGridView1.Columns[3].HeaderText = "Баланс";
            dataGridView1.Columns[4].HeaderText = "Последнее списание";
            dataGridView1.Columns[5].HeaderText = "Следующее списание";
        }

        private void contracrBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = _mainOfficeContext.Contracts.ToList();

            dataGridView1.Columns.Add("Num", "Номер");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var name = _mainOfficeContext.Numbers.Where(x => x.Id == (int)dataGridView1.Rows[i].Cells[3].Value).FirstOrDefault().Phone;

                dataGridView1[12, i].Value = name;
            }

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[0].HeaderText = "№ Договора";
            dataGridView1.Columns[9].HeaderText = "Дата создания";
            dataGridView1.Columns[10].HeaderText = "Дата последлнего изменения";
            dataGridView1.Columns[11].HeaderText = "Стоимость";
        }

        private void receiptsBrn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = _mainOfficeContext.Receipts.ToList();

            dataGridView1.Columns.Add("Dev", "Устройство");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var name = _mainOfficeContext.Devices.Where(x => x.Id == (int)dataGridView1.Rows[i].Cells[3].Value).FirstOrDefault().Name;

                dataGridView1[7, i].Value = name;
            }

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[0].HeaderText = "№ Чека";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Дата создания";
            dataGridView1.Columns[6].HeaderText = "Стоимость";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Contains("PassportSeria"))
            {
                new AddClientForm(_mainOfficeContext).ShowDialog();
            }

            if (dataGridView1.Columns.Contains("Balance"))
            {
                new AddCallersForm(_mainOfficeContext).ShowDialog();
            }

            if (dataGridView1.Columns.Contains("DateSale"))
            {
                new AddReceiptForm(_mainOfficeContext).ShowDialog();
            }

            if (dataGridView1.Columns.Contains("DateCreate"))
            {
                new AddContractForm(_mainOfficeContext).ShowDialog();
            }

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Contains("PassportSeria"))
            {
                new AddClientForm(_mainOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
            }
            
            if (dataGridView1.Columns.Contains("Balance"))
            {
                new AddCallersForm(_mainOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
            }
            
            if (dataGridView1.Columns.Contains("DateSale"))
            {
                new AddReceiptForm(_mainOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
            } 
            
            if (dataGridView1.Columns.Contains("DateCreate"))
            {
                new AddContractForm(_mainOfficeContext, (int)dataGridView1.SelectedRows[0].Cells[0].Value).ShowDialog();
            }
        }
    }
}
