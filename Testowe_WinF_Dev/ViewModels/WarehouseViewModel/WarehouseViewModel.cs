using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.Utils.MVVM.Services;
using System.Collections;
using Testowe_WinF_Dev.Models;
using Testowe_WinF_Dev.DataModels.UnitOfWorks;
using System;

namespace Testowe_WinF_Dev.ViewModels.WarehouseViewModels
{
    [POCOViewModel]
    public class WarehouseViewModel:BaseViewModel<Warehouse, Warehouse, WarehouseUnitOfWork>
    {
        WarehouseUnitOfWork _unitOfWork;
        public WarehouseViewModel():base()
        {
            _unitOfWork = WarehouseUnitOfWork.Create();
            base.SetUnitOfWork(_unitOfWork, _unitOfWork.WarehouseRepository, null);
        }
        public void Edit(object item)
        {
            if (item == null) return;

            var Selected = item as Warehouse;
            var dbItem = Get(Selected.ID);

            if (dbItem == null) return;

            var viewModel = WarehouseEditViewModel.Create(dbItem, UpdateResult, _unitOfWork.WarehouseItemRepository.GetWhere(w => w.WarehouseID == null), isAdding:false);
            ((ISupportParentViewModel)viewModel).ParentViewModel = this;
            CreateDocument(viewName: "WarehouseEditView", title: $"Warehouse({dbItem.Name})", viewModel: viewModel);

        }
        public void New()
        {
            var item = new Warehouse();
            var viewModel = WarehouseEditViewModel.Create(item, InsertResult, _unitOfWork.WarehouseItemRepository.GetWhere(w=> w.WarehouseID == null), isAdding:true);
            ((ISupportParentViewModel)viewModel).ParentViewModel = this;
            CreateDocument(viewName: "WarehouseEditView", title: "New", viewModel: viewModel);
        }
        public void Refresh()
        {
            _unitOfWork = WarehouseUnitOfWork.Create();
            base.SetUnitOfWork(_unitOfWork, _unitOfWork.WarehouseRepository, null);
            base.Init();
        }
    }
}