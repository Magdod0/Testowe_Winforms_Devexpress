namespace Testowe_WinF_Dev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Renove_unneeded : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OrderWarehouseItems", "WarehouseItemName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderWarehouseItems", "WarehouseItemName", c => c.String(maxLength: 30));
        }
    }
}
