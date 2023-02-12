namespace Testowe_WinF_Dev.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Testowe_WinF_Dev.DataModels.Context.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Testowe_WinF_Dev.DataModels.Context.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Warehouses.AddOrUpdate(new Models.Warehouse() { ID = 1, Address = " Somewhere", Name = "Simple Dimple" });
            context.Warehouses.AddOrUpdate(new Models.Warehouse() { ID = 2, Address = "Everywhere", Name = "Popit" });

            context.WarehouseItems.AddOrUpdate(new Models.WarehouseItem() { ID = 1, Name = "Vodka", WarehouseID = 2, UnitsAtBeginning = 200, UnitsLeft = 200, Netto = 55, Brutto = 66, ArrivalDate = DateTime.Now});
            context.WarehouseItems.AddOrUpdate(new Models.WarehouseItem() { ID = 2, Name = "Chai", WarehouseID = 2, UnitsAtBeginning = 180, UnitsLeft = 180, Netto = 45, Brutto = 55, ArrivalDate = DateTime.Now });
            context.WarehouseItems.AddOrUpdate(new Models.WarehouseItem() { ID = 3, Name = "Coffee", WarehouseID = 3, UnitsAtBeginning = 5, UnitsLeft = 5, Netto = 75, Brutto = 95, ArrivalDate = DateTime.Now });
            context.WarehouseItems.AddOrUpdate(new Models.WarehouseItem() { ID = 4, Name = "Circuits", WarehouseID = null, UnitsAtBeginning = 5, UnitsLeft =5 , Netto = 5, Brutto = 10, ArrivalDate = DateTime.Now });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
