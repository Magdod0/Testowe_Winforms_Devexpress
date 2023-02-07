using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.OrderProducts
{
    [POCOViewModel]
    public class OrderProductViewModel
    {
        StorageDbContext _storageContext;
        private OrderProductWrapper _item;
        public OrderProductViewModel()
        {

            _storageContext = new StorageDbContext();

            _storageContext.OrderProducts.Load();

        }
        public IEnumerable<OrderProduct> GetOrderProducts()
        {
            return _storageContext.OrderProducts.AsEnumerable();
        }
        public void Create()
        {
            _storageContext.OrderProducts.Add(_item.item);
            _storageContext.SaveChanges();
        }
        public void Update()
        {
            var item = _storageContext.OrderProducts.FirstOrDefault(i => i.OrderProductId == _item.item.OrderProductId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Entry(item).State = EntityState.Modified;
            _storageContext.SaveChanges();
        }
        public void Delete()
        {
            var item = _storageContext.OrderProducts.FirstOrDefault(i => i.OrderProductId == _item.item.OrderProductId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.OrderProducts.Remove(item);
            _storageContext.SaveChanges();
        }
    }
}