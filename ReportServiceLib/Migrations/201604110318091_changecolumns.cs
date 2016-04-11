namespace ReportServiceLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changecolumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Targets", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Samples", "Material", c => c.String(nullable: false));
            AddColumn("dbo.Samples", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Targets", "Material", c => c.String(nullable: false));
            AlterColumn("dbo.Targets", "Lot", c => c.String(nullable: false));
            AlterColumn("dbo.Samples", "Lot", c => c.String(nullable: false));
            DropColumn("dbo.Targets", "Composition");
            DropColumn("dbo.Targets", "IsSend");
            DropColumn("dbo.Targets", "SendDate");
            DropColumn("dbo.Samples", "Composition");
            DropColumn("dbo.Samples", "IsSend");
            DropColumn("dbo.Samples", "SendDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Samples", "SendDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Samples", "IsSend", c => c.Boolean(nullable: false));
            AddColumn("dbo.Samples", "Composition", c => c.String());
            AddColumn("dbo.Targets", "SendDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Targets", "IsSend", c => c.Boolean(nullable: false));
            AddColumn("dbo.Targets", "Composition", c => c.String());
            AlterColumn("dbo.Samples", "Lot", c => c.String());
            AlterColumn("dbo.Targets", "Lot", c => c.String());
            AlterColumn("dbo.Targets", "Material", c => c.String());
            DropColumn("dbo.Samples", "CreateDate");
            DropColumn("dbo.Samples", "Material");
            DropColumn("dbo.Targets", "CreateDate");
        }
    }
}
