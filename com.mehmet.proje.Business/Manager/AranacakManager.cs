using System;
using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.Business.Manager
{
    public class AranacakManager : IAranacakService
    {
        private IAranacakDal _aranacakDal;

        public AranacakManager(IAranacakDal aranacakDal)
        {
            _aranacakDal = aranacakDal;
        }

        public List<Aranacaklar> GetAll(String aboneNo)
        {
            return _aranacakDal.GetList(x=>x.aboneNo==aboneNo);
        }

        public void Add(Aranacaklar aranacaklar)
        {
            _aranacakDal.Add(aranacaklar);
        }

        public void Update(Aranacaklar aranacaklar)
        {
            _aranacakDal.Update(aranacaklar);
        }

        public void Delete(Aranacaklar aranacaklar)
        {
            _aranacakDal.Delete(aranacaklar);
        }
    }
}