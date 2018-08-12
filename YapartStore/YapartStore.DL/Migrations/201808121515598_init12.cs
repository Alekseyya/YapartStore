namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modifications", "Years", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Modifications", "Years");
        }
    }
}
