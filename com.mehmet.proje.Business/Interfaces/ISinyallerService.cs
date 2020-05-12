using System.Collections.Generic;
using System.Linq.Expressions;
using Antlr.Runtime.Misc;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.Business.Interfaces
{
    public interface ISinyallerService
    {
        List<Sinyaller> GetAll();
        
        List<Sinyaller> GetAboneSinyal(string aboneNo);
        void Add(Sinyaller sinyaller);
        void Update(Sinyaller sinyaller);
        void Delete(Sinyaller sinyaller);
        List<string> GetSinyalAboneNo();


        Sinyaller getSinyalId(int id);
    }
}