namespace ShopKarandash
{
    partial class Chek
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Shop_KarandashDataSet = new ShopKarandash.Shop_KarandashDataSet();
            this.ChekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChekTableAdapter = new ShopKarandash.Shop_KarandashDataSetTableAdapters.ChekTableAdapter();
            this.GorodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GorodTableAdapter = new ShopKarandash.Shop_KarandashDataSetTableAdapters.GorodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Shop_KarandashDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShopKarandash.Chek.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 692);
            this.reportViewer1.TabIndex = 0;
            // 
            // Shop_KarandashDataSet
            // 
            this.Shop_KarandashDataSet.DataSetName = "Shop_KarandashDataSet";
            this.Shop_KarandashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChekBindingSource
            // 
            this.ChekBindingSource.DataMember = "Chek";
            this.ChekBindingSource.DataSource = this.Shop_KarandashDataSet;
            // 
            // ChekTableAdapter
            // 
            this.ChekTableAdapter.ClearBeforeFill = true;
            // 
            // GorodBindingSource
            // 
            this.GorodBindingSource.DataMember = "Gorod";
            this.GorodBindingSource.DataSource = this.Shop_KarandashDataSet;
            // 
            // GorodTableAdapter
            // 
            this.GorodTableAdapter.ClearBeforeFill = true;
            // 
            // Chek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Chek";
            this.Text = "Chek";
            this.Load += new System.EventHandler(this.Chek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Shop_KarandashDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChekBindingSource;
        private Shop_KarandashDataSet Shop_KarandashDataSet;
        private Shop_KarandashDataSetTableAdapters.ChekTableAdapter ChekTableAdapter;
        private System.Windows.Forms.BindingSource GorodBindingSource;
        private Shop_KarandashDataSetTableAdapters.GorodTableAdapter GorodTableAdapter;
    }
}