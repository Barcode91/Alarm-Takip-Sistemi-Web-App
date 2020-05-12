using System.Reflection;
using com.mehmet.core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate
{
    public class PostgreHelper : NhibernateHelper
    {
        protected override ISessionFactory InitFactory()
        { 
            return Fluently.Configure().Database(PostgreSQLConfiguration.Standard.ConnectionString(
                    c => c.Host("localhost")
                        .Port(5432)
                        .Database("projedb")
                        .Username("proje")
                        .Password("1234"))
                ).Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())/*AddFromAssemblyOf<Musteri>()*/)
                .ExposeConfiguration(cfg=> new SchemaExport(cfg).Create(false,false))
                .BuildSessionFactory();

        }
    }
}