namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init19 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Pictures", "BrandId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "BrandId", c => c.Int());
        }
    }
}
