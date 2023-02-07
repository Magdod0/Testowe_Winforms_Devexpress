namespace Testowe_Winforms_Devexpress.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        Name = c.String(maxLength: 30),
                        Created = c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETDATE()"),
                        LastUpdated = c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETDATE()"),
                        Logged = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Login);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.Guid(nullable: false, identity: true),
                        ContactName = c.String(nullable: false, maxLength: 30),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(maxLength: 120),
                        Phone = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.ClientID)
                .Index(t => t.ContactName)
                .Index(t => t.Name);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        SupplierID = c.Int(nullable: false),
                        StorageId = c.Int(nullable: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        UnitsAtBeginning = c.Int(nullable: false),
                        UnitsLeft = c.Int(nullable: false),
                        Netto = c.Decimal(nullable: false, storeType: "money"),
                        Brutto = c.Decimal(nullable: false, storeType: "money"),
                        ArrivalDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Storages", t => t.StorageId, cascadeDelete: false)
                .Index(t => t.StorageId)
                .Index(t => t.Name);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        StorageID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => t.StorageID)
                .Index(t => t.Name);

            CreateTable(
                "dbo.StorageDocs",
                c => new
                {
                    StorageDocID = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                    Name = c.String(nullable: false, maxLength: 30),
                    CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                    StorageId = c.Int(nullable: true)
                })
                .PrimaryKey(t => t.StorageDocID)
                .ForeignKey("dbo.Storages", t => t.StorageId, cascadeDelete:false)
                .Index(t => t.Name)
                .Index(t => t.StorageId);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        OrderProductID = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        ProductId = c.Guid(nullable: false),
                        StorageDocId = c.Guid(nullable: false),
                        Units = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.OrderProductID)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.StorageDocs", t => t.StorageDocId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.StorageDocId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StorageDocs", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.StorageDocs", "WarehouseId", "dbo.Storages");
            DropForeignKey("dbo.OrderProducts", "StorageDocId", "dbo.StorageDocs");
            DropForeignKey("dbo.OrderProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "WarehouseId", "dbo.Storages");
            DropIndex("dbo.OrderProducts", new[] { "StorageDocId" });
            DropIndex("dbo.OrderProducts", new[] { "ProductId" });
            DropIndex("dbo.StorageDocs", new[] { "Product_ProductId" });
            DropIndex("dbo.StorageDocs", new[] { "WarehouseId" });
            DropIndex("dbo.StorageDocs", new[] { "Name" });
            DropIndex("dbo.Storages", new[] { "Name" });
            DropIndex("dbo.Products", new[] { "Name" });
            DropIndex("dbo.Products", new[] { "WarehouseId" });
            DropIndex("dbo.Clients", new[] { "Name" });
            DropIndex("dbo.Clients", new[] { "ContactName" });
            DropTable("dbo.OrderProducts");
            DropTable("dbo.StorageDocs");
            DropTable("dbo.Storages");
            DropTable("dbo.Products");
            DropTable("dbo.Clients");
            DropTable("dbo.Accounts");
        }
    }
}
