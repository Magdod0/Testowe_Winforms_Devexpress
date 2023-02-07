using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.Clients
{
    [POCOViewModel]
    public class ClientViewModel
    {
        StorageDbContext _storageContext;
        private ClientWrapper _item;
        public ClientViewModel()
        {

            _storageContext = new StorageDbContext();

            _storageContext.Clients.Load();

        }
        public IEnumerable<Client> GetClients()
        {
            return _storageContext.Clients.AsEnumerable();
        }
        public void Create()
        {
            _storageContext.Clients.Add(_item.item);
            _storageContext.SaveChanges();
        }
        public void Update()
        {
            var item = _storageContext.Clients.FirstOrDefault(i => i.ClientId == _item.item.ClientId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Entry(item).State = EntityState.Modified;
            _storageContext.SaveChanges();
        }
        public void Delete()
        {
            var item = _storageContext.Clients.FirstOrDefault(i => i.ClientId == _item.item.ClientId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Clients.Remove(item);
            _storageContext.SaveChanges();
        }
    }
}