namespace Testowe_WinF_Dev
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiWarehouse = new DevExpress.XtraBars.BarButtonItem();
            this.bbiItems = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDocs = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGitHubAPI = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.docButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationDocumentCaption = " ";
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiWarehouse,
            this.bbiItems,
            this.bbiDocs,
            this.bbiGitHubAPI});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 158);
            this.ribbonControl1.Merge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.ribbonControl1_Merge);
            // 
            // bbiWarehouse
            // 
            this.bbiWarehouse.Caption = "Warehouses";
            this.bbiWarehouse.Id = 1;
            this.bbiWarehouse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiWarehouse.ImageOptions.Image")));
            this.bbiWarehouse.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiWarehouse.ImageOptions.LargeImage")));
            this.bbiWarehouse.Name = "bbiWarehouse";
            // 
            // bbiItems
            // 
            this.bbiItems.Caption = "Items";
            this.bbiItems.Id = 2;
            this.bbiItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiItems.ImageOptions.Image")));
            this.bbiItems.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiItems.ImageOptions.LargeImage")));
            this.bbiItems.Name = "bbiItems";
            // 
            // bbiDocs
            // 
            this.bbiDocs.Caption = "Documents";
            this.bbiDocs.Id = 3;
            this.bbiDocs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDocs.ImageOptions.Image")));
            this.bbiDocs.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDocs.ImageOptions.LargeImage")));
            this.bbiDocs.Name = "bbiDocs";
            // 
            // bbiGitHubAPI
            // 
            this.bbiGitHubAPI.Id = 4;
            this.bbiGitHubAPI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.bbiGitHubAPI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.bbiGitHubAPI.Name = "bbiGitHubAPI";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Pages";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiWarehouse);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiItems);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDocs);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Navigation";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiGitHubAPI);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "GitHubAPI";
            // 
            // docButtonItem
            // 
            this.docButtonItem.Caption = "Documents";
            this.docButtonItem.Id = 6;
            this.docButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("docButtonItem.ImageOptions.Image")));
            this.docButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("docButtonItem.ImageOptions.LargeImage")));
            this.docButtonItem.Name = "docButtonItem";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.docButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Navigation";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterDocumentManagerService(null, false, this.tabbedView1)});
            this.mvvmContext1.ViewModelType = typeof(Testowe_WinF_Dev.ViewModels.MainViewModel);
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.LargeImage")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Warehouse Manager";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem docButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiWarehouse;
        private DevExpress.XtraBars.BarButtonItem bbiItems;
        private DevExpress.XtraBars.BarButtonItem bbiDocs;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.BarButtonItem bbiGitHubAPI;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}

