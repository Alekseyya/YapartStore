namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unit16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modifications", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Modifications", "Url");
        }
    }
}
