using System;
using NHibernate;

namespace com.mehmet.core.DataAccess.NHibernate
{
    public abstract class NhibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitFactory()); }
        }

        protected abstract ISessionFactory InitFactory();

       // OTURUM AÇILIR
        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
     
        public void Dispose()
        {    //GARBAGE COLLECTOR Çağırılır
            GC.SuppressFinalize(this);
        }
    }
}