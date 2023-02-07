using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.Products
{
    [POCOViewModel]
    public class ProductListViewModel
    {
        StorageDbContext _storageContext;
        private ProductViewModel _item;
        public ProductListViewModel()
        {

            _storageContext = new StorageDbContext();

            _storageContext.Products.Load();

        }
        public IEnumerable<Product> GetProducts()
        {
            return _storageContext.Products.AsEnumerable();
        }
        public void Create()
        {
            _storageContext.Products.Add(_item.item);
            _storageContext.SaveChanges();
        }
        public void Update()
        {
            var item = _storageContext.Products.FirstOrDefault(i => i.ProductId == _item.item.ProductId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Entry(item).State = EntityState.Modified;
            _storageContext.SaveChanges();
        }
        public void Delete()
        {
            var item = _storageContext.Products.FirstOrDefault(i => i.ProductId == _item.item.ProductId);
            if (item == null)
                throw new Exception("Account doesn't exist!");
            _storageContext.Products.Remove(item);
            _storageContext.SaveChanges();
        }
    }
}