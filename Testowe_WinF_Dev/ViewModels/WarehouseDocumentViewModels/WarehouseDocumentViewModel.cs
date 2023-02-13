using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Testowe_WinF_Dev.DataModels.UnitOfWorks;
using Testowe_WinF_Dev.Models;
using Testowe_WinF_Dev.ViewModels.WarehouseViewModels;

namespace Testowe_WinF_Dev.ViewModels.WarehouseDocumentViewModels
{
    [POCOViewModel]
    public class WarehouseDocumentViewModel : BaseViewModel<WarehouseDocument, Warehouse, WarehouseDocumentUnitOfWork>
    {
        WarehouseDocumentUnitOfWork _unitOfWork;
        public virtual Warehouse CurrentWarehouse { get; set; }
        //public virtual ObservableCollection<WarehouseDocument> WarehouseDocuments { get; set; }
        //Filtering
        private bool filterIsArchieved = false;
        private long filterId = -1;
        public WarehouseDocumentViewModel() : base()
        {
            _unitOfWork = WarehouseDocumentUnitOfWork.Create();
            base.SetUnitOfWork(_unitOfWork, _unitOfWork.WarehouseDocumentRepository, _unitOfWork.WarehouseRepository);
        }
        public WarehouseDocumentViewModel(Warehouse warehouse) : this()
        {
            CurrentWarehouse = warehouse;
            //WarehouseDocuments = Source;
        }


        public void Edit(object item)
        {
            if (item == null) return;

            var Selected = item as WarehouseDocument;
            var dbItem = Get(Selected.ID);

            if (dbItem == null) return;
            if(CurrentWarehouse == null)
            {
                MessageService.ShowMessage("Please select the Warehouse First!");
                return;
            }

            var viewModel = WarehouseDocumentEditViewModel.Create(
                    dbItem,
                    UpdateResult,
                    IssueDocument,
                    _unitOfWork.WarehouseItemRepository
                        .GetWhere(w => w.UnitsLeft > 0 && w.WarehouseID == CurrentWarehouse.ID),
                    isAdding:false);
            ((ISupportParentViewModel)viewModel).ParentViewModel = this;
            CreateDocument(viewName: "WarehouseDocumentEditView", title: $"Warehouse({dbItem.Name})", viewModel: viewModel);

        }
        /// <summary>
        /// Create New EditView Document.
        /// </summary>
        public void New()
        {
            if (CurrentWarehouse == null)
            {
                MessageService.ShowMessage("Please select the Warehouse First!");
                return;
            }

            var item = new WarehouseDocument() { Warehouse = CurrentWarehouse, WarehouseID = CurrentWarehouse.ID};
            var viewModel = WarehouseDocumentEditViewModel.Create(
                item,
                InsertResult,
                IssueDocument,
                _unitOfWork.WarehouseItemRepository
                    .GetWhere(w => w.UnitsLeft > 0 && w.WarehouseID == CurrentWarehouse.ID),
                isAdding:true);
            ((ISupportParentViewModel)viewModel).ParentViewModel = this;
            CreateDocument(viewName: "WarehouseDocumentEditView", title: "New", viewModel: viewModel);
        }
        /// <summary>
        /// Only Issued or only Not Issued documents may be listed.
        /// </summary>
        /// <param name="CheckedObject"></param>
        /// <returns></returns>
        public object ChangeSourceArchieved(object CheckedObject)
        {
            if (CheckedObject == null) return null;

            filterIsArchieved = (bool)CheckedObject;

            FilterThis();

            return CheckedObject;
        }
        public Warehouse ChangeGridView(object ID)
        {
            if (ID == null)
            {
                base.Init();
                return null;
            }
            filterId = (long)ID;

            FilterThis();

            return ForeignSource.FirstOrDefault(w => w.ID == filterId);
        }

