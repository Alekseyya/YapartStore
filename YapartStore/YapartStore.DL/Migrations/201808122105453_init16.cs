namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init16 : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.ProductModifications", "ModificationId", "dbo.Modifications", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductModifications", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
        }
    }
}
