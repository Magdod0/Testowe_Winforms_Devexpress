namespace Testowe_WinF_Dev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderWarehouseItems",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        WarehouseItemID = c.Long(nullable: false),
                        WarehouseDocumentID = c.Long(nullable: false),
                        Units = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WarehouseDocuments", t => t.WarehouseDocumentID, cascadeDelete: true)
                .ForeignKey("dbo.WarehouseItems", t => t.WarehouseItemID, cascadeDelete: true)
                .Index(t => t.WarehouseItemID)
                .Index(t => t.WarehouseDocumentID);
            
            CreateTable(
                "dbo.WarehouseDocuments",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        CreatedDate = c.DateTime(nullable: false),
                        WarehouseID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseID)
                .Index(t => t.WarehouseID);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Address = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WarehouseItems",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        WarehouseID = c.Long(),
                        Name = c.String(maxLength: 30),
                        UnitsAtBeginning = c.Int(nullable: false),
                        UnitsLeft = c.Int(nullable: false),
                        Netto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Brutto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArrivalDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseID)
                .Index(t => t.WarehouseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderWarehouseItems", "WarehouseItemID", "dbo.WarehouseItems");
            DropForeignKey("dbo.WarehouseDocuments", "WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.WarehouseItems", "WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.OrderWarehouseItems", "WarehouseDocumentID", "dbo.WarehouseDocuments");
            DropIndex("dbo.WarehouseItems", new[] { "WarehouseID" });
            DropIndex("dbo.WarehouseDocuments", new[] { "WarehouseID" });
            DropIndex("dbo.OrderWarehouseItems", new[] { "WarehouseDocumentID" });
            DropIndex("dbo.OrderWarehouseItems", new[] { "WarehouseItemID" });
            DropTable("dbo.WarehouseItems");
            DropTable("dbo.Warehouses");
            DropTable("dbo.WarehouseDocuments");
            DropTable("dbo.OrderWarehouseItems");
        }
    }
}
