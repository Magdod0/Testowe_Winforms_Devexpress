using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.StorageDocs
{
    [POCOViewModel]
    public class StorageDocViewModel
    {
        StorageDbContext _storageContext;
        private StorageDocWrapper _item;
        public StorageDocViewModel()
        {

            _storageContext = new StorageDbContext();

            _storageContext.StorageDocs.Load();

        }
        public IEnumerable<StorageDoc> GetStorageDocs()
        {
            return _storageContext.StorageDocs.AsEnumerable();
        }
        public void Create()
        {
            _storageContext.StorageDocs.Add(_item.item);
            _storageContext.SaveChanges();
        }
        public void Update()
        {
            var item = _storageContext.StorageDocs.FirstOrDefault(i => i.StorageDocId == _item.item.StorageDocId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Entry(item).State = EntityState.Modified;
            _storageContext.SaveChanges();
        }
        public void Delete()
        {
            var item = _storageContext.StorageDocs.FirstOrDefault(i => i.StorageDocId == _item.item.StorageDocId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.StorageDocs.Remove(item);
            _storageContext.SaveChanges();
        }
    }
}