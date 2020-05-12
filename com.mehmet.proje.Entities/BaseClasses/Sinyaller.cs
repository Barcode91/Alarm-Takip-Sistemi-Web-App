using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.oracle.entities.BaseClasses
{
    public class Sinyaller : IEntity
    {
        public virtual int SinyalId { get; set; }
        public virtual string AboneNo { get; set; }
       
        public virtual string SinyalKod { get; set; }
        public virtual string SinyalNitelik { get; set; }
        public virtual string Bolum { get; set; }
        public virtual string Zone { get; set; }
        public virtual string SinyalTarih { get; set; }
        public virtual int IslemDurumu { get; set; }
        public virtual string SinyalSaat { get; set; }
        public virtual string SinyalTAnim { get; set; }
       
    }
}