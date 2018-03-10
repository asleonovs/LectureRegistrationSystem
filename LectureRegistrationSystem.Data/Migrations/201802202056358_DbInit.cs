namespace LectureRegistrationSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FaculatyName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        lecture = c.String(nullable: false),
                        Level_of_studies = c.String(nullable: false, maxLength: 70),
                        study_year_id = c.Int(nullable: false),
                        FacultyId_id = c.Int(nullable: false),
                        StudyProgramId_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId_id, cascadeDelete: true)
                .ForeignKey("dbo.StudyPrograms", t => t.StudyProgramId_Id, cascadeDelete: true)
                .Index(t => t.FacultyId_id)
                .Index(t => t.StudyProgramId_Id);
            
            CreateTable(
                "dbo.StudyPrograms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StudyProgramName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false, maxLength: 50),
                        name = c.String(nullable: false, maxLength: 70),
                        surname = c.String(nullable: false, maxLength: 70),
                        email = c.String(nullable: false, maxLength: 70),
                        role = c.String(nullable: false, maxLength: 70),
                        Level_of_studies = c.String(nullable: false, maxLength: 70),
                        year_of_study = c.Int(nullable: false),
                        group = c.Int(nullable: false),
                        study_program = c.DateTime(nullable: false),
                        Faculty_id = c.Int(nullable: false),
                        StudyProgram_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Faculties", t => t.Faculty_id, cascadeDelete: true)
                .ForeignKey("dbo.StudyPrograms", t => t.StudyProgram_Id, cascadeDelete: true)
                .Index(t => t.Faculty_id)
                .Index(t => t.StudyProgram_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "StudyProgram_Id", "dbo.StudyPrograms");
            DropForeignKey("dbo.Users", "Faculty_id", "dbo.Faculties");
            DropForeignKey("dbo.Lectures", "StudyProgramId_Id", "dbo.StudyPrograms");
            DropForeignKey("dbo.Lectures", "FacultyId_id", "dbo.Faculties");
            DropIndex("dbo.Users", new[] { "StudyProgram_Id" });
            DropIndex("dbo.Users", new[] { "Faculty_id" });
            DropIndex("dbo.Lectures", new[] { "StudyProgramId_Id" });
            DropIndex("dbo.Lectures", new[] { "FacultyId_id" });
            DropTable("dbo.Users");
            DropTable("dbo.StudyPrograms");
            DropTable("dbo.Lectures");
            DropTable("dbo.Faculties");
        }
    }
}
