namespace DateFirst.Data.Repositories
{
    using DateFirst.Data.Contracts;
    using DateFirst.Models;

    public interface IDateFirstData
    {
        IRepository<Department> Department { get; }

        IRepository<Hobby> Hobby { get; }

        IRepository<Image> Image { get; }

        IRepository<Notification> Notification { get; }

        IRepository<Post> Post { get; }

        IRepository<Town> Town { get; }

        IRepository<User> User { get; }

        IRepository<UserProfile> UserProfile { get; }

        int SaveChanges();
    }
}
