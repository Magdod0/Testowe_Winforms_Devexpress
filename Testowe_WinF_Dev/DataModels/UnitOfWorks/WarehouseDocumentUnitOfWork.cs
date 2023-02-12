using Testowe_WinF_Dev.DataModels.Context;
using Testowe_WinF_Dev.DataModels.Repositories;
using Testowe_WinF_Dev.Models;


namespace Testowe_WinF_Dev.DataModels.UnitOfWorks
{
    public class WarehouseDocumentUnitOfWork : UnitOfWork<MyDbContext>
    {

        private IRepository<WarehouseDocument> warehouseDocumentRepository;
        private IRepository<OrderWarehouseItem> orderWarehouseItemRepository;
        private IRepository<WarehouseItem> warehouseItemRepository;
        private IRepository<Warehouse> warehouseRepository;

        public IRepository<WarehouseDocument> WarehouseDocumentRepository
        {
            get
            {
                if (warehouseDocumentRepository == null)
                    warehouseDocumentRepository = new WarehouseDocumentRepository(_context);
                return warehouseDocumentRepository;
            }
        }
        public IRepository<OrderWarehouseItem> OrderWarehouseItemRepository
        {
            get
            {
                if (orderWarehouseItemRepository == null)
                    orderWarehouseItemRepository = new OrderWarehouseItemRepository(_context);
                return orderWarehouseItemRepository;
            }
        }
        public IRepository<WarehouseItem> WarehouseItemRepository
        {
            get
            {
                if (warehouseItemRepository == null)
                    warehouseItemRepository = new WarehouseItemRepository(_context);
                return warehouseItemRepository;
            }
        } 
        public IRepository<Warehouse> WarehouseRepository
        {
            get
            {
                if (warehouseRepository == null)
                    warehouseRepository = new WarehouseRepository(_context);
                return warehouseRepository;
            }
        }
        public WarehouseDocumentUnitOfWork(MyDbContext context) : base(context) { }
        public static WarehouseDocumentUnitOfWork Create() => new WarehouseDocumentUnitOfWork(new MyDbContext());

    }
}
