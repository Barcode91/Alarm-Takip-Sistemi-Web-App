using System.Collections.Generic;
using System.Linq.Expressions;
using Antlr.Runtime.Misc;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.Business.Manager
{
    public class PersonelManager : IPersonelService
    {
        private IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetAll()
        {    //Linq kullanılarak filitre verilir
            return _personelDal.GetList();
        }

        public void Add(Personel personel)
        {
            _personelDal.Add(personel);
        }

        public void Update(Personel personel)
        {
            _personelDal.Update(personel);
        }

        public void Delete(Personel personel)
        {
            _personelDal.Delete(personel);
        }

        public Personel GetById(int id)
        { //idsi verilen personel getirilir Linq kullanılarak filitre verilir
            return _personelDal.Get(p => p.PersonelId == id);
        }

        public Personel LoginCont(string tcNo, string parola)
        {
            return _personelDal.Get(x => x.PersonelTcNo == tcNo && x.Parola == parola);
        }
    }
}