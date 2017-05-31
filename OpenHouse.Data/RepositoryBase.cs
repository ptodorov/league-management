using OpenHouse.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Data
{
    class RepositoryBase<TEntity> : IRepository<TEntity>
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
