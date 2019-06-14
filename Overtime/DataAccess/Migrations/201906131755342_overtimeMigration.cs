namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class overtimeMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_M_ActivityOvertime", "Overtime_Id", "dbo.TB_T_DataOvertime");
            DropIndex("dbo.TB_M_ActivityOvertime", new[] { "Overtime_Id" });
            CreateTable(
                "dbo.TB_M_Submited",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Submitted = c.String(),
                        Status_Submitted = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TB_T_DataOvertime", "Description_Overtime", c => c.String());
            AddColumn("dbo.TB_T_DataOvertime", "Submited_Id", c => c.Int(nullable: false));
            AddColumn("dbo.TB_M_Parameter", "Long_Time", c => c.Int(nullable: false));
            AddColumn("dbo.TB_M_Parameter", "Pay", c => c.Int(nullable: false));
            CreateIndex("dbo.TB_T_DataOvertime", "Submited_Id");
            AddForeignKey("dbo.TB_T_DataOvertime", "Submited_Id", "dbo.TB_M_Submited", "Id", cascadeDelete: true);
            DropColumn("dbo.TB_T_DataOvertime", "Status_Overtime");
            DropColumn("dbo.TB_T_DataOvertime", "Name_Submited");
            DropColumn("dbo.TB_M_Parameter", "Name_Parameter");
            DropColumn("dbo.TB_M_Parameter", "Value_Parameter");
            DropTable("dbo.TB_M_ActivityOvertime");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TB_M_ActivityOvertime",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Overtime_Activity = c.String(),
                        Overtime_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TB_M_Parameter", "Value_Parameter", c => c.Int(nullable: false));
            AddColumn("dbo.TB_M_Parameter", "Name_Parameter", c => c.String());
            AddColumn("dbo.TB_T_DataOvertime", "Name_Submited", c => c.String());
            AddColumn("dbo.TB_T_DataOvertime", "Status_Overtime", c => c.String());
            DropForeignKey("dbo.TB_T_DataOvertime", "Submited_Id", "dbo.TB_M_Submited");
            DropIndex("dbo.TB_T_DataOvertime", new[] { "Submited_Id" });
            DropColumn("dbo.TB_M_Parameter", "Pay");
            DropColumn("dbo.TB_M_Parameter", "Long_Time");
            DropColumn("dbo.TB_T_DataOvertime", "Submited_Id");
            DropColumn("dbo.TB_T_DataOvertime", "Description_Overtime");
            DropTable("dbo.TB_M_Submited");
            CreateIndex("dbo.TB_M_ActivityOvertime", "Overtime_Id");
            AddForeignKey("dbo.TB_M_ActivityOvertime", "Overtime_Id", "dbo.TB_T_DataOvertime", "Id", cascadeDelete: true);
        }
    }
}
