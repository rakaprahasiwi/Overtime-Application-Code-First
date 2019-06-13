namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OvertimeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_T_DataOvertime", "Name_Submited", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_T_DataOvertime", "Name_Submited");
        }
    }
}
