using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.oracle.entities.ComplexClasses;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class OperaTorModel
    {
        public Personel personel{ get; set; }

        public IEnumerable<IslenmisSinyaller> islemlerim { get; set; }
        public List<TamMusteri> TamMusteris { get; set; }
        
        public List<Sinyaller> Sinyallers { get; set; }
    }
}