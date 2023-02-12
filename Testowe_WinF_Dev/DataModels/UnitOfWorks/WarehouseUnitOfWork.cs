using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowe_WinF_Dev.DataModels.Context;
using Testowe_WinF_Dev.DataModels.Repositories;
using Testowe_WinF_Dev.Models;


namespace Testowe_WinF_Dev.DataModels.UnitOfWorks
{
    public class WarehouseUnitOfWork : UnitOfWork<MyDbContext>
    {

        private IRepository<Warehouse> warehouseRepository;
        private IRepository<WarehouseItem> warehouseItemRepository;

        public IRepository<Warehouse> WarehouseRepository
        {
            get
            {
                if (warehouseRepository == null)
                    warehouseRepository = new WarehouseRepository(_context);
                return warehouseRepository;
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
        public WarehouseUnitOfWork(MyDbContext context) : base(context) { }
        public static WarehouseUnitOfWork Create() => new WarehouseUnitOfWork(new MyDbContext());
 
    }
}
