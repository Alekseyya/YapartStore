namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductVariants", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductVariants", "VariantId", "dbo.Variants");
            DropForeignKey("dbo.Variants", "ModificationId", "dbo.Modifications");
            DropIndex("dbo.Variants", new[] { "ModificationId" });
            DropIndex("dbo.ProductVariants", new[] { "ProductId" });
            DropIndex("dbo.ProductVariants", new[] { "VariantId" });
            CreateTable(
                "dbo.ProductModification",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        ModificationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.ModificationId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Modifications", t => t.ModificationId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ModificationId);
            
            AlterColumn("dbo.Modifications", "Name", c => c.String());
            DropTable("dbo.Variants");
            DropTable("dbo.ProductVariants");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductVariants",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        VariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.VariantId });
            
            CreateTable(
                "dbo.Variants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModificationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.ProductModification", "ModificationId", "dbo.Modifications");
            DropForeignKey("dbo.ProductModification", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductModification", new[] { "ModificationId" });
            DropIndex("dbo.ProductModification", new[] { "ProductId" });
            AlterColumn("dbo.Modifications", "Name", c => c.String(nullable: false));
            DropTable("dbo.ProductModification");
            CreateIndex("dbo.ProductVariants", "VariantId");
            CreateIndex("dbo.ProductVariants", "ProductId");
            CreateIndex("dbo.Variants", "ModificationId");
            AddForeignKey("dbo.Variants", "ModificationId", "dbo.Modifications", "Id");
            AddForeignKey("dbo.ProductVariants", "VariantId", "dbo.Variants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductVariants", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
