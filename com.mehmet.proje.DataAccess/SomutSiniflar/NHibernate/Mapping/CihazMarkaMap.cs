using com.mehmet.oracle.entities.BaseClasses;
using FluentNHibernate.Mapping;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.Mapping
{
    public class CihazMarkaMap : ClassMap<CihazMarka>
    {
        public CihazMarkaMap()
        {
            Id(x => x.MarkaId);
            Map(x => x.MarkaAdi);
           
        }
    }
}