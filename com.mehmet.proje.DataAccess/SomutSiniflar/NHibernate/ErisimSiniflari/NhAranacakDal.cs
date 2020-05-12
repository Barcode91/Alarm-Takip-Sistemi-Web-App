using com.mehmet.core.DataAccess;
using com.mehmet.core.DataAccess.NHibernate;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.ErisimSiniflari
{
    public class NhAranacakDal : NhEntityRepositoryBase<Aranacaklar>, IAranacakDal
    {
        public NhAranacakDal(NhibernateHelper nhibernateHelper) : base(nhibernateHelper)
        {
        }
    }
}