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

        public virtual IDbSet<AdditionalInfo> AdditionalInfos { get; set; }

        public virtual IDbSet<Department> Departments { get; set; }

        public virtual IDbSet<Hobby> Hobbies { get; set; }

        public virtual IDbSet<Image> Images { get; set; }

        public virtual IDbSet<Notification> Notifications { get; set; }

        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<AdditionalInfo>()
                .HasRequired(ai => ai.User)
                .WithOptional(up => up.AdditionalInfo);

            //modelBuilder
            //    .Entity<Notification>()
            //    .HasRequired(n => n.Sender)
            //    .WithOptional()
            //    .WillCascadeOnDelete(true);

            //modelBuilder
            //    .Entity<Notification>()
            //    .HasRequired(n => n.Receiver)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);

            //modelBuilder
            //    .Entity<Post>()
            //    .HasRequired(n => n.Sender)
            //    .WithOptional()
            //    .WillCascadeOnDelete(true);

            //modelBuilder
            //    .Entity<Post>()
            //    .HasRequired(n => n.Receiver)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}