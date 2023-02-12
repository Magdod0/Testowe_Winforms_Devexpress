using DevExpress.Mvvm.Native;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Testowe_WinF_Dev.DataModels.Context;
using Testowe_WinF_Dev.Models;
using System.Data.Entity;


namespace Testowe_WinF_Dev.DataModels.Repositories
{
    public class WarehouseRepository : IRepository<Warehouse>
    {

        private MyDbContext _context;
        public WarehouseRepository(MyDbContext context)
        {
            _context = context;
        }
        public void Create(Warehouse item)
        {
            _context.Warehouses.Add(item);
        }

        //public void Delete(object id)
        //{
        //    var item = Get(id);
        //    if (item == null)
        //        return;
        //   _context.Warehouses.Remove(item);
        //}
        public void Delete(Warehouse item)
        {
            var dbItem = Get(item.ID);
            if (dbItem != null)
                _context.Warehouses.Remove(dbItem);
        }

        public Warehouse Get(object id)
        {
            long ID = (long)id;
            return _context.Warehouses.Find(ID);
        }

        public ObservableCollection<Warehouse> GetAll()
        {
            return _context.Warehouses.ToObservableCollection();
        }

        public ObservableCollection<Warehouse> GetWhere(Func<Warehouse, bool> predicate)
        {
            return _context.Warehouses.Where(predicate).ToObservableCollection();
        }

        public void Update(Warehouse item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

    }
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
    public class WarehouseDocumentRepository : IRepository<WarehouseDocument>
    {
        private MyDbContext _context;

        public WarehouseDocumentRepository(MyDbContext context)
        {
            _context = context;
        }
        public void Create(WarehouseDocument item)
        {
            _context.WarehouseDocuments.Add(item);
        }

        public void Delete(WarehouseDocument item)
        {
            var dbItem = Get(item.ID);
            if (dbItem != null)
                _context.WarehouseDocuments.Remove(dbItem);
        }

        public WarehouseDocument Get(object id)
        {
            long ID = (long)id;
            return _context.WarehouseDocuments.Find(ID);
        }

        public ObservableCollection<WarehouseDocument> GetAll()
        {
            return _context.WarehouseDocuments.Include(w=> w.OrderWarehouseItems).ToObservableCollection();
        }

        public ObservableCollection<WarehouseDocument> GetWhere(Func<WarehouseDocument, bool> predicate)
        {
            return _context.WarehouseDocuments.Include(w => w.OrderWarehouseItems).Where(predicate).ToObservableCollection();
        }

        public void Update(WarehouseDocument item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
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
