using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.StorageDocs
{
    [POCOViewModel]
    public class StorageDocListViewModel
    {
        StorageDbContext _storageContext;
        private StorageDocViewModel _item;
        public ObservableCollection<StorageDocViewModel> storageDocs;
        public StorageDocListViewModel()
        {

            _storageContext = new StorageDbContext();

            _storageContext.StorageDocs.Load();

        }
        public void GetStorageDocs()
        {
            var items = _storageContext.StorageDocs.Local;
            storageDocs = new ObservableCollection<StorageDocViewModel>();
            foreach (var item in items)
                storageDocs.Add(new StorageDocViewModel(item));
                
        }
        public void Create()
        {
            _storageContext.StorageDocs.Add(_item.Item);
            _storageContext.SaveChanges();
        }
        public void Update()
        {
            var item = _storageContext.StorageDocs.FirstOrDefault(i => i.StorageDocId == _item.Item.StorageDocId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Entry(item).State = EntityState.Modified;
            _storageContext.SaveChanges();
        }
        public void Delete()
        {
            var item = _storageContext.StorageDocs.FirstOrDefault(i => i.StorageDocId == _item.Item.StorageDocId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.StorageDocs.Remove(item);
            _storageContext.SaveChanges();
        }
    }
}