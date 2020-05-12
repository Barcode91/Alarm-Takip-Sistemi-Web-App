using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.oracle.entities.BaseClasses
{
    public class CihazModel :IEntity
    {
        public virtual int ModelId { get; set; }
        public virtual int MarkaId { get; set; }
        public virtual string ModelAdi { get; set; }
        
        
    }
}