namespace ShopKarandash
{
    partial class Dob_Magaz
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
            System.Windows.Forms.Label id_tovarLabel;
            System.Windows.Forms.Label prihodLabel;
            System.Windows.Forms.Label rozn_cenaLabel;
            System.Windows.Forms.Label ostatokLabel;
            System.Windows.Forms.Label id_NakladnayaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dob_Magaz));
            this.shop_KarandashDataSet = new ShopKarandash.Shop_KarandashDataSet();
            this.magazinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinTableAdapter = new ShopKarandash.Shop_KarandashDataSetTableAdapters.MagazinTableAdapter();
            this.tableAdapterManager = new ShopKarandash.Shop_KarandashDataSetTableAdapters.TableAdapterManager();
            this.magazinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_tovarTextBox = new System.Windows.Forms.TextBox();
            this.prihodTextBox = new System.Windows.Forms.TextBox();
            this.rozn_cenaTextBox = new System.Windows.Forms.TextBox();
            this.ostatokTextBox = new System.Windows.Forms.TextBox();
            this.id_NakladnayaTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.magazinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_tovarLabel = new System.Windows.Forms.Label();
            prihodLabel = new System.Windows.Forms.Label();
            rozn_cenaLabel = new System.Windows.Forms.Label();
            ostatokLabel = new System.Windows.Forms.Label();
            id_NakladnayaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shop_KarandashDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBindingNavigator)).BeginInit();
            this.magazinBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // shop_KarandashDataSet
            // 
            this.shop_KarandashDataSet.DataSetName = "Shop_KarandashDataSet";
            this.shop_KarandashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazinBindingSource
            // 
            this.magazinBindingSource.DataMember = "Magazin";
            this.magazinBindingSource.DataSource = this.shop_KarandashDataSet;
            // 
            // magazinTableAdapter
            // 
            this.magazinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChekTableAdapter = null;
            this.tableAdapterManager.DomTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KategoriyaTableAdapter = null;
            this.tableAdapterManager.MagazinTableAdapter = this.magazinTableAdapter;
            this.tableAdapterManager.NakladnieTableAdapter = null;
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
            // magazinBindingNavigator
            // 
            this.magazinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.magazinBindingNavigator.BindingSource = this.magazinBindingSource;
            this.magazinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.magazinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.magazinBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.magazinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.magazinBindingNavigatorSaveItem});
            this.magazinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.magazinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.magazinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.magazinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.magazinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.magazinBindingNavigator.Name = "magazinBindingNavigator";
            this.magazinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.magazinBindingNavigator.Size = new System.Drawing.Size(460, 33);
            this.magazinBindingNavigator.TabIndex = 0;
            this.magazinBindingNavigator.Text = "bindingNavigator1";
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
            // id_tovarLabel
            // 
            id_tovarLabel.AutoSize = true;
            id_tovarLabel.Location = new System.Drawing.Point(20, 83);
            id_tovarLabel.Name = "id_tovarLabel";
            id_tovarLabel.Size = new System.Drawing.Size(83, 20);
            id_tovarLabel.TabIndex = 3;
            id_tovarLabel.Text = "id Товара:";
            // 
            // id_tovarTextBox
            // 
            this.id_tovarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazinBindingSource, "id_tovar", true));
            this.id_tovarTextBox.Location = new System.Drawing.Point(138, 80);
            this.id_tovarTextBox.Name = "id_tovarTextBox";
            this.id_tovarTextBox.Size = new System.Drawing.Size(245, 26);
            this.id_tovarTextBox.TabIndex = 4;
            // 
            // prihodLabel
            // 
            prihodLabel.AutoSize = true;
            prihodLabel.Location = new System.Drawing.Point(20, 115);
            prihodLabel.Name = "prihodLabel";
            prihodLabel.Size = new System.Drawing.Size(70, 20);
            prihodLabel.TabIndex = 5;
            prihodLabel.Text = "Приход:";
            // 
            // prihodTextBox
            // 
            this.prihodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazinBindingSource, "Prihod", true));
            this.prihodTextBox.Location = new System.Drawing.Point(138, 112);
            this.prihodTextBox.Name = "prihodTextBox";
            this.prihodTextBox.Size = new System.Drawing.Size(245, 26);
            this.prihodTextBox.TabIndex = 6;
            // 
            // rozn_cenaLabel
            // 
            rozn_cenaLabel.AutoSize = true;
            rozn_cenaLabel.Location = new System.Drawing.Point(20, 147);
            rozn_cenaLabel.Name = "rozn_cenaLabel";
            rozn_cenaLabel.Size = new System.Drawing.Size(96, 20);
            rozn_cenaLabel.TabIndex = 7;
            rozn_cenaLabel.Text = "Розн. Цена:";
            // 
            // rozn_cenaTextBox
            // 
            this.rozn_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazinBindingSource, "Rozn_cena", true));
            this.rozn_cenaTextBox.Location = new System.Drawing.Point(138, 144);
            this.rozn_cenaTextBox.Name = "rozn_cenaTextBox";
            this.rozn_cenaTextBox.Size = new System.Drawing.Size(245, 26);
            this.rozn_cenaTextBox.TabIndex = 8;
            // 
            // ostatokLabel
            // 
            ostatokLabel.AutoSize = true;
            ostatokLabel.Location = new System.Drawing.Point(20, 179);
            ostatokLabel.Name = "ostatokLabel";
            ostatokLabel.Size = new System.Drawing.Size(77, 20);
            ostatokLabel.TabIndex = 9;
            ostatokLabel.Text = "Остаток:";
            // 
            // ostatokTextBox
            // 
            this.ostatokTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazinBindingSource, "Ostatok", true));
            this.ostatokTextBox.Location = new System.Drawing.Point(138, 176);
            this.ostatokTextBox.Name = "ostatokTextBox";
            this.ostatokTextBox.Size = new System.Drawing.Size(245, 26);
            this.ostatokTextBox.TabIndex = 10;
            // 
            // id_NakladnayaLabel
            // 
            id_NakladnayaLabel.AutoSize = true;
            id_NakladnayaLabel.Location = new System.Drawing.Point(20, 211);
            id_NakladnayaLabel.Name = "id_NakladnayaLabel";
            id_NakladnayaLabel.Size = new System.Drawing.Size(115, 20);
            id_NakladnayaLabel.TabIndex = 11;
            id_NakladnayaLabel.Text = "id Накладная:";
            // 
            // id_NakladnayaTextBox
            // 
            this.id_NakladnayaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazinBindingSource, "id_Nakladnaya", true));
            this.id_NakladnayaTextBox.Location = new System.Drawing.Point(138, 208);
            this.id_NakladnayaTextBox.Name = "id_NakladnayaTextBox";
            this.id_NakladnayaTextBox.Size = new System.Drawing.Size(245, 26);
            this.id_NakladnayaTextBox.TabIndex = 12;
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
            // magazinBindingNavigatorSaveItem
            // 
            this.magazinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.magazinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("magazinBindingNavigatorSaveItem.Image")));
            this.magazinBindingNavigatorSaveItem.Name = "magazinBindingNavigatorSaveItem";
            this.magazinBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.magazinBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.magazinBindingNavigatorSaveItem.Click += new System.EventHandler(this.magazinBindingNavigatorSaveItem_Click);
            // 
            // Dob_Magaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 283);
            this.Controls.Add(id_tovarLabel);
            this.Controls.Add(this.id_tovarTextBox);
            this.Controls.Add(prihodLabel);
            this.Controls.Add(this.prihodTextBox);
            this.Controls.Add(rozn_cenaLabel);
            this.Controls.Add(this.rozn_cenaTextBox);
            this.Controls.Add(ostatokLabel);
            this.Controls.Add(this.ostatokTextBox);
            this.Controls.Add(id_NakladnayaLabel);
            this.Controls.Add(this.id_NakladnayaTextBox);
            this.Controls.Add(this.magazinBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dob_Magaz";
            this.Text = "Добавить/Редактировать";
            this.Load += new System.EventHandler(this.Dob_Magaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shop_KarandashDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBindingNavigator)).EndInit();
            this.magazinBindingNavigator.ResumeLayout(false);
            this.magazinBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shop_KarandashDataSet shop_KarandashDataSet;
        private System.Windows.Forms.BindingSource magazinBindingSource;
        private Shop_KarandashDataSetTableAdapters.MagazinTableAdapter magazinTableAdapter;
        private Shop_KarandashDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator magazinBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton magazinBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_tovarTextBox;
        private System.Windows.Forms.TextBox prihodTextBox;
        private System.Windows.Forms.TextBox rozn_cenaTextBox;
        private System.Windows.Forms.TextBox ostatokTextBox;
        private System.Windows.Forms.TextBox id_NakladnayaTextBox;
    }
}