using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;


namespace com.mehmet.proje.MVCWebUI.Models
{
    public class MusteriModel
    {
        public Musteri MusteriBilgiler { get; set; }
        public List<Sinyaller> MusteriSinyaller { get; set; }
        
        public List<Aranacaklar> Aranacaklars { get; set; }
        public List<IslenmisSinyaller> IslenmisSinyallers { get; set; }
        
       
    }
}