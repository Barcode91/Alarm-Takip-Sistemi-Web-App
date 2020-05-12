using com.mehmet.oracle.entities.BaseClasses;
using FluentNHibernate.Mapping;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.Mapping
{
    public class IslenmisSinyallerMap:ClassMap<IslenmisSinyaller>
    {
        public IslenmisSinyallerMap()
        {
            Id(x => x.SinyalId);
            Map(x => x.AboneNo);
            Map(x => x.SinyalKod);
            Map(x => x.SinyalNitelik);
            Map(x => x.Bolum);
            Map(x => x.Zone);
            Map(x => x.SinyalSaat);
            Map(x => x.SinyalTarih);
            Map(x => x.IslemDurumu);
            Map(x => x.OperatorId);
            Map(x => x.IslemAcıklama);
            Map(x => x.IslemTarih);
            Map(x => x.IslemSaat);
            Map(x => x.SinyalTAnim);
            
            
        }
    }
}