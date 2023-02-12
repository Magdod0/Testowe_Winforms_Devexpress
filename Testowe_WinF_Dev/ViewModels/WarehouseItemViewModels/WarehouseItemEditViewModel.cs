using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using Testowe_WinF_Dev.Models;
using Testowe_WinF_Dev.ViewModels.WarehouseViewModels;

namespace Testowe_WinF_Dev.ViewModels.WarehouseItemViewModels
{
    [POCOViewModel]
    public class WarehouseItemEditViewModel : BaseEditionViewModel<WarehouseItem, Warehouse>
    {
        public WarehouseItemEditViewModel(WarehouseItem dbItem, Action<WarehouseItem, object> result, bool IsAdding):base(dbItem, result, null, IsAdding)
        {
        }

        internal static object Create(WarehouseItem dbItem, Action<WarehouseItem, object> Result, bool IsAdding) =>
            ViewModelSource.Create(() => new WarehouseItemEditViewModel(dbItem, Result, IsAdding));
        public void SaveThis()
        {
            base.Save(Item.ID);
        }
        public bool getCurrentOperation() => IsAdding;

    }
}