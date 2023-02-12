using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Testowe_WinF_Dev.Views
{
    public partial class WarehouseItemView : DevExpress.XtraEditors.XtraUserControl
    {
        public WarehouseItemView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
            {
                InitializeBindings();
            }
        }
        private void InitializeBindings()
        {
            var fluentAPI = mvvmContext1.OfType<WarehouseItemViewModel>();
            // Getting the VewModel.
            var viewModel = fluentAPI.ViewModel;
            viewModel.Init();
            // Source.
            fluentAPI.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Source);
            fluentAPI.SetBinding(warehouseBindingSource, wbs => wbs.DataSource, x => x.ForeignSource);
            // Commands.
            fluentAPI.BindCommand(bbiNew, x => x.New);
            fluentAPI.BindCommand(bbiRefresh, x => x.Refresh);
            fluentAPI.BindCommand(bbiEdit, x => x.Edit(null), x => x.SelectedEntity);
            fluentAPI.BindCommand(bbiDelete, x => x.Delete(null), x => x.SelectedEntity);
            // Events.
            fluentAPI.WithEvent<SelectionChangedEventArgs>(gridView1, "SelectionChanged")
                .SetBinding(x => x.SelectedEntity, e => viewModel.SetSelected(GetSelected()));
            fluentAPI.WithEvent<RowCellClickEventArgs>(gridView1, "RowCellClick")
                .EventToCommand(
                    x => x.Edit(null), x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

        }
        public object GetSelected() => gridView1.GetSelectedRows()
            .Select(r => gridView1.GetRow(r) as Models.WarehouseItem)
            .FirstOrDefault();
    }
}
