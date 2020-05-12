using System.Linq;
using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.core.DataAccess
{
    public interface IQeryAbleRepository<T> where T : class,IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}