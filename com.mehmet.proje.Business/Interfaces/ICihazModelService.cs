using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.Business.Interfaces
{
    public interface ICihazModelService
    {
        List<CihazModel> GetAll();
        void Add(CihazModel cihazModel);
        void Update(CihazModel cihazModel);
        void Delete(CihazModel cihazModel);
        List<CihazModel> GetModels(int markaId); // Markanın tüm modellerini getir 
    }
}