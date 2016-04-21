namespace ReportServiceLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class materialabbr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Targets", "MaterialAbbr", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Targets", "MaterialAbbr");
        }
    }
}
