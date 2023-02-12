namespace Testowe_WinF_Dev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_more_fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderWarehouseItems", "WarehouseItemName", c => c.String(maxLength: 30));
            AddColumn("dbo.WarehouseDocuments", "DocunmentDate", c => c.DateTime(nullable:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WarehouseDocuments", "DocunmentDate");
            DropColumn("dbo.OrderWarehouseItems", "WarehouseItemName");
        }
    }
}
