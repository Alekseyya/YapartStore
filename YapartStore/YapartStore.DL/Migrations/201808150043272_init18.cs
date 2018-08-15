namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init18 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Pictures",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Path = c.String(nullable: false),
                        UpdateTimestamp = c.DateTime(nullable: false),
                        ProductId = c.Int(),
                        Brand_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.Brands", t => t.Brand_Id)
                .Index(t => t.ProductId)
                .Index(t => t.Brand_Id);
        }
        
        public override void Down()
        {
        }
    }
}
