namespace DateFirst.Data.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    using Contracts;

    public class EfRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly IDateFirstDbContext context;
        private readonly IDbSet<TEntity> set;

        public EfRepository(IDateFirstDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", "context");
            }

            this.context = context;
            this.set = this.context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> All()
        {
            return this.set;
        }

        public virtual TEntity GetById(object id)
        {
            return this.set.Find(id);
        }

        public virtual void Add(TEntity entity)
        {
            DbEntityEntry<TEntity> entry = this.context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.set.Add(entity);
            }
        }

        public virtual void Update(TEntity entity)
        {
            DbEntityEntry<TEntity> entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            DbEntityEntry<TEntity> entry = this.context.Entry(entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.set.Attach(entity);
                this.set.Remove(entity);
            }
        }

        public virtual void Delete(object id)
        {
            TEntity entity = this.GetById(id);

            if (entity != null)
            {
                this.Delete(entity);
            }
        }

        public virtual TEntity Attach(TEntity entity)
        {
            return this.context.Set<TEntity>().Attach(entity);
        }

        public virtual void Detach(TEntity entity)
        {
            DbEntityEntry<TEntity> entry = this.context.Entry(entity);
            entry.State = EntityState.Detached;
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
