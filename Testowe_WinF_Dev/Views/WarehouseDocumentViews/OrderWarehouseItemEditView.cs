using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class OrderWarehouseItemEditView : DevExpress.XtraEditors.XtraUserControl
    {
        public OrderWarehouseItemEditView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBinding();
        }

        private void InitializeBinding()
        {
            var fluentAPI = mvvmContext1.OfType<OrderWarehouseItemEditViewModel>();

            var viewModel = fluentAPI.ViewModel;

            fluentAPI.BindCommand(bbiSave, x => x.SaveThis);
            fluentAPI.BindCommand(bbiClose, x => x.Cancel);

            fluentAPI.WithEvent<ChangingEventArgs>(textEdit1, "EditValueChanging")
                   .SetBinding(x => x.Item.WarehouseItemID, e => e.NewValue);

            fluentAPI.SetBinding(warehouseItemBindingSource, wbs => wbs.DataSource, x => x.ItemObjects);
            fluentAPI.SetBinding(orderWarehouseItemBindingSource, wbs => wbs.DataSource, x => x.Item);

            var id = viewModel.GetFirstItemId();
            if(id != -1)
                textEdit1.EditValue = id;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teUnitsTake.Text)) return;

            teUnitsTake.Properties.MaxValue = Convert.ToInt32(teUnitsTake.Text);
        }

        private void textEdit1_QueryPopUp(object sender, CancelEventArgs e)
        {
            var textEdit = sender as LookUpEdit;
            textEdit.Properties.PopulateColumns();
            textEdit.Properties.Columns[0].Visible =
                textEdit.Properties.Columns[1].Visible =
                    textEdit.Properties.Columns[2].Visible = false;
        }
    }
}
