using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class PersonelSinyalIslemModel
    {
        public IEnumerable<IslenmisSinyaller> IslenmisSinyallers { get; set; }
    }
}