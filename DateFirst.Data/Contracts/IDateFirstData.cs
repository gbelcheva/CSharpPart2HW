namespace DateFirst.Data.Repositories
{
    using Contracts;
    using Models;

    public interface IDateFirstData
    {
        IRepository<AdditionalInfo> AdditionalInfos { get; }

        IRepository<Department> Departments { get; }

        IRepository<Hobby> Hobbies { get; }

        IRepository<Image> Images { get; }

        IRepository<Notification> Notifications { get; }

        IRepository<Post> Posts { get; }

        IRepository<Town> Towns { get; }

        IRepository<User> Users { get; }

        IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
