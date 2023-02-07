using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;


namespace Testowe_Winforms_Devexpress.ViewModels.Storages
{
    public class StorageListViewModel
    {
        StorageDbContext _storageContext;
        private StorageViewModel _item;
        public ObservableCollection<StorageViewModel> storages;

        public StorageListViewModel()
        {
            _storageContext = new StorageDbContext();
            _storageContext.Storages.Load();
            Get();
        }

        public void Get()
        {
            var items = _storageContext.Storages.Local;
            storages = new ObservableCollection<StorageViewModel>();
            foreach (var item in items)
                storages.Add(new StorageViewModel(item));
        }
        public void Create()
        {
            _storageContext.Storages.Add(_item.Item);
            _storageContext.SaveChanges();
        }
        public void SetItem(StorageViewModel itemViewModel) => _item = itemViewModel;
        public void Update()
        {
            var item = _storageContext.Storages.FirstOrDefault(i => i.WarehouseId == _item.Item.WarehouseId);
            if (item == null)
                throw new Exception("Account doesn't exist!");

            item.Address = _item.Address;
            item.Name = _item.Name;

            _storageContext.Entry(item).State = EntityState.Modified;
            _storageContext.SaveChanges(); 
        }

        public void Delete()
        {
            var item = _storageContext.Storages.FirstOrDefault(i => i.WarehouseId == _item.Item.WarehouseId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Storages.Remove(item);
            _storageContext.SaveChanges();
        }
    }
}