using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Testowe_WinF_Dev.Models;

namespace Testowe_WinF_Dev.ViewModels.WarehouseDocumentViewModels
{
    [POCOViewModel]
    public class OrderWarehouseItemEditViewModel:BaseEditionViewModel<OrderWarehouseItem, WarehouseItem>
    {
        public virtual WarehouseItem ItemWithUnits { get; set; }
        public OrderWarehouseItemEditViewModel(OrderWarehouseItem orderItem, Action<OrderWarehouseItem, object> resultAction, ObservableCollection<WarehouseItem> warehouseItems, bool isAdding)
            :base(orderItem, resultAction, warehouseItems,isAdding) {
            ItemWithUnits = new WarehouseItem();

        }

        internal static object Create(OrderWarehouseItem orderItem, Action<OrderWarehouseItem, object> resultAction, ObservableCollection<WarehouseItem> warehouseItems, bool isAdding) =>
           ViewModelSource.Create(() => new OrderWarehouseItemEditViewModel(orderItem, resultAction, warehouseItems, isAdding));

        public void SaveThis()
        {
            var subItem = ItemObjects.FirstOrDefault(w => w.ID == Item.WarehouseItemID);
            if(subItem == null)
            {
                MessageService.ShowMessage("Nothing to add!");
                return;
            }
            Item.WarehouseItem = subItem;
            if (Item.Units <= Item.WarehouseItem.UnitsLeft)
                base.Save(Item.ID);
            else
                MessageService.ShowMessage("Can't add more units than what is left");
        }
        public long GetFirstItemId() => (ItemObjects.Count > 0) ? ItemObjects.First().ID : -1;

        internal long SetVlaue(object newValue)
        {
            var value = (long)newValue;
            ItemWithUnits = ItemObjects.FirstOrDefault(w => w.ID == value) ?? new WarehouseItem();
            return value;
        }
    }
}