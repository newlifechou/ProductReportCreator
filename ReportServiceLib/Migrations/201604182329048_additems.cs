namespace ReportServiceLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Targets", "Dimension", c => c.String());
            AddColumn("dbo.Samples", "Remark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Samples", "Remark");
            DropColumn("dbo.Targets", "Dimension");
        }
    }
}
