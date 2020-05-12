using System;
using System.ComponentModel.DataAnnotations;
using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.oracle.entities.BaseClasses
{
    public class Aranacaklar : IEntity
    {
        public virtual int aranacakId { get; set; }
       public virtual string aboneNo { get; set; }
       [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string kimlik { get; set; }
        [Required(ErrorMessage = "Alan Boş Geçilemez")]
        public virtual string ceptel { get; set; }
        public virtual string ceptel2 { get; set; }

    }
}