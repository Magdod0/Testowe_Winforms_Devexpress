using DevExpress.Mvvm.Native;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Testowe_WinF_Dev.DataModels.Context;
using Testowe_WinF_Dev.Models;
using System.Data.Entity;


namespace Testowe_WinF_Dev.DataModels.Repositories
{
    public class OrderWarehouseItemRepository : IRepository<OrderWarehouseItem>
    {
        private MyDbContext _context;

        public OrderWarehouseItemRepository(MyDbContext context)
        {
            _context = context;
        }
        public void Create(OrderWarehouseItem item)
        {
            _context.OrderWarehouseItems.Add(item);
        }

        public void Delete(OrderWarehouseItem item)
        {
            var dbItem = Get(item.ID);
            if (dbItem != null)
                _context.OrderWarehouseItems.Remove(dbItem);
        }

        public OrderWarehouseItem Get(object id)
        {
            long ID = (long)id;
            return _context.OrderWarehouseItems.Find(ID);
        }

        public ObservableCollection<OrderWarehouseItem> GetAll()
        {
            return _context.OrderWarehouseItems.ToObservableCollection();
        }

        public ObservableCollection<OrderWarehouseItem> GetWhere(Func<OrderWarehouseItem, bool> predicate)
        {
            return _context.OrderWarehouseItems.Where(predicate).ToObservableCollection();
        }

        public void Update(OrderWarehouseItem item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
