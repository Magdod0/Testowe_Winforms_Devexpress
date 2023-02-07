using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.Storages
{
    [POCOViewModel]
    public class StorageViewModel
    {
        StorageDbContext _storageContext;
        private StorageWrapper _item;
        public virtual string Address { get; set; }
        public virtual string Name { get; set; }

        public StorageViewModel()
        {

            _storageContext = new StorageDbContext();

            _storageContext.Storages.Load();

        }
        public void Load(StorageWrapper storageWrapper)
        {
            _item = storageWrapper;
            Address = _item.Address;
            Name = _item.Name;
        }
        public IEnumerable<Storage> GetStorages()
        {
            return _storageContext.Storages.AsEnumerable();
        }
        public void Create()
        {
            _storageContext.Storages.Add(_item.item);
            _storageContext.SaveChanges();
        }
        public void Update()
        {
            var item = _storageContext.Storages.FirstOrDefault(i => i.StorageId == _item.item.StorageId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            Store();
            _storageContext.Entry(item).State = EntityState.Modified;
            _storageContext.SaveChanges();
        }
        private void Store()
        {
            if (!string.Equals(Name, _item.Name))
                _item.Name = Name;
            if(!string.Equals(Address, _item.Address))
                _item.Address = Address;
        }
        public void Delete()
        {
            var item = _storageContext.Storages.FirstOrDefault(i => i.StorageId == _item.item.StorageId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Storages.Remove(item);
            _storageContext.SaveChanges();
        }
    }
}