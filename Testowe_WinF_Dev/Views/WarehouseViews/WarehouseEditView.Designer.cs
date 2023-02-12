namespace Testowe_WinF_Dev.Views.WarehouseViews
{
    partial class WarehouseEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseEditView));
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.bsWarehouseContainItems = new System.Windows.Forms.BindingSource(this.components);
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.teItems = new DevExpress.XtraEditors.LookUpEdit();
            this.warehouseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWarehouseContainItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Testowe_WinF_Dev.ViewModels.WarehouseViewModels.WarehouseEditViewModel);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 3;
            this.bbiClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiClose.ImageOptions.Image")));
            this.bbiClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiClose.ImageOptions.LargeImage")));
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.Image")));
            this.bbiSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.LargeImage")));
            this.bbiSave.Name = "bbiSave";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiSave,
            this.bbiClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(424, 150);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.listBoxControl1);
            this.dataLayoutControl1.Controls.Add(this.sbAdd);
            this.dataLayoutControl1.Controls.Add(this.sbDelete);
            this.dataLayoutControl1.Controls.Add(this.textEdit2);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.Controls.Add(this.teItems);
            this.dataLayoutControl1.DataSource = this.warehouseBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 150);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(471, 67, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(424, 210);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = this.bsWarehouseContainItems;
            this.listBoxControl1.DisplayMember = "Name";
            this.listBoxControl1.Location = new System.Drawing.Point(12, 86);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(400, 86);
            this.listBoxControl1.StyleController = this.dataLayoutControl1;
            this.listBoxControl1.TabIndex = 9;
            this.listBoxControl1.ValueMember = "ID";
            // 
            // bsWarehouseContainItems
            // 
            this.bsWarehouseContainItems.DataSource = typeof(Testowe_WinF_Dev.Models.WarehouseItem);
            // 
            // sbAdd
            // 
            this.sbAdd.Location = new System.Drawing.Point(335, 60);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(77, 22);
            this.sbAdd.StyleController = this.dataLayoutControl1;
            this.sbAdd.TabIndex = 8;
            this.sbAdd.Text = "Add";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sbDelete.Location = new System.Drawing.Point(12, 176);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(400, 22);
            this.sbDelete.StyleController = this.dataLayoutControl1;
            this.sbDelete.TabIndex = 7;
            this.sbDelete.Text = "Delete";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseBindingSource, "Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit2.Location = new System.Drawing.Point(63, 36);
            this.textEdit2.MenuManager = this.ribbonControl1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(349, 20);
            this.textEdit2.StyleController = this.dataLayoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.Warehouse);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit1.Location = new System.Drawing.Point(63, 12);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(349, 20);
            this.textEdit1.StyleController = this.dataLayoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // teItems
            // 
            this.teItems.Location = new System.Drawing.Point(63, 60);
            this.teItems.MenuManager = this.ribbonControl1;
            this.teItems.Name = "teItems";
            this.teItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teItems.Properties.DataSource = this.warehouseItemBindingSource;
            this.teItems.Properties.DisplayMember = "Name";
            this.teItems.Properties.NullText = "";
            this.teItems.Properties.ValueMember = "ID";
            this.teItems.Size = new System.Drawing.Size(268, 20);
            this.teItems.StyleController = this.dataLayoutControl1;
            this.teItems.TabIndex = 6;
            // 
            // warehouseItemBindingSource
            // 
            this.warehouseItemBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.WarehouseItem);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(424, 210);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(404, 24);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(404, 24);
            this.layoutControlItem2.Text = "Address";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teItems;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(323, 26);
            this.layoutControlItem3.Text = "Items";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbAdd;
            this.layoutControlItem5.Location = new System.Drawing.Point(323, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(81, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.listBoxControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(404, 90);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 164);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(404, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // WarehouseEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "WarehouseEditView";
            this.Size = new System.Drawing.Size(424, 360);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWarehouseContainItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LookUpEdit teItems;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource warehouseItemBindingSource;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource bsWarehouseContainItems;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
