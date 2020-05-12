using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class MusteriAddModel
    {
        public Musteri musteri { get; set; }
        //public Aranacaklar Aranacaklar { get; set; }
        public List<Aranacaklar> Aranacaklars  { get; set; }

        public string aboneNo { get; set; }

    }
}