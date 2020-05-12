using System.Collections.Generic;
using System.Linq;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.Business.Manager
{
    public class SinyallerManager : ISinyallerService
    {
        private ISinyallerDal _sinyallerDal;

        public SinyallerManager(ISinyallerDal sinyallerDal)
        {
            _sinyallerDal = sinyallerDal;
        }

        public List<Sinyaller> GetAll()
        {    //Filitreleme yazılabilir
            return _sinyallerDal.GetList();
        }
        
       
        public List<Sinyaller> GetAboneSinyal(string AboneNo)
        {
            return _sinyallerDal.GetList(p => p.AboneNo == AboneNo);
        }

        public void Add(Sinyaller sinyaller)
        {
            _sinyallerDal.Add(sinyaller);

        }

        public void Update(Sinyaller sinyaller)
        {
           _sinyallerDal.Update(sinyaller);
        }

        public void Delete(Sinyaller sinyaller)
        {
            _sinyallerDal.Delete(sinyaller);
        }

        public List<string> GetSinyalAboneNo()
        {
           return _sinyallerDal.GetSinyalAboneNo();
        }
        
        public Sinyaller getSinyalId(int id)
        {
            return _sinyallerDal.Get(x => x.SinyalId == id);
        }
    }
}