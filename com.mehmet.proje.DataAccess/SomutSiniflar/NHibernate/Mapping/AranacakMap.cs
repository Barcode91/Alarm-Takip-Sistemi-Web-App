using com.mehmet.oracle.entities.BaseClasses;
using FluentNHibernate.Mapping;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.Mapping
{
    public class AranacakMap: ClassMap<Aranacaklar>
    {
        public AranacakMap()
        {
            Id(x=>x.aranacakId).GeneratedBy.Increment();;
            Map(x => x.aboneNo);
            Map(x => x.kimlik);
            Map(x => x.ceptel);
            Map(x => x.ceptel2);
        }
    }
}