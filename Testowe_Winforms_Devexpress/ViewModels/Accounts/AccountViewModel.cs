using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.Accounts
{
    [POCOViewModel]
    public class AccountViewModel
    {
        StorageDbContext _storageContext;
        private AccountWrapper _account;
        public AccountViewModel()
        {

            _storageContext = new StorageDbContext();

            _storageContext.Accounts.Load();

        }
        public IEnumerable<Account> GetAccounts()
        {
            return _storageContext.Accounts.AsEnumerable();
        }
        public void Create()
        {
            _storageContext.Accounts.Add(_account.item);
            _storageContext.SaveChanges();
        }
        public void Update()
        {
            var item = _storageContext.Accounts.FirstOrDefault(i => i.Login == _account.Login);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Entry(item).State = EntityState.Modified;
            _storageContext.SaveChanges();
        }
        public void Delete()
        {
            var item = _storageContext.Accounts.FirstOrDefault(i => i.Login == _account.Login);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Accounts.Remove(item);
            _storageContext.SaveChanges();
        }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime LastUpdated { get; set; }
        public virtual DateTime Logged { get; set; }

    }
}