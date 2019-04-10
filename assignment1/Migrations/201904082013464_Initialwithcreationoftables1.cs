namespace assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialwithcreationoftables1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Credits = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        AdmissionTermCode = c.Int(nullable: false),
                        date = c.DateTime(),
                        MajorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.courses");
        }
    }
}
