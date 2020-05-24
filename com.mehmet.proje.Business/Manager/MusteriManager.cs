using System;
using System.Collections.Generic;
using System.Linq;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.Business.Manager
{
    public class MusteriManager : IMusteriService
    {
        private IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public List<Musteri> GetAll()
        {
            return _musteriDal.GetList();
        }
        
        public List<Musteri> GetIstenilen(string sorgu)
        { // sorgu kısmına bakılacak
            return _musteriDal.GetList();
        }


        public void Add(Musteri musteri)
        {
            _musteriDal.Add(musteri);
        }

        public Musteri Update(Musteri musteri)
        {
            return _musteriDal.Update(musteri);
        }

        public void Delete(Musteri musteri)
        {
            _musteriDal.Delete(musteri);
        }

        public string GetByAboneNo(int musteriId)
        {
           var musteri= _musteriDal.Get(p => p.MusteriId==musteriId);
           return musteri.AboneNo;
        }

        public Musteri GetAbone(string aboneNo)
        {
            return _musteriDal.Get(p => p.AboneNo == aboneNo);
        }

        public Musteri GetById(int musteriId)
        {
            return _musteriDal.Get(x => x.MusteriId == musteriId);
        }

        public Musteri LoginCont(string aboneNo, string parola)
        {
            return _musteriDal.Get(x => x.AboneNo == aboneNo && x.Parola == parola);
          
            

        }
    }
}