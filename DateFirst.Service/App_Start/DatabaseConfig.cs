namespace StudentSystem.Api
{
    using System.Data.Entity;
    using DateFirst.Data;
    using DateFirst.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DateFirstDbContext, Configuration>());
            DateFirstDbContext.Create().Database.Initialize(true);
        }
    }
}