namespace assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingSomeAtrributesAndTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.courses", "Admission_AdmissionTermCode", c => c.Int(nullable: false));
            AddColumn("dbo.courses", "Admission_AdmissionName", c => c.String());
            AddColumn("dbo.courses", "Admission_MajorID", c => c.Int(nullable: false));
            AddColumn("dbo.courses", "Admission_DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.courses", "AdmissionDepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Admission_AdmissionTermCode", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Admission_AdmissionName", c => c.String());
            AddColumn("dbo.Students", "Admission_MajorID", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Admission_DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "AdmissionMajorID", c => c.Int(nullable: false));
            DropColumn("dbo.courses", "DepartmentID");
            DropColumn("dbo.Students", "MajorID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "MajorID", c => c.Int(nullable: false));
            AddColumn("dbo.courses", "DepartmentID", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "AdmissionMajorID");
            DropColumn("dbo.Students", "Admission_DepartmentID");
            DropColumn("dbo.Students", "Admission_MajorID");
            DropColumn("dbo.Students", "Admission_AdmissionName");
            DropColumn("dbo.Students", "Admission_AdmissionTermCode");
            DropColumn("dbo.courses", "AdmissionDepartmentID");
            DropColumn("dbo.courses", "Admission_DepartmentID");
            DropColumn("dbo.courses", "Admission_MajorID");
            DropColumn("dbo.courses", "Admission_AdmissionName");
            DropColumn("dbo.courses", "Admission_AdmissionTermCode");
        }
    }
}
