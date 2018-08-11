namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Models", "Years", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Models", "Years", c => c.Int(nullable: false));
        }
    }
}
