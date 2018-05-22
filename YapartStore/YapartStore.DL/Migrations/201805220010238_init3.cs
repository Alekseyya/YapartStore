namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Articul = c.String(),
                        Description = c.String(),
                        PriceWithDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Comment = c.String(),
                        IsClosed = c.Boolean(nullable: false),
                        OrderStatus = c.String(),
                        OrderStatusComment = c.String(),
                        ClientGuid = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        OrderId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId_Id)
                .Index(t => t.OrderId_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShippingMethod = c.String(nullable: false),
                        PaymentMethod = c.String(),
                        ClientGuid = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        City = c.String(),
                        Phone = c.String(),
                        ShippedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Comment = c.String(),
                        IsSent = c.Boolean(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "OrderId_Id", "dbo.Orders");
            DropIndex("dbo.OrderItems", new[] { "OrderId_Id" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderItems");
        }
    }
}
