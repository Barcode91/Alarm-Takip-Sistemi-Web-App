using com.mehmet.oracle.entities.BaseClasses;
using FluentNHibernate.Mapping;
using FluentNHibernate.Utils;

namespace com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.Mapping
{
    public class PersonelMap : ClassMap<Personel>
    {
        public PersonelMap()
        {
            Id(x => x.PersonelId);
            Map(x => x.PersonelTcNo);
            Map(x => x.Parola);
            Map(x => x.CepTel);
            Map(x => x.CalismaDurumu);
            Map(x => x.IseBasTarihi);
            Map(x => x.IseCikTarihi);
            Map(x => x.Kimlik);
            Map(x => x.GorevTur);


        }
    }
}