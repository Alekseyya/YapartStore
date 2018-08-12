namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init14 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductModification", newName: "ProductModifications");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductModifications1", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductModifications1", "Modification_Id", "dbo.Modifications");
            DropIndex("dbo.ProductModifications1", new[] { "Modification_Id" });
            DropIndex("dbo.ProductModifications1", new[] { "ProductId" });
            DropTable("dbo.ProductModifications1");
            RenameTable(name: "dbo.ProductModifications", newName: "ProductModification");
        }
    }
}
