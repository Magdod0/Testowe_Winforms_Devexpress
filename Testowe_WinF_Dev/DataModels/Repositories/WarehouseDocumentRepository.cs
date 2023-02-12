using DevExpress.Mvvm.Native;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Testowe_WinF_Dev.DataModels.Context;
using Testowe_WinF_Dev.Models;
using System.Data.Entity;


namespace Testowe_WinF_Dev.DataModels.Repositories
{
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
}
