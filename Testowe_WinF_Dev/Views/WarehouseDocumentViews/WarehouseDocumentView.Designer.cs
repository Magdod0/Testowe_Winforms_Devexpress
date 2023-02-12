namespace Testowe_WinF_Dev.Views
{
    partial class WarehouseDocumentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseDocumentView));
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.beiWarehouse = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btsiArchieved = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.warehouseDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocunmentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderWarehouseItems = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Testowe_WinF_Dev.ViewModels.WarehouseDocumentViewModels.WarehouseDocumentViewModel);
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
            this.bbiRefresh,
            this.beiWarehouse,
            this.btsiArchieved});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemRadioGroup1});
            this.ribbonControl1.Size = new System.Drawing.Size(503, 150);
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
            this.bbiRefresh.Id = 5;
            this.bbiRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiRefresh.ImageOptions.Image")));
            this.bbiRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiRefresh.ImageOptions.LargeImage")));
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // beiWarehouse
            // 
            this.beiWarehouse.Caption = "Warehouse";
            this.beiWarehouse.Edit = this.repositoryItemLookUpEdit2;
            this.beiWarehouse.EditWidth = 120;
            this.beiWarehouse.Id = 9;
            this.beiWarehouse.Name = "beiWarehouse";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.warehouseBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemLookUpEdit2.KeyMember = "ID";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "ID";
            this.repositoryItemLookUpEdit2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.repositoryItemLookUpEdit2_QueryPopUp);
            this.repositoryItemLookUpEdit2.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemLookUpEdit2_EditValueChanging);
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.Warehouse);
            // 
            // btsiArchieved
            // 
            this.btsiArchieved.Caption = "Show Executed Only";
            this.btsiArchieved.Id = 12;
            this.btsiArchieved.Name = "btsiArchieved";
            this.btsiArchieved.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiArchieved_CheckedChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Warehouse Documents";
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
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.beiWarehouse);
            this.ribbonPageGroup3.ItemLinks.Add(this.btsiArchieved);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.warehouseDocumentBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(503, 241);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // warehouseDocumentBindingSource
            // 
            this.warehouseDocumentBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.WarehouseDocument);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colWarehouseID,
            this.colName,
            this.colCreatedDate,
            this.colDocunmentDate,
            this.colWarehouse,
            this.colOrderWarehouseItems});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
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
            this.colWarehouseID.VisibleIndex = 3;
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
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 1;
            // 
            // colDocunmentDate
            // 
            this.colDocunmentDate.FieldName = "DocunmentDate";
            this.colDocunmentDate.Name = "colDocunmentDate";
            this.colDocunmentDate.Visible = true;
            this.colDocunmentDate.VisibleIndex = 2;
            // 
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            // 
            // colOrderWarehouseItems
            // 
            this.colOrderWarehouseItems.FieldName = "OrderWarehouseItems";
            this.colOrderWarehouseItems.Name = "colOrderWarehouseItems";
            // 
            // WarehouseDocumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "WarehouseDocumentView";
            this.Size = new System.Drawing.Size(503, 391);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource warehouseDocumentBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;

        private DevExpress.XtraBars.BarEditItem beiWarehouse;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraBars.BarToggleSwitchItem btsiArchieved;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDocunmentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderWarehouseItems;
    }
}
