namespace assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFieldsToTables1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admissions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdmissionTermCode = c.Int(nullable: false),
                        AdmissionName = c.String(),
                        MajorID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.courses", "Admission_ID", c => c.Int());
            AddColumn("dbo.Students", "Admission_ID", c => c.Int());
            CreateIndex("dbo.courses", "Admission_ID");
            CreateIndex("dbo.Students", "Admission_ID");
            AddForeignKey("dbo.courses", "Admission_ID", "dbo.Admissions", "ID");
            AddForeignKey("dbo.Students", "Admission_ID", "dbo.Admissions", "ID");
            DropColumn("dbo.courses", "Admission_AdmissionTermCode");
            DropColumn("dbo.courses", "Admission_AdmissionName");
            DropColumn("dbo.courses", "Admission_MajorID");
            DropColumn("dbo.courses", "Admission_DepartmentID");
            DropColumn("dbo.Students", "Admission_AdmissionTermCode");
            DropColumn("dbo.Students", "Admission_AdmissionName");
            DropColumn("dbo.Students", "Admission_MajorID");
            DropColumn("dbo.Students", "Admission_DepartmentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Admission_DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Admission_MajorID", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Admission_AdmissionName", c => c.String());
            AddColumn("dbo.Students", "Admission_AdmissionTermCode", c => c.Int(nullable: false));
            AddColumn("dbo.courses", "Admission_DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.courses", "Admission_MajorID", c => c.Int(nullable: false));
            AddColumn("dbo.courses", "Admission_AdmissionName", c => c.String());
            AddColumn("dbo.courses", "Admission_AdmissionTermCode", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "Admission_ID", "dbo.Admissions");
            DropForeignKey("dbo.courses", "Admission_ID", "dbo.Admissions");
            DropIndex("dbo.Students", new[] { "Admission_ID" });
            DropIndex("dbo.courses", new[] { "Admission_ID" });
            DropColumn("dbo.Students", "Admission_ID");
            DropColumn("dbo.courses", "Admission_ID");
            DropTable("dbo.Admissions");
        }
    }
}
