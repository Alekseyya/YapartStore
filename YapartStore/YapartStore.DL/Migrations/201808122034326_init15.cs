namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init15 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.ProductModifications",
                    c => new
                    {
                        ProductId = c.Int(nullable: false),
                        ModificationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.ModificationId });
        }
        
        public override void Down()
        {
           
        }
    }
}
