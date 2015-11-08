namespace DateFirst.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Models;

    public interface IDateFirstDbContext
    {
        IDbSet<AdditionalInfo> AdditionalInfo { get; set; }

        IDbSet<Department> Departments { get; set; }

        IDbSet<Hobby> Hobbies { get; set; }

        IDbSet<Image> Images { get; set; }

        IDbSet<Notification> Notifications { get; set; }

        IDbSet<Post> Posts { get; set; }

        IDbSet<Town> Towns { get; set; }

        IDbSet<UserProfile> UserProfiles { get; set; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) 
            where TEntity : class;

        DbSet<TEntity> Set<TEntity>() 
            where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
