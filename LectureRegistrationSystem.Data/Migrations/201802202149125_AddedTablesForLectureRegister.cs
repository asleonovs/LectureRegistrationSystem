namespace LectureRegistrationSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTablesForLectureRegister : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Lectures", new[] { "FacultyId_id" });
            DropIndex("dbo.Users", new[] { "Faculty_id" });
            RenameColumn(table: "dbo.Faculties", name: "FaculatyName", newName: "faculty");
            RenameColumn(table: "dbo.StudyPrograms", name: "StudyProgramName", newName: "Study_program");
            AddColumn("dbo.Users", "password", c => c.String(nullable: false, maxLength: 70));
            CreateIndex("dbo.Lectures", "FacultyId_Id");
            CreateIndex("dbo.Users", "Faculty_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Faculty_Id" });
            DropIndex("dbo.Lectures", new[] { "FacultyId_Id" });
            DropColumn("dbo.Users", "password");
            RenameColumn(table: "dbo.StudyPrograms", name: "Study_program", newName: "StudyProgramName");
            RenameColumn(table: "dbo.Faculties", name: "faculty", newName: "FaculatyName");
            CreateIndex("dbo.Users", "Faculty_id");
            CreateIndex("dbo.Lectures", "FacultyId_id");
        }
    }
}
