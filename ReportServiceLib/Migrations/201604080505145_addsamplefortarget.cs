namespace ReportServiceLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsamplefortarget : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Samples", "ForTarget", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Samples", "ForTarget");
        }
    }
}
