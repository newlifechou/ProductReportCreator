namespace ReportServiceLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addorderdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Targets", "OrderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Samples", "OrderDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Samples", "OrderDate");
            DropColumn("dbo.Targets", "OrderDate");
        }
    }
}
