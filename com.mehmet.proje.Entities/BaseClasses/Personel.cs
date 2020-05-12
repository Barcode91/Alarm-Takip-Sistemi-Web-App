using System.ComponentModel.DataAnnotations;
using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.oracle.entities.BaseClasses
{
    public class Personel:IEntity
    {
        public virtual int PersonelId { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string Kimlik { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string PersonelTcNo { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string GorevTur { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string CepTel { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string IseBasTarihi { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string IseCikTarihi { get; set; }
        public virtual string Parola { get; set; }
        public virtual string CalismaDurumu { get; set; }

    }
}