namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init21 : DbMigration
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
                .Index(t => t.ProductId);

            //RenameColumn(table: "dbo.Pictures", name: "Brand_Id", newName: "BrandId");
            DropPrimaryKey("dbo.Pictures");

            AddColumn("dbo.Pictures", "BrandId", c => c.Int());
            AddForeignKey("dbo.Pictures", "BrandId", "dbo.Brands", "Id", false);
            //AlterColumn("dbo.Pictures", "Id", c => c.Int(nullable: false, identity: true));
            //AddPrimaryKey("dbo.Pictures", "Id");
            //CreateIndex("dbo.Pictures", "Id");
        }

        public override void Down()
        {
        }
    }
}
