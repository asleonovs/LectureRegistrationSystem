using System.Data.Entity.Migrations;

namespace LectureRegistrationSystem.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LectureRegistrationSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LectureRegistrationSystemDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