        private void FilterThis()
        {
            //if (filterId != -1)
            //{
            //    //WarehouseDocuments = Source.Where(e => e.WarehouseID == filterId).ToObservableCollection();
            //}
            //else
            //{
            //    WarehouseDocuments = Source;
            //}

            //if (filterIsArchieved)
            //    WarehouseDocuments = WarehouseDocuments.Where(w => w.DocunmentDate != null).ToObservableCollection();
            //else
            //{
            //    WarehouseDocuments = WarehouseDocuments.Where(w => w.DocunmentDate == null).ToObservableCollection();
            //}
            //SelectedEntity = WarehouseDocuments.FirstOrDefault();
            Source = GetItems(e =>
            ((filterId != -1)
                ? e.WarehouseID == filterId
                : true) &&
            ((filterIsArchieved)
                ? e.DocunmentDate != null
                : e.DocunmentDate == null)
            ).ToObservableCollection();

            SelectedEntity = Source.FirstOrDefault();
        }
        private Dictionary<WarehouseItem, int> GetDictionaryOfWarehouseItems(WarehouseDocument thisitem)
        {
            Dictionary<WarehouseItem, int> dict = new Dictionary<WarehouseItem, int>();
            var Orders = thisitem.OrderWarehouseItems;
            foreach (var Order in Orders)
            {
                if (!dict.ContainsKey(Order.WarehouseItem))
                    dict.Add(Order.WarehouseItem, Order.Units);
                else
                    dict[Order.WarehouseItem] += Order.Units;
            }
            return dict;
        }
        public override void Delete(WarehouseDocument thisitem)
        {
            try
            {
                if(thisitem == null)
                {
                    return;
                }
                if (thisitem.DocunmentDate != null)
                {
                    var dict = GetDictionaryOfWarehouseItems(thisitem);

                    foreach (var dictItem in dict)
                    {
                        var warehouseItem = dictItem.Key;
                        if (warehouseItem.UnitsAtBeginning < dictItem.Value)
                            warehouseItem.UnitsLeft = warehouseItem.UnitsAtBeginning;
                        else
                            warehouseItem.UnitsLeft += dictItem.Value;
                        _unitOfWork.WarehouseItemRepository.Update(warehouseItem);
                    }
                }
                base.Delete(thisitem);
                //WarehouseDocuments.Remove(thisitem);
            }
            catch(Exception ex)
            {
                MessageService.ShowMessage("Warehouse Items were changed! Please re-enter the view!");
            }
        }
        public bool IssueDocument(WarehouseDocument thisItem)
        {
            try
            {
                var dict = GetDictionaryOfWarehouseItems(thisItem);

                foreach (var dictItem in dict)
                {
                    var warehouseItem = dictItem.Key;
                    if (warehouseItem.UnitsLeft < dictItem.Value)
                        throw new Exception($"There's more units of {warehouseItem.Name} added to document that there is in Stocks! Can't Issue the document!");
                    else
                        warehouseItem.UnitsLeft -= dictItem.Value;
                    _unitOfWork.WarehouseItemRepository.Update(warehouseItem);
                }
            }
            catch (Exception ex)
            {
                MessageService.ShowMessage("Warehouse Items were changed! Please re-enter the view! " + ex.Message);
                return false;
            }
            return true;
        }
        public void Refresh()
        {
            _unitOfWork = WarehouseDocumentUnitOfWork.Create();
            base.SetUnitOfWork(_unitOfWork, _unitOfWork.WarehouseDocumentRepository, _unitOfWork.WarehouseRepository);
            base.Init();
            FilterThis();
            //WarehouseDocuments = Source;
        }

        internal long GetFirstItemId()
        {
            return (ForeignSource.Count > 0) ? ForeignSource.First().ID : -1;
        }
        protected override void InsertResult(WarehouseDocument item, object ID)
        {
            base.InsertResult(item, ID);
            FilterThis();
        }
        protected override void UpdateResult(WarehouseDocument item, object ID)
        {
            base.UpdateResult(item, ID);

            FilterThis();
        }
    }
}