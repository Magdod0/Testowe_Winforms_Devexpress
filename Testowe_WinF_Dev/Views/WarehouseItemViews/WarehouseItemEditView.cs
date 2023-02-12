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
using Testowe_WinF_Dev.ViewModels.WarehouseItemViewModels;
using Testowe_WinF_Dev.ViewModels.WarehouseViewModels;

namespace Testowe_WinF_Dev.Views.WarehouseItemViews
{
    public partial class WarehouseItemEditView : DevExpress.XtraEditors.XtraUserControl
    {
        private bool IsAdding;
        public WarehouseItemEditView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBinding();
        }

        private void InitializeBinding()
        {
            var fluentAPI = mvvmContext1.OfType<WarehouseItemEditViewModel>();
            IsAdding = fluentAPI.ViewModel.getCurrentOperation();

            fluentAPI.BindCommand(bbiSave, x => x.SaveThis);
            fluentAPI.BindCommand(bbiClose, x => x.Cancel);

            fluentAPI.SetBinding(warehouseItemBindingSource, wbs => wbs.DataSource, x => x.Item);
            if (!IsAdding && fluentAPI.ViewModel.Item.Warehouse != null)
            {
                fluentAPI.SetBinding(warehouseBindingSource, wbs => wbs.DataSource, x => x.Item.Warehouse);
            }
        }

        private void teUnitsAtBegining_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (IsAdding)
            {
                teUnitsLeft.Text = e.NewValue.ToString();
            }
        }
    }
}
