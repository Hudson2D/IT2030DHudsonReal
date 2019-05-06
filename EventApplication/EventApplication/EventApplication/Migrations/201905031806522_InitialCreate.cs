namespace EventApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        EventId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordId)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventTypeId = c.Int(nullable: false),
                        EventTitle = c.String(nullable: false, maxLength: 50),
                        EventDescription = c.String(maxLength: 150),
                        EventStartDate = c.DateTime(nullable: false),
                        EventStartTime = c.String(nullable: false),
                        EventEndDate = c.DateTime(nullable: false),
                        EventEndTime = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        OrganizerName = c.String(nullable: false),
                        OrganizerContactInfo = c.String(),
                        MaxTickets = c.Int(nullable: false),
                        AvailableTickets = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.EventTypes", t => t.EventTypeId, cascadeDelete: true)
                .Index(t => t.EventTypeId);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        EventTypeId = c.Int(nullable: false, identity: true),
                        EventTypeName = c.String(),
                    })
                .PrimaryKey(t => t.EventTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "EventId", "dbo.Events");
            DropForeignKey("dbo.Events", "EventTypeId", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "EventTypeId" });
            DropIndex("dbo.Carts", new[] { "EventId" });
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Carts");
        }
    }
}
