namespace DateFirst.Data.Repositories
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Models;

    public class DateFirstData : IDateFirstData
    {
        private readonly IDateFirstDbContext context;
        private readonly IDictionary<Type, object> repositories;

        public DateFirstData()
            : this(new DateFirstDbContext())
        {
        }

        public DateFirstData(IDateFirstDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<AdditionalInfo> AdditionalInfos
        {
            get { return this.GetRepository<AdditionalInfo>(); }
        }

        public IRepository<Department> Departments
        {
            get { return this.GetRepository<Department>(); }
        }

        public IRepository<Image> Images
        {
            get { return this.GetRepository<Image>(); }
        }

        public IRepository<Notification> Notifications
        {
            get { return this.GetRepository<Notification>(); }
        }

        public IRepository<Post> Posts
        {
            get { return this.GetRepository<Post>(); }
        }

        public IRepository<Town> Towns
        {
            get { return this.GetRepository<Town>(); }
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class
        {
            Type typeOfRepository = typeof(TEntity);

            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                object newRepository = Activator.CreateInstance(typeof(EfRepository<TEntity>), this.context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<TEntity>)this.repositories[typeOfRepository];
        }
    }
}
