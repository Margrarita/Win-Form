namespace ShopKarandash
{
    partial class Dob_Nakladnaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dob_Nakladnaya));
            System.Windows.Forms.Label id_NakladnoyLabel;
            System.Windows.Forms.Label id_tipLabel;
            System.Windows.Forms.Label id_orgLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label id_tovLabel;
            System.Windows.Forms.Label kolvoLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label summaLabel;
            this.shop_KarandashDataSet = new ShopKarandash.Shop_KarandashDataSet();
            this.nakladnieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nakladnieTableAdapter = new ShopKarandash.Shop_KarandashDataSetTableAdapters.NakladnieTableAdapter();
            this.tableAdapterManager = new ShopKarandash.Shop_KarandashDataSetTableAdapters.TableAdapterManager();
            this.nakladnieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nakladnieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_NakladnoyTextBox = new System.Windows.Forms.TextBox();
            this.id_tipTextBox = new System.Windows.Forms.TextBox();
            this.id_orgTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_tovTextBox = new System.Windows.Forms.TextBox();
            this.kolvoTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.summaTextBox = new System.Windows.Forms.TextBox();
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
            this.nakladnieBindingNavigator.Size = new System.Drawing.Size(364, 25);
            this.nakladnieBindingNavigator.TabIndex = 0;
            this.nakladnieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // nakladnieBindingNavigatorSaveItem
            // 
            this.nakladnieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nakladnieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nakladnieBindingNavigatorSaveItem.Image")));
            this.nakladnieBindingNavigatorSaveItem.Name = "nakladnieBindingNavigatorSaveItem";
            this.nakladnieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nakladnieBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.nakladnieBindingNavigatorSaveItem.Click += new System.EventHandler(this.nakladnieBindingNavigatorSaveItem_Click);
            // 
            // id_NakladnoyLabel
            // 
            id_NakladnoyLabel.AutoSize = true;
            id_NakladnoyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_NakladnoyLabel.Location = new System.Drawing.Point(12, 52);
            id_NakladnoyLabel.Name = "id_NakladnoyLabel";
            id_NakladnoyLabel.Size = new System.Drawing.Size(21, 13);
            id_NakladnoyLabel.TabIndex = 1;
            id_NakladnoyLabel.Text = "id ";
            // 
            // id_NakladnoyTextBox
            // 
            this.id_NakladnoyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "id_Nakladnoy", true));
            this.id_NakladnoyTextBox.Location = new System.Drawing.Point(152, 49);
            this.id_NakladnoyTextBox.Name = "id_NakladnoyTextBox";
            this.id_NakladnoyTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_NakladnoyTextBox.TabIndex = 2;
            // 
            // id_tipLabel
            // 
            id_tipLabel.AutoSize = true;
            id_tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_tipLabel.Location = new System.Drawing.Point(12, 78);
            id_tipLabel.Name = "id_tipLabel";
            id_tipLabel.Size = new System.Drawing.Size(94, 13);
            id_tipLabel.TabIndex = 3;
            id_tipLabel.Text = "тип накладной";
            // 
            // id_tipTextBox
            // 
            this.id_tipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "id_tip", true));
            this.id_tipTextBox.Location = new System.Drawing.Point(152, 75);
            this.id_tipTextBox.Name = "id_tipTextBox";
            this.id_tipTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_tipTextBox.TabIndex = 4;
            // 
            // id_orgLabel
            // 
            id_orgLabel.AutoSize = true;
            id_orgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_orgLabel.Location = new System.Drawing.Point(12, 104);
            id_orgLabel.Name = "id_orgLabel";
            id_orgLabel.Size = new System.Drawing.Size(83, 13);
            id_orgLabel.TabIndex = 5;
            id_orgLabel.Text = "организация";
            // 
            // id_orgTextBox
            // 
            this.id_orgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "id_org", true));
            this.id_orgTextBox.Location = new System.Drawing.Point(152, 98);
            this.id_orgTextBox.Name = "id_orgTextBox";
            this.id_orgTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_orgTextBox.TabIndex = 6;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.Location = new System.Drawing.Point(12, 131);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 13);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Дата";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nakladnieBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(152, 124);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 8;
            // 
            // id_tovLabel
            // 
            id_tovLabel.AutoSize = true;
            id_tovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_tovLabel.Location = new System.Drawing.Point(12, 156);
            id_tovLabel.Name = "id_tovLabel";
            id_tovLabel.Size = new System.Drawing.Size(43, 13);
            id_tovLabel.TabIndex = 9;
            id_tovLabel.Text = "Товар";
            // 
            // id_tovTextBox
            // 
            this.id_tovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "id_tov", true));
            this.id_tovTextBox.Location = new System.Drawing.Point(152, 150);
            this.id_tovTextBox.Name = "id_tovTextBox";
            this.id_tovTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_tovTextBox.TabIndex = 10;
            // 
            // kolvoLabel
            // 
            kolvoLabel.AutoSize = true;
            kolvoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kolvoLabel.Location = new System.Drawing.Point(12, 182);
            kolvoLabel.Name = "kolvoLabel";
            kolvoLabel.Size = new System.Drawing.Size(76, 13);
            kolvoLabel.TabIndex = 11;
            kolvoLabel.Text = "Количество";
            // 
            // kolvoTextBox
            // 
            this.kolvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "kolvo", true));
            this.kolvoTextBox.Location = new System.Drawing.Point(152, 176);
            this.kolvoTextBox.Name = "kolvoTextBox";
            this.kolvoTextBox.Size = new System.Drawing.Size(200, 20);
            this.kolvoTextBox.TabIndex = 12;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cenaLabel.Location = new System.Drawing.Point(12, 208);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(37, 13);
            cenaLabel.TabIndex = 13;
            cenaLabel.Text = "Цена";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(152, 202);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cenaTextBox.TabIndex = 14;
            // 
            // summaLabel
            // 
            summaLabel.AutoSize = true;
            summaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            summaLabel.Location = new System.Drawing.Point(12, 234);
            summaLabel.Name = "summaLabel";
            summaLabel.Size = new System.Drawing.Size(46, 13);
            summaLabel.TabIndex = 15;
            summaLabel.Text = "Сумма";
            // 
            // summaTextBox
            // 
            this.summaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnieBindingSource, "summa", true));
            this.summaTextBox.Location = new System.Drawing.Point(152, 228);
            this.summaTextBox.Name = "summaTextBox";
            this.summaTextBox.Size = new System.Drawing.Size(200, 20);
            this.summaTextBox.TabIndex = 16;
            this.summaTextBox.TextChanged += new System.EventHandler(this.summaTextBox_TextChanged);
            // 
            // Dob_Nakladnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 267);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dob_Nakladnaya";
            this.Text = "Добавление накладной";
            this.Load += new System.EventHandler(this.Dob_Nakladnaya_Load);
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