using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.Business.Manager
{
    public class CihazMarkaManager : ICihazMarkaService
    {
        private ICihazMarkaDal _cihazMarkaDal;

        public CihazMarkaManager(ICihazMarkaDal cihazMarkaDal)
        {
            _cihazMarkaDal = cihazMarkaDal;
        }

        public List<CihazMarka> GetAll()
        {
            return _cihazMarkaDal.GetList();
        }

        public void Add(CihazMarka cihazMarka)
        {
            _cihazMarkaDal.Add(cihazMarka);
        }

        public void Update(CihazMarka cihazMarka)
        {
            _cihazMarkaDal.Update(cihazMarka);
        }

        public void Delete(CihazMarka cihazMarka)
        {
            _cihazMarkaDal.Delete(cihazMarka);
        }

       
    }
}