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
    public partial class Dob_Sklad : Form
    {
        public Dob_Sklad()
        {
            InitializeComponent();
        }

        private void skladBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.skladBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shop_KarandashDataSet);
            }
            catch (Exception x)
            {

                MessageBox.Show("Даннные введенны не корреткно!" + x);
            }
            

        }

        private void Dob_Sklad_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "shop_KarandashDataSet.Sklad". При необходимости она может быть перемещена или удалена.
                this.skladTableAdapter.Fill(this.shop_KarandashDataSet.Sklad);
            }
            catch (Exception x)
            {

                MessageBox.Show("Даннные введенны не корреткно!" + x);
            }
            

        }
    }
}
