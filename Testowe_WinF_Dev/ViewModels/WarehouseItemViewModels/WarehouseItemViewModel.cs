using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.Extensions;
using System;
using Testowe_WinF_Dev.DataModels.UnitOfWorks;
using Testowe_WinF_Dev.Models;
using Testowe_WinF_Dev.ViewModels.WarehouseViewModels;

namespace Testowe_WinF_Dev.ViewModels.WarehouseItemViewModels
{
    [POCOViewModel]
    public class WarehouseItemViewModel:BaseViewModel<WarehouseItem, Warehouse, WarehouseUnitOfWork>
    {
        WarehouseUnitOfWork warehouseUnitOfWork;
        public WarehouseItemViewModel():base()
        {
            warehouseUnitOfWork = WarehouseUnitOfWork.Create();
            base.SetUnitOfWork(warehouseUnitOfWork, warehouseUnitOfWork.WarehouseItemRepository, warehouseUnitOfWork.WarehouseRepository);
        }
        public void Edit(object item)
        {
            if (item == null) return;

            var Selected = item as WarehouseItem;
            var dbItem = Get(Selected.ID);

            if (dbItem == null) return;

            var viewModel = WarehouseItemEditViewModel.Create(dbItem, UpdateResult, IsAdding:false);
            ((ISupportParentViewModel)viewModel).ParentViewModel = this;
            CreateDocument(viewName: "WarehouseItemEditView", title: $"Warehouse({dbItem.Name})", viewModel: viewModel);

        }
        public void New()
        {
            var item = new WarehouseItem() { ArrivalDate = DateTime.Now };
            var viewModel = WarehouseItemEditViewModel.Create(item, InsertResult, IsAdding: true);
            ((ISupportParentViewModel)viewModel).ParentViewModel = this;
            CreateDocument(viewName: "WarehouseItemEditView", title: "New", viewModel: viewModel);
        }
        public void Refresh()
        {
            warehouseUnitOfWork = WarehouseUnitOfWork.Create();
            base.SetUnitOfWork(warehouseUnitOfWork, warehouseUnitOfWork.WarehouseItemRepository, warehouseUnitOfWork.WarehouseRepository);
            base.Init();
        }
    }
}