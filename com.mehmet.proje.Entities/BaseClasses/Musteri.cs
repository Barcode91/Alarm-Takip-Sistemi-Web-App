using System.ComponentModel.DataAnnotations;
using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.oracle.entities.BaseClasses
{
    public class Musteri : IEntity
    {    
       
        public virtual int MusteriId { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string AboneNo { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string Kimlik { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string Adres { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string AdresIlce { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string AdresIl { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string EvTel { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string CepTel { get; set; }
        public virtual string ChMarka { get; set; }
        public virtual string ChModel { get; set; }
        public virtual string ChGarantiSuresi { get; set; }
        public virtual string HaberlesmeTuru { get; set; }
        public virtual string hatDurumu { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string AboneBasTarihi { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string AboneBitTarihi { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string MusteriTcNo { get; set; }
        public virtual string Parola { get; set; }
       
    }
}