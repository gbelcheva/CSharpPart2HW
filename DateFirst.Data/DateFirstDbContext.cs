namespace DateFirst.Data
{
    using System.Data.Entity;

    using Contracts;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;
    using Models;

    public class DateFirstDbContext : IdentityDbContext<User>, IDateFirstDbContext
    {
        private const string DbConnectionName = "DateFirstDbConnection";

        public DateFirstDbContext()
            : base(DbConnectionName)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DateFirstDbContext, Configuration>());
        }

        public virtual IDbSet<AdditionalInfo> AdditionalInfo { get; set; }

        public virtual IDbSet<Department> Departments { get; set; }

        public virtual IDbSet<Hobby> Hobbies { get; set; }

        public virtual IDbSet<Image> Images { get; set; }

        public virtual IDbSet<Notification> Notifications { get; set; }

        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<UserProfile> UserProfiles { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}