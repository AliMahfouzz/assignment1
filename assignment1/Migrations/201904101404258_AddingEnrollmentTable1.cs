namespace assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingEnrollmentTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        TermCode = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        courseID = c.Int(nullable: false),
                        MajorID = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                        EnrolledIndicator = c.Boolean(nullable: false),
                        PaymentIndicator = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TermCode)
                .ForeignKey("dbo.courses", t => t.courseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.courseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "courseID", "dbo.courses");
            DropIndex("dbo.Enrollments", new[] { "courseID" });
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            DropTable("dbo.Enrollments");
        }
    }
}
