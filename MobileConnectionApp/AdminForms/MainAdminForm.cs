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

namespace MobileConnectionApp
{
    public partial class MainAdminForm : Form
    {
        private MainOfficeContext mainOffice;
        private User user;


        public MainAdminForm(MainOfficeContext mainOffice, User user)
        {
            InitializeComponent();
            this.mainOffice = mainOffice;
            this.user = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
