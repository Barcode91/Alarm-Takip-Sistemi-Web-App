using com.mehmet.core.DataAccess.NHibernate;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.ErisimSiniflari
{
    public class NhPersonelDal : NhEntityRepositoryBase<Personel>, IPersonelDal
    {
        public NhPersonelDal(NhibernateHelper nhibernateHelper) : base(nhibernateHelper)
        {
        }
    }
}