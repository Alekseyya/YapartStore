namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unit9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "EnglishName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "EnglishName");
        }
    }
}
