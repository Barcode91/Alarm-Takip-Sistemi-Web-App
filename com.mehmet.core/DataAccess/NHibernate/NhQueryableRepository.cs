using System.Linq;
using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQeryAbleRepository<T> 
        where T: class,IEntity,new()
    {
        private NhibernateHelper _nhibernateHelper; // hibernate oturumu açmayı sağlar
        private IQueryable<T> _entities; // linq ile veri tabanı tabloları üzerinde işlem yapmayı sağlar

        public NhQueryableRepository(NhibernateHelper nhibernateHelper)
        {
            _nhibernateHelper = nhibernateHelper;
        }

        public IQueryable<T> Table
        {
            get { return this.Entities; }
        }

        public virtual IQueryable<T> Entities
        {
            get
            {
                if (_entities==null)
                { // Tüm tablodaki verileri getir
                    // sonunda tolist olmadığından oturum açık kalır 
                    // filitreler direk database üzeriden yapılır
                    _entities = _nhibernateHelper.OpenSession().Query<T>();
                }

                return _entities;
            }
        }
    }
}