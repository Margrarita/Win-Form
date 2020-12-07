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
    public partial class Dob_Magaz : Form
    {
        public Dob_Magaz()
        {
            InitializeComponent();
        }

        private void magazinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.magazinBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shop_KarandashDataSet);
            }
            catch (Exception x)
            {

                MessageBox.Show("Ошибка!" + x);
            }
           

        }

        private void Dob_Magaz_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "shop_KarandashDataSet.Magazin". При необходимости она может быть перемещена или удалена.
                this.magazinTableAdapter.Fill(this.shop_KarandashDataSet.Magazin);
            }
            catch (Exception x)
            {
                MessageBox.Show("Введены не корректные данные" + x);
            }

           

        }
    }
}
