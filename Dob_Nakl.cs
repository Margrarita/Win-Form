﻿using System;
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
    public partial class Dob_Nakl : Form
    {
        public Dob_Nakl()
        {
            InitializeComponent();
        }

        private void nakladnieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nakladnieBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shop_KarandashDataSet);
            }
            catch (Exception x)
            {

                MessageBox.Show("Данные введены не корректно!"+x);
            }
            

        }

        private void Dob_Nakl_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "shop_KarandashDataSet.Nakladnie". При необходимости она может быть перемещена или удалена.
                this.nakladnieTableAdapter.Fill(this.shop_KarandashDataSet.Nakladnie);
            }
            catch (Exception x)
            {

                MessageBox.Show("Данные введены не корректно!" + x);
            }
            

        }
    }
}
