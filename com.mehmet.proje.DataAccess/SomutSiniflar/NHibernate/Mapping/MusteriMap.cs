using com.mehmet.oracle.entities.BaseClasses;
using FluentNHibernate.Mapping;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.Mapping
{
    public class MusteriMap : ClassMap<Musteri>
    {
        public MusteriMap()
        {
            //Table(@"musteri");
            LazyLoad();
            Id(x => x.MusteriId);
            Map(x => x.AboneNo);
            Map(x => x.Kimlik);
            Map(x => x.Adres);
            Map(x => x.AdresIlce);
            Map(x => x.AdresIl);
            Map(x => x.EvTel);
            Map(x => x.CepTel);
            Map(x => x.ChMarka);
            Map(x => x.ChModel);
            Map(x => x.ChGarantiSuresi);
            Map(x => x.AboneBasTarihi);
            Map(x => x.AboneBitTarihi);
            Map(x => x.MusteriTcNo);
            Map(x => x.Parola);
            Map(x => x.HaberlesmeTuru);
            Map(x => x.hatDurumu);
           
        }
    }
}