namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        DocumentNumber = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        DocumentVersion = c.Int(nullable: false),
                        TransmitalNumber = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.DocumentNumber)
                .ForeignKey("dbo.Transmitals", t => t.TransmitalNumber)
                .Index(t => t.TransmitalNumber);
            
            CreateTable(
                "dbo.Transmitals",
                c => new
                    {
                        TransmitalNumber = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Date = c.DateTime(nullable: false),
                        POI = c.String(),
                    })
                .PrimaryKey(t => t.TransmitalNumber);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        FileName = c.String(nullable: false, maxLength: 50),
                        CreatorId = c.Long(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        EditorId = c.Long(nullable: false),
                        LastRevisionDate = c.DateTime(nullable: false),
                        LastRevisionID = c.Long(nullable: false),
                        LastComment = c.String(),
                        LastState = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.CreatorId)
                .ForeignKey("dbo.People", t => t.EditorId)
                .Index(t => t.CreatorId)
                .Index(t => t.EditorId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Long(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "EditorId", "dbo.People");
            DropForeignKey("dbo.Files", "CreatorId", "dbo.People");
            DropForeignKey("dbo.Documents", "TransmitalNumber", "dbo.Transmitals");
            DropIndex("dbo.Files", new[] { "EditorId" });
            DropIndex("dbo.Files", new[] { "CreatorId" });
            DropIndex("dbo.Documents", new[] { "TransmitalNumber" });
            DropTable("dbo.People");
            DropTable("dbo.Files");
            DropTable("dbo.Transmitals");
            DropTable("dbo.Documents");
        }
    }
}
