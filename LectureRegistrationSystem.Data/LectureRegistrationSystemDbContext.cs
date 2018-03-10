using System.Data.Entity;
using LectureRegistrationSystem.Data.Models;

namespace LectureRegistrationSystem.Data
{
    internal class LectureRegistrationSystemDbContext : DbContext
    {
        public LectureRegistrationSystemDbContext() : base("LectureRegistrationSystem")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<StudyProgram> StudyPrograms { get; set; }
    }
}
