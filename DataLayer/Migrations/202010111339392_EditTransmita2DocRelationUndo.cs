namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditTransmita2DocRelationUndo : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Documents", new[] { "TransmitalNumber" });
            AlterColumn("dbo.Documents", "TransmitalNumber", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Documents", "TransmitalNumber");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Documents", new[] { "TransmitalNumber" });
            AlterColumn("dbo.Documents", "TransmitalNumber", c => c.String(maxLength: 128));
            CreateIndex("dbo.Documents", "TransmitalNumber");
        }
    }
}
