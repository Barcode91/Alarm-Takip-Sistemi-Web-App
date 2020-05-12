using System.Collections.Generic;
using System.Linq.Expressions;
using Antlr.Runtime.Misc;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.Business.Interfaces
{
    public interface IIslenmisSinyallerService
    {
        List<IslenmisSinyaller> GetAll();
        void Add(IslenmisSinyaller sinyaller);
        void Update(IslenmisSinyaller sinyaller);
        void Delete(IslenmisSinyaller sinyaller);
        List<IslenmisSinyaller> GetAboneSinyal(string aboneNo);
    }
}