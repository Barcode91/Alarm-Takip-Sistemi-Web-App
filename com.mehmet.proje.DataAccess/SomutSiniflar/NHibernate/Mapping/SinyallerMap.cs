using com.mehmet.oracle.entities.BaseClasses;
using FluentNHibernate.Mapping;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.Mapping
{
    public class SinyallerMap : ClassMap<Sinyaller>
    {
        public SinyallerMap()
        {   // Table(@"SINYALLER");
            LazyLoad();
            Id(x => x.SinyalId);
            Map(x => x.AboneNo);
            Map(x => x.SinyalKod);
            Map(x => x.SinyalNitelik);
            Map(x => x.Bolum);
            Map(x => x.Zone);
            Map(x => x.SinyalTarih);
            Map(x => x.SinyalSaat);
            Map(x => x.IslemDurumu);
            Map(x => x.SinyalTAnim);


        }
    }
}