namespace ReportServiceLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Targets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Material = c.String(),
                        Lot = c.String(),
                        Size = c.String(),
                        Customer = c.String(),
                        PO = c.String(),
                        Density = c.String(),
                        Weight = c.String(),
                        Resistance = c.String(),
                        Composition = c.String(),
                        IsSend = c.Boolean(nullable: false),
                        SendDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Samples",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Composition = c.String(),
                        Customer = c.String(),
                        Lot = c.String(),
                        PO = c.String(),
                        Weight1 = c.String(),
                        Weight2 = c.String(),
                        Weight3 = c.String(),
                        Weight4 = c.String(),
                        IsSend = c.Boolean(nullable: false),
                        SendDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Samples");
            DropTable("dbo.Targets");
        }
    }
}
