using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using NHibernate.Mapping;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class BekleyenSinyalModel
    {
        public IEnumerable<Sinyaller> _sinyaller { get; set; }
    }
}