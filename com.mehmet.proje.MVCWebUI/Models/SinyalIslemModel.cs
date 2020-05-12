using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class SinyalIslemModel
    {
        public Musteri _musteri { get; set; }
        public List<Aranacaklar> _aranacaklar { get; set; }
        public List<IslenmisSinyaller> _islenmisSinyaller { get; set; }
        public Sinyaller _sinyaller { get; set; }
    }
}