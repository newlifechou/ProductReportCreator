namespace ReportServiceLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additemintarget : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Targets", "XRFComposition", c => c.String());
            AddColumn("dbo.Targets", "Remark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Targets", "Remark");
            DropColumn("dbo.Targets", "XRFComposition");
        }
    }
}
