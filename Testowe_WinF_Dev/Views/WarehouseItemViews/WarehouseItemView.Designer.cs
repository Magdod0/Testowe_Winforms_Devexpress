namespace Testowe_WinF_Dev.Views
{
    partial class WarehouseItemView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseItemView));
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.warehouseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsAtBeginning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsLeft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrutto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArrivalDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Testowe_WinF_Dev.ViewModels.WarehouseItemViewModels.WarehouseItemViewModel);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(495, 150);
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 1;
            this.bbiNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNew.ImageOptions.Image")));
            this.bbiNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNew.ImageOptions.LargeImage")));
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 2;
            this.bbiEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiEdit.ImageOptions.Image")));
            this.bbiEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEdit.ImageOptions.LargeImage")));
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 3;
            this.bbiDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.Image")));
            this.bbiDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.LargeImage")));
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiRefresh.ImageOptions.Image")));
            this.bbiRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiRefresh.ImageOptions.LargeImage")));
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Warehouse Items";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operations";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.warehouseItemBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(495, 285);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // warehouseItemBindingSource
            // 
            this.warehouseItemBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.WarehouseItem);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colWarehouseID,
            this.colWarehouse,
            this.colName,
            this.colUnitsAtBeginning,
            this.colUnitsLeft,
            this.colNetto,
            this.colBrutto,
            this.colArrivalDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colWarehouseID
            // 
            this.colWarehouseID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colWarehouseID.FieldName = "WarehouseID";
            this.colWarehouseID.Name = "colWarehouseID";
            this.colWarehouseID.Visible = true;
            this.colWarehouseID.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.warehouseBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.Warehouse);
            // 
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colUnitsAtBeginning
            // 
            this.colUnitsAtBeginning.FieldName = "UnitsAtBeginning";
            this.colUnitsAtBeginning.Name = "colUnitsAtBeginning";
            this.colUnitsAtBeginning.Visible = true;
            this.colUnitsAtBeginning.VisibleIndex = 2;
            // 
            // colUnitsLeft
            // 
            this.colUnitsLeft.FieldName = "UnitsLeft";
            this.colUnitsLeft.Name = "colUnitsLeft";
            this.colUnitsLeft.Visible = true;
            this.colUnitsLeft.VisibleIndex = 3;
            // 
            // colNetto
            // 
            this.colNetto.FieldName = "Netto";
            this.colNetto.Name = "colNetto";
            this.colNetto.Visible = true;
            this.colNetto.VisibleIndex = 4;
            // 
            // colBrutto
            // 
            this.colBrutto.FieldName = "Brutto";
            this.colBrutto.Name = "colBrutto";
            this.colBrutto.Visible = true;
            this.colBrutto.VisibleIndex = 5;
            // 
            // colArrivalDate
            // 
            this.colArrivalDate.FieldName = "ArrivalDate";
            this.colArrivalDate.Name = "colArrivalDate";
            this.colArrivalDate.Visible = true;
            this.colArrivalDate.VisibleIndex = 6;
            // 
            // WarehouseItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "WarehouseItemView";
            this.Size = new System.Drawing.Size(495, 435);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource warehouseItemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsAtBeginning;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colNetto;
        private DevExpress.XtraGrid.Columns.GridColumn colBrutto;
        private DevExpress.XtraGrid.Columns.GridColumn colArrivalDate;
    }
}
