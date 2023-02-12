using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowe_WinF_Dev.Models;

namespace Testowe_WinF_Dev.DataModels.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext():base("MSSQL_Connect")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseItem> WarehouseItems { get; set; }
        public DbSet<OrderWarehouseItem> OrderWarehouseItems { get; set;}
        public DbSet<WarehouseDocument> WarehouseDocuments { get; set;}

    }
}
