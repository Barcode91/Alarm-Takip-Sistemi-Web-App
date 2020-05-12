using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.Business.Interfaces
{
    public interface ICihazMarkaService
    {
        List<CihazMarka> GetAll();
        void Add(CihazMarka cihazMarka);
        void Update(CihazMarka cihazMarka);
        void Delete(CihazMarka cihazMarka);
        
    }
}