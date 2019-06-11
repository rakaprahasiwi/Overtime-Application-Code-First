namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OvertimeMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivityOvertimes",
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_T_DataOvertime", t => t.Overtime_Id, cascadeDelete: true)
                .Index(t => t.Overtime_Id);
            
            CreateTable(
                "dbo.TB_T_DataOvertime",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date_Overtime = c.DateTimeOffset(nullable: false, precision: 7),
                        Pay_Overtime = c.Double(nullable: false),
                        Start_Overtime = c.DateTimeOffset(nullable: false, precision: 7),
                        End_Overtime = c.DateTimeOffset(nullable: false, precision: 7),
                        Attachment_Overtime = c.String(),
                        Status_Overtime = c.String(),
                        Type_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Employee", t => t.Employee_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_TypeOvertime", t => t.Type_Id, cascadeDelete: true)
                .Index(t => t.Type_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.TB_M_Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NIK = c.Int(nullable: false),
                        Name_Employee = c.String(),
                        Salary_Employee = c.Double(nullable: false),
                        Email_Employee = c.String(),
                        Password_Employee = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_TypeOvertime",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Overtime_Type = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Parameter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Parameter = c.String(),
                        Value_Parameter = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActivityOvertimes", "Overtime_Id", "dbo.TB_T_DataOvertime");
            DropForeignKey("dbo.TB_T_DataOvertime", "Type_Id", "dbo.TB_M_TypeOvertime");
            DropForeignKey("dbo.TB_T_DataOvertime", "Employee_Id", "dbo.TB_M_Employee");
            DropIndex("dbo.TB_T_DataOvertime", new[] { "Employee_Id" });
            DropIndex("dbo.TB_T_DataOvertime", new[] { "Type_Id" });
            DropIndex("dbo.ActivityOvertimes", new[] { "Overtime_Id" });
            DropTable("dbo.TB_M_Parameter");
            DropTable("dbo.TB_M_TypeOvertime");
            DropTable("dbo.TB_M_Employee");
            DropTable("dbo.TB_T_DataOvertime");
            DropTable("dbo.ActivityOvertimes");
        }
    }
}
