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
            if (Get(item.ID) != null)
                _context.Entry(item).State = EntityState.Modified;
        }

    }
}
