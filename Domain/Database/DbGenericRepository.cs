using Microsoft.EntityFrameworkCore;

namespace Domain.Database
{
    public class DbGenericRepository<TContext, TEntity> : DbGenericRepository<TContext, TEntity, int>
        where TContext : DbContext
        where TEntity : class
    {
        public DbGenericRepository(TContext context)
            : base(context)
        {
        }
    }

    public class DbGenericRepository<TContext, TEntity, TKey>
        where TContext : DbContext
        where TEntity : class
    {
        protected TContext Context { get; private set; }
        protected DbSet<TEntity> Entities { get; set; }

        public DbGenericRepository(TContext context)
        {
            Context = context;
        }

        public virtual async Task GetAsync(TKey id)
            => await Entities.FindAsync(id);

        public async Task InsertAsync(TEntity entity)
            => await Entities.AddAsync(entity);

        public void Update(TEntity entity)
            => Entities.Update(entity);

        public void Delete(TEntity entity)
           => Entities.Remove(entity);

    }
}
