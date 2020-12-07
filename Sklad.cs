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
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shop_KarandashDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.shop_KarandashDataSet.DataTable2);

        }

        Dob_Sklad ds = new Dob_Sklad();

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                ds.ShowDialog();
            }
            catch (Exception x)
            {

                MessageBox.Show("Данные введены не корректно!"+x);
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataTable2DataGridView.RowCount; i++)
            {
                dataTable2DataGridView.Rows[i].Selected = false;
                for (int j = 0; j < dataTable2DataGridView.ColumnCount; j++)
                    if (dataTable2DataGridView.Rows[i].Cells[j].Value != null)
                        if (dataTable2DataGridView.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataTable2DataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.Fill(this.shop_KarandashDataSet.DataTable2);
        }
    }

    }
