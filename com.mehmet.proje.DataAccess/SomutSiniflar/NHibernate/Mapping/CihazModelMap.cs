using com.mehmet.oracle.entities.BaseClasses;
using FluentNHibernate.Mapping;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.Mapping
{
    public class CihazModelMap : ClassMap<CihazModel>
    {
        public CihazModelMap()
        {
            Id(x => x.ModelId);
            Map(x => x.MarkaId);
            Map(x => x.ModelAdi);
        }
    }
}