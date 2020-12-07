using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopKarandash
{
    public partial class Nakladnie : Form
    {
        public Nakladnie()
        {
            InitializeComponent();
        }

        Dob_Nakl Dn = new Dob_Nakl();
        private void Nakladnie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shop_KarandashDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this.shop_KarandashDataSet.DataTable3);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                Dn.ShowDialog();
            }
            catch (Exception x)
            {

                MessageBox.Show("Данные введены не корректно!"+x);
            }
          
        }
    }
}
