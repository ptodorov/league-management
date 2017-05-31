using System.Threading.Tasks;

namespace OpenHouse.Core.Abstractions
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);

        Task SaveChanges();
    }
}
