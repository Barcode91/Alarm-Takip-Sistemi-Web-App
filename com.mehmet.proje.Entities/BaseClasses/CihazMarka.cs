using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.oracle.entities.BaseClasses
{
    public class CihazMarka : IEntity
    {
        public virtual int MarkaId { get; set; }
       
        public virtual string MarkaAdi { get; set; }
    }
}