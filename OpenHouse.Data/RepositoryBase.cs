using OpenHouse.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Data
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        protected DbSet<TEntity> EntitySet => _context.Set<TEntity>();

        protected DbSet<TOtherEntity> GetSet<TOtherEntity>() where TOtherEntity : class
        {
            return _context.Set<TOtherEntity>();
        }

        public void Add(TEntity entity)
        {
            EntitySet.Add(entity);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
