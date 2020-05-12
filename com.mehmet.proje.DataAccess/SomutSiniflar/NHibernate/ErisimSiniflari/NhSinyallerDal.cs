using com.mehmet.core.DataAccess.NHibernate;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.ErisimSiniflari
{
    public class NhSinyallerDal: NhEntityRepositoryBase<Sinyaller>, ISinyallerDal
    {
        public NhSinyallerDal(NhibernateHelper nhibernateHelper) : base(nhibernateHelper)
        {
        }
    }
}