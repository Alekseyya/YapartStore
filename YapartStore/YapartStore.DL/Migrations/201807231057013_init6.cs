namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Carts",
                    c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable:false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.UserId);

            CreateTable(
                    "dbo.CartLines",
                    c => new
                    {
                        Id = c.Guid(nullable: false),
                        CartId = c.Int(),
                        Article = c.String(nullable:false),
                        Descriptions = c.String(nullable:false),
                        Price = c.Decimal(nullable:false),
                        Quatity = c.Decimal(nullable:false)

                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carts", t => t.Id)
                .Index(t => t.CartId);
        }
        
        public override void Down()
        {
        }
    }
}
