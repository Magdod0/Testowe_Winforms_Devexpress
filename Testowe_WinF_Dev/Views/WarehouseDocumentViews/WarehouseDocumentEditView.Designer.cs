namespace Testowe_WinF_Dev.Views.WarehouseDocumentViews
{
    partial class WarehouseDocumentEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseDocumentEditView));
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExecute = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.sbRemove = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rileItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.warehouseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colWarehouseItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseDocumentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseDocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.warehouseDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Testowe_WinF_Dev.ViewModels.WarehouseDocumentViewModels.WarehouseDocumentEditViewModel);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiSave,
            this.bbiClose,
            this.bbiExecute});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(484, 150);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.Image")));
            this.bbiSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.LargeImage")));
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Cancel";
            this.bbiClose.Id = 2;
            this.bbiClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiClose.ImageOptions.Image")));
            this.bbiClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiClose.ImageOptions.LargeImage")));
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiExecute
            // 
            this.bbiExecute.Caption = "Issue Document";
            this.bbiExecute.Id = 5;
            this.bbiExecute.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExecute.ImageOptions.Image")));
            this.bbiExecute.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExecute.ImageOptions.LargeImage")));
            this.bbiExecute.Name = "bbiExecute";
            this.bbiExecute.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExecute_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operations";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiExecute);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.sbRemove);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.teName);
            this.dataLayoutControl1.Controls.Add(this.textEdit2);
            this.dataLayoutControl1.Controls.Add(this.sbAdd);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 150);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(484, 307);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // sbRemove
            // 
            this.sbRemove.AutoWidthInLayoutControl = true;
            this.sbRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbRemove.ImageOptions.Image")));
            this.sbRemove.Location = new System.Drawing.Point(54, 60);
            this.sbRemove.Name = "sbRemove";
            this.sbRemove.Size = new System.Drawing.Size(38, 36);
            this.sbRemove.StyleController = this.dataLayoutControl1;
            this.sbRemove.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rileItem});
            this.gridControl1.Size = new System.Drawing.Size(460, 165);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colWarehouseItemID,
            this.colWarehouseItem,
            this.colWarehouseDocumentID,
            this.colWarehouseDocument,
            this.colUnits,
            this.colOrderDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colWarehouseItemID
            // 
            this.colWarehouseItemID.ColumnEdit = this.rileItem;
            this.colWarehouseItemID.FieldName = "WarehouseItemID";
            this.colWarehouseItemID.Name = "colWarehouseItemID";
            this.colWarehouseItemID.Visible = true;
            this.colWarehouseItemID.VisibleIndex = 0;
            // 
            // rileItem
            // 
            this.rileItem.AutoHeight = false;
            this.rileItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileItem.DataSource = this.warehouseItemBindingSource;
            this.rileItem.DisplayMember = "Name";
            this.rileItem.Name = "rileItem";
            this.rileItem.ValueMember = "ID";
            // 
            // warehouseItemBindingSource
            // 
            this.warehouseItemBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.WarehouseItem);
            // 
            // colWarehouseItem
            // 
            this.colWarehouseItem.FieldName = "WarehouseItem";
            this.colWarehouseItem.Name = "colWarehouseItem";
            // 
            // colWarehouseDocumentID
            // 
            this.colWarehouseDocumentID.FieldName = "WarehouseDocumentID";
            this.colWarehouseDocumentID.Name = "colWarehouseDocumentID";
            // 
            // colWarehouseDocument
            // 
            this.colWarehouseDocument.FieldName = "WarehouseDocument";
            this.colWarehouseDocument.Name = "colWarehouseDocument";
            // 
            // colUnits
            // 
            this.colUnits.FieldName = "Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.Visible = true;
            this.colUnits.VisibleIndex = 1;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            // 
            // teName
            // 
            this.teName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseDocumentBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teName.Location = new System.Drawing.Point(51, 12);
            this.teName.MenuManager = this.ribbonControl1;
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(421, 20);
            this.teName.StyleController = this.dataLayoutControl1;
            this.teName.TabIndex = 4;
            // 
            // warehouseDocumentBindingSource
            // 
            this.warehouseDocumentBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.WarehouseDocument);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseDocumentBindingSource, "DocunmentDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit2.EditValue = null;
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(51, 36);
            this.textEdit2.MenuManager = this.ribbonControl1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Properties.DisplayFormat.FormatString = "";
            this.textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit2.Properties.EditFormat.FormatString = "";
            this.textEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit2.Properties.Mask.EditMask = "";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit2.Size = new System.Drawing.Size(421, 20);
            this.textEdit2.StyleController = this.dataLayoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // sbAdd
            // 
            this.sbAdd.AutoWidthInLayoutControl = true;
            this.sbAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAdd.ImageOptions.Image")));
            this.sbAdd.Location = new System.Drawing.Point(12, 60);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(38, 36);
            this.sbAdd.StyleController = this.dataLayoutControl1;
            this.sbAdd.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(484, 307);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(464, 24);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(27, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 257);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(464, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(464, 24);
            this.layoutControlItem2.Text = "Date";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(27, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(464, 169);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbAdd;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(42, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbRemove;
            this.layoutControlItem5.Location = new System.Drawing.Point(42, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(422, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // WarehouseDocumentEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "WarehouseDocumentEditView";
            this.Size = new System.Drawing.Size(484, 457);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit textEdit2;
        private System.Windows.Forms.BindingSource warehouseDocumentBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton sbRemove;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarButtonItem bbiExecute;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileItem;
        private System.Windows.Forms.BindingSource warehouseItemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseItem;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseDocumentID;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseDocument;
        private DevExpress.XtraGrid.Columns.GridColumn colUnits;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
    }
}
