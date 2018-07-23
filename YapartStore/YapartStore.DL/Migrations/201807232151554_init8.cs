namespace YapartStore.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pictures", "MarkId");
            DropColumn("dbo.Pictures", "ModelId");
            DropColumn("dbo.Marks", "PictureId");
            DropColumn("dbo.Models", "PictureId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Models", "PictureId", c => c.Int());
            AddColumn("dbo.Marks", "PictureId", c => c.Int());
            AddColumn("dbo.Pictures", "ModelId", c => c.Int());
            AddColumn("dbo.Pictures", "MarkId", c => c.Int());
        }
    }
}
