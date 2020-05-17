using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using NHibernate.Mapping;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class BekleyenSinyalModel
    {
        public List<Sinyaller> _sinyaller { get; set; }
    }
}