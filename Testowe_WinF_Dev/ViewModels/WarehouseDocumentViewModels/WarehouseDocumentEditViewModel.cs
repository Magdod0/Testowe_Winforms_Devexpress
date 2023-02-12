using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Testowe_WinF_Dev.Models;
using Testowe_WinF_Dev.ViewModels.WarehouseItemViewModels;

namespace Testowe_WinF_Dev.ViewModels.WarehouseDocumentViewModels
{
    [POCOViewModel]
    public class WarehouseDocumentEditViewModel:BaseEditionViewModel<WarehouseDocument, WarehouseItem>
    {
        public virtual OrderWarehouseItem SelectedOrder { get; set; }
        public virtual ObservableCollection<OrderWarehouseItem> OrderWarehouseItems { get; set; }
        private Func<WarehouseDocument, bool> _IssueDocument;
        public WarehouseDocumentEditViewModel(WarehouseDocument item, Action<WarehouseDocument, object> result, Func<WarehouseDocument, bool> IssueDocument, ObservableCollection<WarehouseItem> warehouseItems, bool isAdding)
            :base(item, result, warehouseItems, isAdding)
        {
            _IssueDocument = IssueDocument;

        }

        internal static object Create(WarehouseDocument item, Action<WarehouseDocument, object> Result, Func<WarehouseDocument, bool> IssueDocument, ObservableCollection<WarehouseItem> warehouseItems, bool isAdding) =>
           ViewModelSource.Create(() => new WarehouseDocumentEditViewModel(item, Result, IssueDocument, warehouseItems, isAdding));
        /// <summary>
        /// Search for items that wasn't added yet in this Order.
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<WarehouseItem> CanOrderNextWarehouseItems()
        {
            ObservableCollection<WarehouseItem> CanOrder = new ObservableCollection<WarehouseItem>();
            var ItemsFromHere = ItemObjects.Where(w => w.WarehouseID == Item.WarehouseID);
            bool IsInList = false;

            foreach (var itemObject in ItemsFromHere)
            {
                IsInList = false;
                foreach (var currentItem in OrderWarehouseItems)
                {
                    if (itemObject.ID == currentItem.WarehouseItemID)
                    {
                        IsInList = true;
                        break;
                    }
                }
                if (!IsInList)
                {
                    CanOrder.Add(itemObject);
                }
            }
            return CanOrder;
        }
        /// <summary>
        /// Create new document to add warehouse items in warehouse order.
        /// </summary>
        public void AddOrder()
        {
            var orderItem = new OrderWarehouseItem() { WarehouseDocument = Item, WarehouseDocumentID = Item.ID, OrderDate = DateTime.Now };

            var CanOrderNextItems = CanOrderNextWarehouseItems();

            var viewModel = OrderWarehouseItemEditViewModel.Create(orderItem, AddItem, CanOrderNextItems, isAdding:true);
            ((ISupportParentViewModel)viewModel).ParentViewModel = this;
            CreateDocument(viewName: "OrderWarehouseItemEditView", title: "New", viewModel: viewModel);
        }
        /// <summary>
        /// Adding Item in Current Order List.
        /// </summary>
        /// <param name="orderItem"></param>
        /// <param name="ID"></param>
        public void AddItem(OrderWarehouseItem orderItem, object ID)
        {
            if (orderItem != null)
            {
                OrderWarehouseItems.Add(orderItem);
            }
        }
        public void DeleteOrder()
        {
            OrderWarehouseItems.Remove(SelectedOrder);
        }
        public void InitSource()
        {
            OrderWarehouseItems = (Item.OrderWarehouseItems == null)
                ? new ObservableCollection<OrderWarehouseItem>()
                : new ObservableCollection<OrderWarehouseItem>(Item.OrderWarehouseItems);
        }

        internal OrderWarehouseItem SetSelected(object selectedObject)
        {
            if (selectedObject == null) return null;

            return (OrderWarehouseItem)selectedObject;
        }
        /// <summary>
        /// Issue current document.
        /// </summary>
        public void IssueDocument()
        {
            Item.OrderWarehouseItems = OrderWarehouseItems;
            // Set Date if Issue operation ended successfully.
            if(_IssueDocument(Item))
                Item.DocunmentDate = DateTime.Now;
        }
        public void SaveThis()
        {
            Item.OrderWarehouseItems = OrderWarehouseItems;
            Item.CreatedDate = DateTime.Now;
            base.Save(Item.ID);
        }
    }
}