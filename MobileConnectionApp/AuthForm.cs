using Microsoft.EntityFrameworkCore;
using MobileConnectionApp.DataBase.MainOfficeDataBase;
using MobileConnectionApp.SaleForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileConnectionApp
{
    public partial class AuthFrom : Form
    {
        public AuthFrom()
        {
            InitializeComponent();
            PassTextBox.UseSystemPasswordChar = true;
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            MainOfficeContext mainOfficeContext = new MainOfficeContext();
            var user = mainOfficeContext.Users.Include(y=> y.Role) .Include(z => z.Location).Where(x => x.Password == PassTextBox.Text & x.Login == LoginTextBox.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Такого пользователя в системе нет, попробуйте ещё раз или обратитесь к администратору.", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (user.Role.Id)
                {
                    case 3:
                        this.Hide();
                        new MainAdminForm(mainOfficeContext,user).ShowDialog();
                        break;

                    case 1:
                        MainStockForm mainStockForm = new MainStockForm(user, mainOfficeContext);
                        this.Hide();
                        mainStockForm.ShowDialog();
                        break;

                    case 2:
                        this.Hide();
                        new SaleMainForm(user, mainOfficeContext).ShowDialog();
                        break;

                    default:
                        MessageBox.Show("Такой роли как у вас в системе нету, обратитесть к администратору.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void AuthFrom_Load(object sender, EventArgs e)
        {

        }
    }
}