namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Variants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModificationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modifications", t => t.ModificationId)
                .Index(t => t.ModificationId);
            
            CreateTable(
                "dbo.Modifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ModelId = c.Int(),
                        Sort = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.ModelId)
                .Index(t => t.ModelId);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Years = c.Int(nullable: false),
                        MarkId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marks", t => t.MarkId)
                .Index(t => t.MarkId);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Show = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductVariants",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        VariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.VariantId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Variants", t => t.VariantId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.VariantId);
            
            AddColumn("dbo.Products", "ShortArticle", c => c.String());
            AddColumn("dbo.Products", "DaysDelivery", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "OldPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "Popular", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Characteristic", c => c.String());
            AddColumn("dbo.Products", "Brief", c => c.String());
            AddColumn("dbo.Products", "Show", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Discount", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Keywords", c => c.String());
            AddColumn("dbo.Products", "RemoveMarketplace", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categories", "Sort", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "Show", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sections", "Show", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sections", "Sort", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductVariants", "VariantId", "dbo.Variants");
            DropForeignKey("dbo.ProductVariants", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Variants", "ModificationId", "dbo.Modifications");
            DropForeignKey("dbo.Modifications", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Models", "MarkId", "dbo.Marks");
            DropIndex("dbo.ProductVariants", new[] { "VariantId" });
            DropIndex("dbo.ProductVariants", new[] { "ProductId" });
            DropIndex("dbo.Models", new[] { "MarkId" });
            DropIndex("dbo.Modifications", new[] { "ModelId" });
            DropIndex("dbo.Variants", new[] { "ModificationId" });
            DropColumn("dbo.Sections", "Sort");
            DropColumn("dbo.Sections", "Show");
            DropColumn("dbo.Categories", "Show");
            DropColumn("dbo.Categories", "Sort");
            DropColumn("dbo.Products", "RemoveMarketplace");
            DropColumn("dbo.Products", "Keywords");
            DropColumn("dbo.Products", "Discount");
            DropColumn("dbo.Products", "Show");
            DropColumn("dbo.Products", "Brief");
            DropColumn("dbo.Products", "Characteristic");
            DropColumn("dbo.Products", "Popular");
            DropColumn("dbo.Products", "OldPrice");
            DropColumn("dbo.Products", "DaysDelivery");
            DropColumn("dbo.Products", "ShortArticle");
            DropTable("dbo.ProductVariants");
            DropTable("dbo.Marks");
            DropTable("dbo.Models");
            DropTable("dbo.Modifications");
            DropTable("dbo.Variants");
        }
    }
}
