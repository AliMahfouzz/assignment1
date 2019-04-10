namespace assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFieldsToTables : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Admission (AdmissionTermCode, AdmissionName,MajorID,DepartmentID) VALUES (201910, 'fall', 10,10) ");
            Sql("INSERT INTO Admission (AdmissionTermCode, AdmissionName,MajorID,DepartmentID) VALUES (201920, 'spring', 10,10) ");
            Sql("INSERT INTO Admission (AdmissionTermCode, AdmissionName,MajorID,DepartmentID) VALUES (201930, 'summer', 10,10) ");
            Sql("INSERT INTO Student (FirstName, LastName, AdmissionTermCode, MajorID) VALUES ('ali', 'mah', 201910,1/1/2000,10) ");
            Sql("INSERT INTO Student (FirstName, LastName, AdmissionTermCode, MajorID) VALUES ('mhmd', 'mah', 201910,1/1/2000,10) ");
            Sql("INSERT INTO courses (CourseName, Credits, AdmissionDepartmentID) VALUES ('application', 3,1) ");
            Sql("INSERT INTO courses (CourseName, Credits, AdmissionDepartmentID) VALUES ('web', 3,2) ");
        }
        
        public override void Down()
        {
        }
    }
}
