using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopKarandash
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public SqlConnection GetDBConnection() // метод подключения SQL
        {
            string FarmSklad = @"Data Source=DESKTOP-UQKRMV4\SQLEXPRESS; Initial Catalog = FarmSklad;
            Integrated Security = True"; //настройка безопасности

            SqlConnection connectFarmSklad = new SqlConnection(FarmSklad); //создать подключение
            connectFarmSklad.Open(); //открыть подключение
            return connectFarmSklad;
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nakladnie Na = new Nakladnie();
            Na.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sklad Sk = new Sklad();
            Sk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazin Mg = new Magazin();
            Mg.Show();
        }
    }
}
