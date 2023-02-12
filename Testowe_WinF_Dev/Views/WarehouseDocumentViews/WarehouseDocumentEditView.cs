using DevExpress.Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testowe_WinF_Dev.ViewModels.WarehouseDocumentViewModels;
using Testowe_WinF_Dev.ViewModels.WarehouseItemViewModels;

namespace Testowe_WinF_Dev.Views.WarehouseDocumentViews
{
    public partial class WarehouseDocumentEditView : DevExpress.XtraEditors.XtraUserControl
    {
        public WarehouseDocumentEditView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBinding();
            if (!bbiExecute.Enabled)
                bbiExecute.Caption = "Document Issued!";
        }

        private void InitializeBinding()
        {
            var fluentAPI = mvvmContext1.OfType<WarehouseDocumentEditViewModel>();
            var viewModel = fluentAPI.ViewModel;
            bbiSave.Enabled = 
                sbAdd.Enabled = 
                    sbRemove.Enabled =
                        bbiExecute.Enabled = viewModel.Item.DocunmentDate != null;

            // Initializing OrderWarhouseItems Collection because constructor don't do it right way.
            viewModel.InitSource();
            fluentAPI.BindCommand(bbiSave, x => x.SaveThis);
            fluentAPI.BindCommand(bbiClose, x => x.Cancel);
            fluentAPI.BindCommand(sbAdd, x => x.AddOrder);
            fluentAPI.BindCommand(sbRemove, x => x.DeleteOrder);
            fluentAPI.BindCommand(bbiExecute, x => x.IssueDocument);

            fluentAPI.WithEvent<SelectionChangedEventArgs>(gridView1, "SelectionChanged")
                .SetBinding(x => x.SelectedOrder, e => fluentAPI.ViewModel.SetSelected(GetSelected()));

            fluentAPI.SetBinding(warehouseDocumentBindingSource, wbs => wbs.DataSource, x => x.Item);
            fluentAPI.SetBinding(gridControl1, wbs => wbs.DataSource, x => x.OrderWarehouseItems);
            fluentAPI.SetBinding(warehouseItemBindingSource, wbs => wbs.DataSource, x => x.ItemObjects);

        }
        public object GetSelected() => gridView1.GetSelectedRows()
            .Select(r => gridView1.GetRow(r))
            .FirstOrDefault();

        private void bbiExecute_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiExecute.Caption = "Document Issued!";
            bbiExecute.Enabled = false;
        }
    }
}
