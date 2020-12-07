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
    public partial class Dob_Nakladnaya : Form
    {
        public Dob_Nakladnaya()
        {
            InitializeComponent();
        }

        private void nakladnieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nakladnieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shop_KarandashDataSet);

        }

        private void Dob_Nakladnaya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shop_KarandashDataSet.Nakladnie". При необходимости она может быть перемещена или удалена.
            this.nakladnieTableAdapter.Fill(this.shop_KarandashDataSet.Nakladnie);

        }

        private void summaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
