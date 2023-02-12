namespace Testowe_WinF_Dev.Views.WarehouseItemViews
{
    partial class WarehouseItemEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseItemEditView));
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.teWarehouseName = new DevExpress.XtraEditors.TextEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.warehouseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teUnitsAtBegining = new DevExpress.XtraEditors.SpinEdit();
            this.teArrivalDate = new DevExpress.XtraEditors.DateEdit();
            this.teBrutto = new DevExpress.XtraEditors.SpinEdit();
            this.teNetto = new DevExpress.XtraEditors.SpinEdit();
            this.teUnitsLeft = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teWarehouseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUnitsAtBegining.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teArrivalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teArrivalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBrutto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNetto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUnitsLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Testowe_WinF_Dev.ViewModels.WarehouseItemViewModels.WarehouseItemEditViewModel);
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
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(395, 150);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Warehouse Item";
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
            this.dataLayoutControl1.Controls.Add(this.teWarehouseName);
            this.dataLayoutControl1.Controls.Add(this.teName);
            this.dataLayoutControl1.Controls.Add(this.teUnitsAtBegining);
            this.dataLayoutControl1.Controls.Add(this.teArrivalDate);
            this.dataLayoutControl1.Controls.Add(this.teBrutto);
            this.dataLayoutControl1.Controls.Add(this.teNetto);
            this.dataLayoutControl1.Controls.Add(this.teUnitsLeft);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 150);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(395, 208);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // teWarehouseName
            // 
            this.teWarehouseName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teWarehouseName.Location = new System.Drawing.Point(109, 36);
            this.teWarehouseName.MenuManager = this.ribbonControl1;
            this.teWarehouseName.Name = "teWarehouseName";
            this.teWarehouseName.Properties.ReadOnly = true;
            this.teWarehouseName.Size = new System.Drawing.Size(274, 20);
            this.teWarehouseName.StyleController = this.dataLayoutControl1;
            this.teWarehouseName.TabIndex = 5;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.Warehouse);
            // 
            // teName
            // 
            this.teName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseItemBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teName.Location = new System.Drawing.Point(109, 12);
            this.teName.MenuManager = this.ribbonControl1;
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(274, 20);
            this.teName.StyleController = this.dataLayoutControl1;
            this.teName.TabIndex = 4;
            // 
            // warehouseItemBindingSource
            // 
            this.warehouseItemBindingSource.DataSource = typeof(Testowe_WinF_Dev.Models.WarehouseItem);
            // 
            // teUnitsAtBegining
            // 
            this.teUnitsAtBegining.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseItemBindingSource, "UnitsAtBeginning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teUnitsAtBegining.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.teUnitsAtBegining.Location = new System.Drawing.Point(109, 60);
            this.teUnitsAtBegining.MenuManager = this.ribbonControl1;
            this.teUnitsAtBegining.Name = "teUnitsAtBegining";
            this.teUnitsAtBegining.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teUnitsAtBegining.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.teUnitsAtBegining.Properties.MaskSettings.Set("mask", "d");
            this.teUnitsAtBegining.Properties.MaxValue = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.teUnitsAtBegining.Size = new System.Drawing.Size(274, 20);
            this.teUnitsAtBegining.StyleController = this.dataLayoutControl1;
            this.teUnitsAtBegining.TabIndex = 6;
            this.teUnitsAtBegining.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teUnitsAtBegining_EditValueChanging);
            // 
            // teArrivalDate
            // 
            this.teArrivalDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseItemBindingSource, "ArrivalDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teArrivalDate.EditValue = null;
            this.teArrivalDate.Location = new System.Drawing.Point(109, 176);
            this.teArrivalDate.MenuManager = this.ribbonControl1;
            this.teArrivalDate.Name = "teArrivalDate";
            this.teArrivalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teArrivalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teArrivalDate.Properties.DisplayFormat.FormatString = "";
            this.teArrivalDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teArrivalDate.Properties.EditFormat.FormatString = "";
            this.teArrivalDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teArrivalDate.Properties.MaskSettings.Set("mask", "G");
            this.teArrivalDate.Size = new System.Drawing.Size(274, 20);
            this.teArrivalDate.StyleController = this.dataLayoutControl1;
            this.teArrivalDate.TabIndex = 10;
            // 
            // teBrutto
            // 
            this.teBrutto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseItemBindingSource, "Brutto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teBrutto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.teBrutto.Location = new System.Drawing.Point(109, 132);
            this.teBrutto.MenuManager = this.ribbonControl1;
            this.teBrutto.Name = "teBrutto";
            this.teBrutto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teBrutto.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.teBrutto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.teBrutto.Properties.MaskSettings.Set("mask", "c");
            this.teBrutto.Size = new System.Drawing.Size(274, 20);
            this.teBrutto.StyleController = this.dataLayoutControl1;
            this.teBrutto.TabIndex = 9;
            // 
            // teNetto
            // 
            this.teNetto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseItemBindingSource, "Netto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teNetto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.teNetto.Location = new System.Drawing.Point(109, 108);
            this.teNetto.MenuManager = this.ribbonControl1;
            this.teNetto.Name = "teNetto";
            this.teNetto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teNetto.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.teNetto.Properties.MaskSettings.Set("mask", "c");
            this.teNetto.Size = new System.Drawing.Size(274, 20);
            this.teNetto.StyleController = this.dataLayoutControl1;
            this.teNetto.TabIndex = 8;
            // 
            // teUnitsLeft
            // 
            this.teUnitsLeft.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warehouseItemBindingSource, "UnitsLeft", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teUnitsLeft.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.teUnitsLeft.Location = new System.Drawing.Point(109, 84);
            this.teUnitsLeft.MenuManager = this.ribbonControl1;
            this.teUnitsLeft.Name = "teUnitsLeft";
            this.teUnitsLeft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teUnitsLeft.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.teUnitsLeft.Properties.MaskSettings.Set("mask", "d");
            this.teUnitsLeft.Properties.ReadOnly = true;
            this.teUnitsLeft.Size = new System.Drawing.Size(274, 20);
            this.teUnitsLeft.StyleController = this.dataLayoutControl1;
            this.teUnitsLeft.TabIndex = 7;
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
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(395, 208);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teName;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(375, 20);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teWarehouseName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem2.Text = "Warehouse Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teUnitsAtBegining;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem3.Text = "Units Arrived";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teUnitsLeft;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem4.Text = "Units Left";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.teArrivalDate;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 164);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem7.Text = "Arrival Date";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.teNetto;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem5.Text = "Netto";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.teBrutto;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem6.Text = "Brutto";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(85, 13);
            // 
            // WarehouseItemEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "WarehouseItemEditView";
            this.Size = new System.Drawing.Size(395, 358);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teWarehouseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUnitsAtBegining.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teArrivalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teArrivalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBrutto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNetto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUnitsLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit teWarehouseName;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.SpinEdit teUnitsAtBegining;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource warehouseItemBindingSource;
        private DevExpress.XtraEditors.DateEdit teArrivalDate;
        private DevExpress.XtraEditors.SpinEdit teBrutto;
        private DevExpress.XtraEditors.SpinEdit teNetto;
        private DevExpress.XtraEditors.SpinEdit teUnitsLeft;
    }
}
