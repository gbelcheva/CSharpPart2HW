namespace DateFirst.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using Models;

    public class DateFirstDbContext : IdentityDbContext<User>
    {
        public DateFirstDbContext()
            : base("DefaultConnection")
        {
        }

        public virtual IDbSet<AdditionalInfo> AdditionalInfo { get; set; }

        public virtual IDbSet<Department> Departments { get; set; }

        public virtual IDbSet<Hobby> Hobbies { get; set; }

        public virtual IDbSet<Image> Images { get; set; }

        public virtual IDbSet<Notification> Notifications { get; set; }

        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<UserProfile> UserProfiles { get; set; }

        public static DateFirstDbContext Create()
        {
            return new DateFirstDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}