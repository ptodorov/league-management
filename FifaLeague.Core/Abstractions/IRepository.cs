using System.Threading.Tasks;

namespace FifaLeague.Core.Abstractions
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);

        Task SaveChanges();
    }
}
