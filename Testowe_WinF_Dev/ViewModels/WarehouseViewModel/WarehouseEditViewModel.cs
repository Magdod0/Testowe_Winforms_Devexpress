using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Testowe_WinF_Dev.DataModels.UnitOfWorks;
using Testowe_WinF_Dev.Models;

namespace Testowe_WinF_Dev.ViewModels.WarehouseViewModels
{
    [POCOViewModel]
    public class WarehouseEditViewModel: BaseEditionViewModel<Warehouse, WarehouseItem>
    {

        public WarehouseEditViewModel():base()
        {

        }

        public WarehouseEditViewModel(Warehouse item, Action<Warehouse, object> result, ObservableCollection<WarehouseItem> warehouseItems, bool isAdding) :base(item, result, warehouseItems, isAdding)
        {
        }
        public static WarehouseEditViewModel Create() => ViewModelSource.Create(() => new WarehouseEditViewModel());
        public static WarehouseEditViewModel Create(Warehouse item, Action<Warehouse, object> Result, ObservableCollection<WarehouseItem> warehouseItems, bool isAdding) =>
            ViewModelSource.Create(() => new WarehouseEditViewModel(item, Result, warehouseItems, isAdding));

        public void AddItemObject(long itemID)
        {
            var itemObject = base.ItemObjects.FirstOrDefault(wi=> wi.ID == itemID);
            Item.Products.Add(itemObject);
        }
        public void RemoveItemObject(long itemID)
        {
            var itemObject = base.Item.Products.FirstOrDefault(wi => wi.ID == itemID);
            Item.Products.Remove(itemObject);
        }
        public void SaveThis()
        {
            base.Save(Item.ID);
        }
    }
}