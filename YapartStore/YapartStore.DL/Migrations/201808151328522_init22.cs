namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init22 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pictures", "BrandId");
            DropColumn("dbo.Pictures", "BrandId");
            DropColumn("dbo.Pictures", "Brand_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "BrandId", c => c.Int());
        }
    }
}
