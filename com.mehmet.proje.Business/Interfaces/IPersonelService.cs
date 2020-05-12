using System.Collections.Generic;
using System.Linq.Expressions;
using Antlr.Runtime.Misc;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.Business.Interfaces
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        void Add(Personel personel);
        void Update(Personel personel);
        void Delete(Personel personel);
        Personel GetById(int id);
        
        Personel LoginCont(string tcNo, string parola);
        
    }
}