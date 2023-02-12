using DevExpress.Data;
using DevExpress.Utils.MVVM.Services;
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
using Testowe_WinF_Dev.ViewModels.WarehouseViewModels;

namespace Testowe_WinF_Dev.Views
{
    public partial class WarehouseView : DevExpress.XtraEditors.XtraUserControl
    {
        public WarehouseView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
            {
                InitializeBindings();
            }
            gridView1.Columns["Products"].Visible = false;
        }

        private void InitializeBindings()
        {
            var fluentAPI = mvvmContext1.OfType<WarehouseViewModel>();
            // Getting the Source
            fluentAPI.ViewModel.Init();

            fluentAPI.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Source);

            fluentAPI.BindCommand(bbiNew, x => x.New);
            fluentAPI.BindCommand(bbiRefresh, x => x.Refresh);
            fluentAPI.BindCommand(bbiEdit, x => x.Edit(null), x => x.SelectedEntity);
            fluentAPI.BindCommand(bbiDelete, x => x.Delete(null), x => x.SelectedEntity);

            fluentAPI.WithEvent<SelectionChangedEventArgs>(gridView1, "SelectionChanged")
                .SetBinding(x => x.SelectedEntity, e => fluentAPI.ViewModel.SetSelected(GetSelected()));
            fluentAPI.WithEvent<RowCellClickEventArgs>(gridView1, "RowCellClick")
                .EventToCommand(
                    x => x.Edit(null), x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
            
        }
        public object GetSelected() => gridView1.GetSelectedRows()
            .Select(r => gridView1.GetRow(r))
            .FirstOrDefault();
    }
}
