using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.Business.Manager
{
    public class CihazModelManager : ICihazModelService
    {
        private ICihazModelDal _cihazModelDal;

        public CihazModelManager(ICihazModelDal cihazModelDal)
        {
            _cihazModelDal = cihazModelDal;
        }

        public List<CihazModel> GetAll()
        {
            return _cihazModelDal.GetList();
        }

        public void Add(CihazModel cihazModel)
        {
            _cihazModelDal.Add(cihazModel);
        }

        public void Update(CihazModel cihazModel)
        {
            _cihazModelDal.Update(cihazModel);
        }

        public void Delete(CihazModel cihazModel)
        {
            _cihazModelDal.Delete(cihazModel);
        }


        public List<CihazModel> GetModels(int markaId)
        {    //Bir Markanın Tüm modelleri getirilir
           return _cihazModelDal.GetList(p => p.MarkaId == markaId);
        }
    }
}