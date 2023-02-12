using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Testowe_WinF_Dev.ViewModels;

namespace Testowe_WinF_Dev
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        private void InitializeBindings()
        {
            var fluentAPI = mvvmContext1.OfType<MainViewModel>();
            fluentAPI.WithEvent(this, "Load")
              .EventToCommand(x => x.OnLogin);

            fluentAPI.BindCommand(bbiWarehouse, x => x.FindWarehouseView);
            fluentAPI.BindCommand(bbiItems, x => x.FindWarehouseItemView);
            fluentAPI.BindCommand(bbiDocs, x => x.FindWarehouseDocumentView);

            fluentAPI.SetTrigger(x => x.State, (state) =>
            {
                if (state == AppState.ExitQueued)
                    this.Close();
            });
        }

        private void ribbonControl1_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            var ribbon = sender as RibbonControl;
            ribbon.SelectPage(e.MergedChild.SelectedPage);
        }
    }
}
