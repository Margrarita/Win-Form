namespace ShopKarandash
{
    partial class Dob_Nakl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_NakladnoyLabel;
            System.Windows.Forms.Label id_tipLabel;
            System.Windows.Forms.Label id_orgLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label id_tovLabel;
            System.Windows.Forms.Label kolvoLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label summaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dob_Nakl));
            this.shop_KarandashDataSet = new ShopKarandash.Shop_KarandashDataSet();
            this.nakladnieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nakladnieTableAdapter = new ShopKarandash.Shop_KarandashDataSetTableAdapters.NakladnieTableAdapter();
            this.tableAdapterManager = new ShopKarandash.Shop_KarandashDataSetTableAdapters.TableAdapterManager();
            this.nakladnieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_NakladnoyTextBox = new System.Windows.Forms.TextBox();
            this.id_tipTextBox = new System.Windows.Forms.TextBox();
            this.id_orgTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_tovTextBox = new System.Windows.Forms.TextBox();
            this.kolvoTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.summaTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.nakladnieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_NakladnoyLabel = new System.Windows.Forms.Label();
            id_tipLabel = new System.Windows.Forms.Label();
            id_orgLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            id_tovLabel = new System.Windows.Forms.Label();
            kolvoLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            summaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shop_KarandashDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnieBindingNavigator)).BeginInit();
            this.nakladnieBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // shop_KarandashDataSet
            // 
            this.shop_KarandashDataSet.DataSetName = "Shop_KarandashDataSet";
            this.shop_KarandashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nakladnieBindingSource
            // 
            this.nakladnieBindingSource.DataMember = "Nakladnie";
            this.nakladnieBindingSource.DataSource = this.shop_KarandashDataSet;
            // 
            // nakladnieTableAdapter
            // 
            this.nakladnieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChekTableAdapter = null;
            this.tableAdapterManager.DomTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KategoriyaTableAdapter = null;
            this.tableAdapterManager.MagazinTableAdapter = null;
            this.tableAdapterManager.NakladnieTableAdapter = this.nakladnieTableAdapter;
            this.tableAdapterManager.OblastTableAdapter = null;
            this.tableAdapterManager.OtchetTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = null;
            this.tableAdapterManager.RajonTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.Tip_dockTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlitsaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopKarandash.Shop_KarandashDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nakladnieBindingNavigator
            // 
            this.nakladnieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nakladnieBindingNavigator.BindingSource = this.nakladnieBindingSource;
            this.nakladnieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nakladnieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nakladnieBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.nakladnieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nakladnieBindingNavigatorSaveItem});
            this.nakladnieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nakladnieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nakladnieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nakladnieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nakladnieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nakladnieBindingNavigator.Name = "nakladnieBindingNavigator";
            this.nakladnieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nakladnieBindingNavigator.Size = new System.Drawing.Size(472, 33);
            this.nakladnieBindingNavigator.TabIndex = 0;
            this.nakladnieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // id_NakladnoyLabel
            // 
            id_NakladnoyLabel.AutoSize = true;
            id_NakladnoyLabel.Location = new System.Drawing.Point(20, 52);
            id_NakladnoyLabel.Name = "id_NakladnoyLabel";
            id_NakladnoyLabel.Size = new System.Drawing.Size(120, 20);
            id_NakladnoyLabel.TabIndex = 1;
            id_NakladnoyLabel.Text = "id_Накладной:";
            // 
            // id_NakladnoyTextBox
            // 
            this.id_NakladnoyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "id_Nakladnoy", true));
            this.id_NakladnoyTextBox.Location = new System.Drawing.Point(139, 49);
            this.id_NakladnoyTextBox.Name = "id_NakladnoyTextBox";
            this.id_NakladnoyTextBox.Size = new System.Drawing.Size(253, 26);
            this.id_NakladnoyTextBox.TabIndex = 2;
            // 
            // id_tipLabel
            // 
            id_tipLabel.AutoSize = true;
            id_tipLabel.Location = new System.Drawing.Point(20, 84);
            id_tipLabel.Name = "id_tipLabel";
            id_tipLabel.Size = new System.Drawing.Size(61, 20);
            id_tipLabel.TabIndex = 3;
            id_tipLabel.Text = "id_Тип:";
            // 
            // id_tipTextBox
            // 
            this.id_tipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "id_tip", true));
            this.id_tipTextBox.Location = new System.Drawing.Point(139, 81);
            this.id_tipTextBox.Name = "id_tipTextBox";
            this.id_tipTextBox.Size = new System.Drawing.Size(253, 26);
            this.id_tipTextBox.TabIndex = 4;
            // 
            // id_orgLabel
            // 
            id_orgLabel.AutoSize = true;
            id_orgLabel.Location = new System.Drawing.Point(20, 116);
            id_orgLabel.Name = "id_orgLabel";
            id_orgLabel.Size = new System.Drawing.Size(62, 20);
            id_orgLabel.TabIndex = 5;
            id_orgLabel.Text = "id_Орг:";
            // 
            // id_orgTextBox
            // 
            this.id_orgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "id_org", true));
            this.id_orgTextBox.Location = new System.Drawing.Point(139, 113);
            this.id_orgTextBox.Name = "id_orgTextBox";
            this.id_orgTextBox.Size = new System.Drawing.Size(253, 26);
            this.id_orgTextBox.TabIndex = 6;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(20, 149);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(52, 20);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Дата:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nakladnieBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(139, 145);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(253, 26);
            this.dateDateTimePicker.TabIndex = 8;
            // 
            // id_tovLabel
            // 
            id_tovLabel.AutoSize = true;
            id_tovLabel.Location = new System.Drawing.Point(20, 180);
            id_tovLabel.Name = "id_tovLabel";
            id_tovLabel.Size = new System.Drawing.Size(88, 20);
            id_tovLabel.TabIndex = 9;
            id_tovLabel.Text = "id_Товара:";
            // 
            // id_tovTextBox
            // 
            this.id_tovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "id_tov", true));
            this.id_tovTextBox.Location = new System.Drawing.Point(139, 177);
            this.id_tovTextBox.Name = "id_tovTextBox";
            this.id_tovTextBox.Size = new System.Drawing.Size(253, 26);
            this.id_tovTextBox.TabIndex = 10;
            // 
            // kolvoLabel
            // 
            kolvoLabel.AutoSize = true;
            kolvoLabel.Location = new System.Drawing.Point(20, 212);
            kolvoLabel.Name = "kolvoLabel";
            kolvoLabel.Size = new System.Drawing.Size(60, 20);
            kolvoLabel.TabIndex = 11;
            kolvoLabel.Text = "Колво:";
            // 
            // kolvoTextBox
            // 
            this.kolvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "kolvo", true));
            this.kolvoTextBox.Location = new System.Drawing.Point(139, 209);
            this.kolvoTextBox.Name = "kolvoTextBox";
            this.kolvoTextBox.Size = new System.Drawing.Size(253, 26);
            this.kolvoTextBox.TabIndex = 12;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(20, 244);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(52, 20);
            cenaLabel.TabIndex = 13;
            cenaLabel.Text = "Цена:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(139, 241);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(253, 26);
            this.cenaTextBox.TabIndex = 14;
            // 
            // summaLabel
            // 
            summaLabel.AutoSize = true;
            summaLabel.Location = new System.Drawing.Point(20, 276);
            summaLabel.Name = "summaLabel";
            summaLabel.Size = new System.Drawing.Size(62, 20);
            summaLabel.TabIndex = 15;
            summaLabel.Text = "Сумма:";
            // 
            // summaTextBox
            // 
            this.summaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "summa", true));
            this.summaTextBox.Location = new System.Drawing.Point(139, 273);
            this.summaTextBox.Name = "summaTextBox";
            this.summaTextBox.Size = new System.Drawing.Size(253, 26);
            this.summaTextBox.TabIndex = 16;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // nakladnieBindingNavigatorSaveItem
            // 
            this.nakladnieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nakladnieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nakladnieBindingNavigatorSaveItem.Image")));
            this.nakladnieBindingNavigatorSaveItem.Name = "nakladnieBindingNavigatorSaveItem";
            this.nakladnieBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.nakladnieBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.nakladnieBindingNavigatorSaveItem.Click += new System.EventHandler(this.nakladnieBindingNavigatorSaveItem_Click);
            // 
            // Dob_Nakl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 345);
            this.Controls.Add(id_NakladnoyLabel);
            this.Controls.Add(this.id_NakladnoyTextBox);
            this.Controls.Add(id_tipLabel);
            this.Controls.Add(this.id_tipTextBox);
            this.Controls.Add(id_orgLabel);
            this.Controls.Add(this.id_orgTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(id_tovLabel);
            this.Controls.Add(this.id_tovTextBox);
            this.Controls.Add(kolvoLabel);
            this.Controls.Add(this.kolvoTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(summaLabel);
            this.Controls.Add(this.summaTextBox);
            this.Controls.Add(this.nakladnieBindingNavigator);
            this.Name = "Dob_Nakl";
            this.Text = "Dob_Nakl";
            this.Load += new System.EventHandler(this.Dob_Nakl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shop_KarandashDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnieBindingNavigator)).EndInit();
            this.nakladnieBindingNavigator.ResumeLayout(false);
            this.nakladnieBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shop_KarandashDataSet shop_KarandashDataSet;
        private System.Windows.Forms.BindingSource nakladnieBindingSource;
        private Shop_KarandashDataSetTableAdapters.NakladnieTableAdapter nakladnieTableAdapter;
        private Shop_KarandashDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nakladnieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nakladnieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_NakladnoyTextBox;
        private System.Windows.Forms.TextBox id_tipTextBox;
        private System.Windows.Forms.TextBox id_orgTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox id_tovTextBox;
        private System.Windows.Forms.TextBox kolvoTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox summaTextBox;
    }
}