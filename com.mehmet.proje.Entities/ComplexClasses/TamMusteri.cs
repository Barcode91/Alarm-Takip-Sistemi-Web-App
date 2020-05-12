using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.oracle.entities.ComplexClasses
{
    public class TamMusteri
    {
        public Musteri _musteri;
        public List<Aranacaklar> _aranacaklars;
        public List<Sinyaller> _sinyallers;
        public List<IslenmisSinyaller> IslenmisSinyallers;
    }
}