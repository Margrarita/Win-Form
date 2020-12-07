namespace ShopKarandash
{
    partial class Dob_Sklad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dob_Sklad));
            System.Windows.Forms.Label id_tovarLabel;
            System.Windows.Forms.Label opt_cenaLabel;
            System.Windows.Forms.Label rozn_cenaLabel;
            System.Windows.Forms.Label ostatokLabel;
            System.Windows.Forms.Label prihodLabel;
            System.Windows.Forms.Label id_NakladnayaLabel;
            this.shop_KarandashDataSet = new ShopKarandash.Shop_KarandashDataSet();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new ShopKarandash.Shop_KarandashDataSetTableAdapters.SkladTableAdapter();
            this.tableAdapterManager = new ShopKarandash.Shop_KarandashDataSetTableAdapters.TableAdapterManager();
            this.skladBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.skladBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_tovarTextBox = new System.Windows.Forms.TextBox();
            this.opt_cenaTextBox = new System.Windows.Forms.TextBox();
            this.rozn_cenaTextBox = new System.Windows.Forms.TextBox();
            this.ostatokTextBox = new System.Windows.Forms.TextBox();
            this.prihodTextBox = new System.Windows.Forms.TextBox();
            this.id_NakladnayaTextBox = new System.Windows.Forms.TextBox();
            id_tovarLabel = new System.Windows.Forms.Label();
            opt_cenaLabel = new System.Windows.Forms.Label();
            rozn_cenaLabel = new System.Windows.Forms.Label();
            ostatokLabel = new System.Windows.Forms.Label();
            prihodLabel = new System.Windows.Forms.Label();
            id_NakladnayaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shop_KarandashDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).BeginInit();
            this.skladBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // shop_KarandashDataSet
            // 
            this.shop_KarandashDataSet.DataSetName = "Shop_KarandashDataSet";
            this.shop_KarandashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.shop_KarandashDataSet;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NakladnieTableAdapter = null;
            this.tableAdapterManager.OblastTableAdapter = null;
            this.tableAdapterManager.OtchetTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = null;
            this.tableAdapterManager.RajonTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.Tip_dockTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlitsaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopKarandash.Shop_KarandashDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // skladBindingNavigator
            // 
            this.skladBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.skladBindingNavigator.BindingSource = this.skladBindingSource;
            this.skladBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.skladBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.skladBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.skladBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.skladBindingNavigatorSaveItem});
            this.skladBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.skladBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.skladBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.skladBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.skladBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.skladBindingNavigator.Name = "skladBindingNavigator";
            this.skladBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.skladBindingNavigator.Size = new System.Drawing.Size(459, 33);
            this.skladBindingNavigator.TabIndex = 0;
            this.skladBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // skladBindingNavigatorSaveItem
            // 
            this.skladBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skladBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("skladBindingNavigatorSaveItem.Image")));
            this.skladBindingNavigatorSaveItem.Name = "skladBindingNavigatorSaveItem";
            this.skladBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.skladBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.skladBindingNavigatorSaveItem.Click += new System.EventHandler(this.skladBindingNavigatorSaveItem_Click);
            // 
            // id_tovarLabel
            // 
            id_tovarLabel.AutoSize = true;
            id_tovarLabel.Location = new System.Drawing.Point(18, 74);
            id_tovarLabel.Name = "id_tovarLabel";
            id_tovarLabel.Size = new System.Drawing.Size(64, 20);
            id_tovarLabel.TabIndex = 3;
            id_tovarLabel.Text = "id tovar:";
            // 
            // id_tovarTextBox
            // 
            this.id_tovarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_tovar", true));
            this.id_tovarTextBox.Location = new System.Drawing.Point(136, 71);
            this.id_tovarTextBox.Name = "id_tovarTextBox";
            this.id_tovarTextBox.Size = new System.Drawing.Size(245, 26);
            this.id_tovarTextBox.TabIndex = 4;
            // 
            // opt_cenaLabel
            // 
            opt_cenaLabel.AutoSize = true;
            opt_cenaLabel.Location = new System.Drawing.Point(18, 106);
            opt_cenaLabel.Name = "opt_cenaLabel";
            opt_cenaLabel.Size = new System.Drawing.Size(78, 20);
            opt_cenaLabel.TabIndex = 5;
            opt_cenaLabel.Text = "Opt cena:";
            // 
            // opt_cenaTextBox
            // 
            this.opt_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Opt_cena", true));
            this.opt_cenaTextBox.Location = new System.Drawing.Point(136, 103);
            this.opt_cenaTextBox.Name = "opt_cenaTextBox";
            this.opt_cenaTextBox.Size = new System.Drawing.Size(245, 26);
            this.opt_cenaTextBox.TabIndex = 6;
            // 
            // rozn_cenaLabel
            // 
            rozn_cenaLabel.AutoSize = true;
            rozn_cenaLabel.Location = new System.Drawing.Point(18, 138);
            rozn_cenaLabel.Name = "rozn_cenaLabel";
            rozn_cenaLabel.Size = new System.Drawing.Size(90, 20);
            rozn_cenaLabel.TabIndex = 7;
            rozn_cenaLabel.Text = "Rozn cena:";
            // 
            // rozn_cenaTextBox
            // 
            this.rozn_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Rozn_cena", true));
            this.rozn_cenaTextBox.Location = new System.Drawing.Point(136, 135);
            this.rozn_cenaTextBox.Name = "rozn_cenaTextBox";
            this.rozn_cenaTextBox.Size = new System.Drawing.Size(245, 26);
            this.rozn_cenaTextBox.TabIndex = 8;
            // 
            // ostatokLabel
            // 
            ostatokLabel.AutoSize = true;
            ostatokLabel.Location = new System.Drawing.Point(18, 170);
            ostatokLabel.Name = "ostatokLabel";
            ostatokLabel.Size = new System.Drawing.Size(69, 20);
            ostatokLabel.TabIndex = 9;
            ostatokLabel.Text = "Ostatok:";
            // 
            // ostatokTextBox
            // 
            this.ostatokTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Ostatok", true));
            this.ostatokTextBox.Location = new System.Drawing.Point(136, 167);
            this.ostatokTextBox.Name = "ostatokTextBox";
            this.ostatokTextBox.Size = new System.Drawing.Size(245, 26);
            this.ostatokTextBox.TabIndex = 10;
            // 
            // prihodLabel
            // 
            prihodLabel.AutoSize = true;
            prihodLabel.Location = new System.Drawing.Point(18, 202);
            prihodLabel.Name = "prihodLabel";
            prihodLabel.Size = new System.Drawing.Size(58, 20);
            prihodLabel.TabIndex = 11;
            prihodLabel.Text = "Prihod:";
            // 
            // prihodTextBox
            // 
            this.prihodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Prihod", true));
            this.prihodTextBox.Location = new System.Drawing.Point(136, 199);
            this.prihodTextBox.Name = "prihodTextBox";
            this.prihodTextBox.Size = new System.Drawing.Size(245, 26);
            this.prihodTextBox.TabIndex = 12;
            // 
            // id_NakladnayaLabel
            // 
            id_NakladnayaLabel.AutoSize = true;
            id_NakladnayaLabel.Location = new System.Drawing.Point(18, 234);
            id_NakladnayaLabel.Name = "id_NakladnayaLabel";
            id_NakladnayaLabel.Size = new System.Drawing.Size(112, 20);
            id_NakladnayaLabel.TabIndex = 13;
            id_NakladnayaLabel.Text = "id Nakladnaya:";
            // 
            // id_NakladnayaTextBox
            // 
            this.id_NakladnayaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_Nakladnaya", true));
            this.id_NakladnayaTextBox.Location = new System.Drawing.Point(136, 231);
            this.id_NakladnayaTextBox.Name = "id_NakladnayaTextBox";
            this.id_NakladnayaTextBox.Size = new System.Drawing.Size(245, 26);
            this.id_NakladnayaTextBox.TabIndex = 14;
            // 
            // Dob_Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 334);
            this.Controls.Add(id_tovarLabel);
            this.Controls.Add(this.id_tovarTextBox);
            this.Controls.Add(opt_cenaLabel);
            this.Controls.Add(this.opt_cenaTextBox);
            this.Controls.Add(rozn_cenaLabel);
            this.Controls.Add(this.rozn_cenaTextBox);
            this.Controls.Add(ostatokLabel);
            this.Controls.Add(this.ostatokTextBox);
            this.Controls.Add(prihodLabel);
            this.Controls.Add(this.prihodTextBox);
            this.Controls.Add(id_NakladnayaLabel);
            this.Controls.Add(this.id_NakladnayaTextBox);
            this.Controls.Add(this.skladBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dob_Sklad";
            this.Text = "Добавить/Редактировать";
            this.Load += new System.EventHandler(this.Dob_Sklad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shop_KarandashDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).EndInit();
            this.skladBindingNavigator.ResumeLayout(false);
            this.skladBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shop_KarandashDataSet shop_KarandashDataSet;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private Shop_KarandashDataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private Shop_KarandashDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator skladBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton skladBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_tovarTextBox;
        private System.Windows.Forms.TextBox opt_cenaTextBox;
        private System.Windows.Forms.TextBox rozn_cenaTextBox;
        private System.Windows.Forms.TextBox ostatokTextBox;
        private System.Windows.Forms.TextBox prihodTextBox;
        private System.Windows.Forms.TextBox id_NakladnayaTextBox;
    }
}