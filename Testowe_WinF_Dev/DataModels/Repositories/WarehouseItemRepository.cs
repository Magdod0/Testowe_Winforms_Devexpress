using DevExpress.Mvvm.Native;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Testowe_WinF_Dev.DataModels.Context;
using Testowe_WinF_Dev.Models;
using System.Data.Entity;


namespace Testowe_WinF_Dev.DataModels.Repositories
{
    public class WarehouseItemRepository : IRepository<WarehouseItem>
    {
        private MyDbContext _context;

        public WarehouseItemRepository(MyDbContext context)
        {
            _context = context;
        }
        public void Create(WarehouseItem item)
        {
            _context.WarehouseItems.Add(item);
        }

        public void Delete(WarehouseItem item)
        {
            var dbItem = Get(item.ID);
            if (dbItem != null)
                _context.WarehouseItems.Remove(dbItem);
        }

        public WarehouseItem Get(object id)
        {
            long ID = (long)id;
            return _context.WarehouseItems.Find(ID);
        }

        public ObservableCollection<WarehouseItem> GetAll()
        {
            return _context.WarehouseItems.Include(w => w.Warehouse).ToObservableCollection();
        }

        public ObservableCollection<WarehouseItem> GetWhere(Func<WarehouseItem, bool> predicate)
        {
            return _context.WarehouseItems.Include(w => w.Warehouse).Where(predicate).ToObservableCollection();
        }

        public void Update(WarehouseItem item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
