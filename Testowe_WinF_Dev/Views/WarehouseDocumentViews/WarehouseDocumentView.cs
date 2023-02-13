using DevExpress.Data;
using DevExpress.XtraBars;
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
using Testowe_WinF_Dev.ViewModels.WarehouseDocumentViewModels;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Testowe_WinF_Dev.Models;

namespace Testowe_WinF_Dev.Views
{
    public partial class WarehouseDocumentView : DevExpress.XtraEditors.XtraUserControl
    {
        WarehouseDocumentViewModel viewModel;
        public WarehouseDocumentView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
            {
                InitializeBindings();
            }
        }
        private void InitializeBindings()
        {
            var fluentAPI = mvvmContext1.OfType<WarehouseDocumentViewModel>();
            // Getting the VewModel.
            viewModel = fluentAPI.ViewModel;
            viewModel.Init();
            // Source.
            fluentAPI.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Source);
            fluentAPI.SetBinding(warehouseDocumentBindingSource, wdbs => wdbs.DataSource, x => x.CurrentWarehouse);
            fluentAPI.SetBinding(warehouseBindingSource, wbs => wbs.DataSource, x => x.ForeignSource);
            // Commands.
            fluentAPI.BindCommand(bbiNew, x => x.New);
            fluentAPI.BindCommand(bbiRefresh, x => x.Refresh);

            fluentAPI.BindCommand(bbiEdit, x => x.Edit(null), x => x.SelectedEntity);
            fluentAPI.BindCommand(bbiDelete, x => x.Delete(null), x => x.SelectedEntity);
            // Events.
            fluentAPI.WithEvent<ChangingEventArgs>(repositoryItemLookUpEdit2, "EditValueChanging")
                .SetBinding(x => x.CurrentWarehouse, e => viewModel.ChangeGridView(e.NewValue));
            fluentAPI.WithEvent<SelectionChangedEventArgs>(gridView1, "SelectionChanged")
                .SetBinding(x => x.SelectedEntity, e => viewModel.SetSelected(GetSelected()));
            fluentAPI.WithEvent<RowCellClickEventArgs>(gridView1, "RowCellClick")
                .EventToCommand(
                    x => x.Edit(null), x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

            var id = viewModel.GetFirstItemId();
            if (id != -1)
                beiWarehouse.EditValue = id;

            viewModel.CurrentWarehouse = viewModel.ChangeGridView(id);
        }
        public object GetSelected() => gridView1.GetSelectedRows()
            .Select(r => gridView1.GetRow(r))
            .FirstOrDefault();


        private bool btsiArchieved_Checked()
        {
            bbiNew.Enabled = !btsiArchieved.Checked;
            return btsiArchieved.Checked;
        }

        private void btsiArchieved_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            bbiNew.Enabled = !btsiArchieved.Checked;
            viewModel.ChangeSourceArchieved(btsiArchieved.Checked);
        }

        private void repositoryItemLookUpEdit2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void repositoryItemLookUpEdit2_QueryPopUp(object sender, CancelEventArgs e)
        {
            var rile = sender as LookUpEdit;
            rile.Properties.PopulateColumns();
            rile.Properties.Columns[0].Visible =
                rile.Properties.Columns[3].Visible = false;
        }
    }
}
