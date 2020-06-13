using System;
using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class ModelDashboard
    {
        public IEnumerable<sinyalIst> IslenmisSinyal { get; set; }
        public IEnumerable<sinyalIst> Sinyal { get; set; }
        //public Dictionary<String,int> IslenmisSinyal { get; set; }
        //public Dictionary<String,int> IslenmisSinyal { get; set; }
        
    }
}