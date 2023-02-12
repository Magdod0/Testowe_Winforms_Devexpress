using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
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
using Testowe_WinF_Dev.ViewModels.WarehouseViewModels;
using DevExpress.Mvvm.POCO;

namespace Testowe_WinF_Dev.Views.WarehouseViews
{
    public partial class WarehouseEditView : DevExpress.XtraEditors.XtraUserControl
    {
        MVVMContextFluentAPI<WarehouseEditViewModel> fluentAPI;
        public WarehouseEditView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBinding();

        }

        private void InitializeBinding()
        {
            fluentAPI = mvvmContext1.OfType<WarehouseEditViewModel>();
            fluentAPI.BindCommand(bbiSave, x => x.SaveThis);
            fluentAPI.BindCommand(bbiClose, x => x.Cancel);

            fluentAPI.SetBinding(warehouseBindingSource, wbs => wbs.DataSource, x => x.Item);
            fluentAPI.SetBinding(warehouseItemBindingSource, wbs => wbs.DataSource, x => x.ItemObjects);
            fluentAPI.SetBinding(bsWarehouseContainItems, wbs => wbs.DataSource, x => x.Item.Products);
        }

        private void sbAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teItems.Text)) return;

            fluentAPI.ViewModel.AddItemObject((long)teItems.EditValue);
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedIndex < 0) return;

            fluentAPI.ViewModel.RemoveItemObject((long)listBoxControl1.SelectedValue);
            listBoxControl1.Items.Remove(listBoxControl1.SelectedItem);
        }
    }
}
