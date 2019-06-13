namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OvertimeMigration1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ActivityOvertimes", newName: "TB_M_ActivityOvertime");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TB_M_ActivityOvertime", newName: "ActivityOvertimes");
        }
    }
}
