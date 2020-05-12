using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.DataAccess.SoyutSiniflar;

namespace com.mehmet.proje.Business.Manager
{
    public class IslenmisSinyallerManager : IIslenmisSinyallerService
    {
        private IIslenmisSinyaller _islenmisSinyaller;

        public IslenmisSinyallerManager(IIslenmisSinyaller islenmisSinyaller)
        {
            _islenmisSinyaller = islenmisSinyaller;
        }

        public List<IslenmisSinyaller> GetAll()
        {
            return _islenmisSinyaller.GetList();
        }

        public void Add(IslenmisSinyaller sinyaller)
        {

            _islenmisSinyaller.Add(sinyaller);
        }

        public void Update(IslenmisSinyaller sinyaller)
        {
            _islenmisSinyaller.Update(sinyaller);
        }

        public void Delete(IslenmisSinyaller sinyaller)
        {
            _islenmisSinyaller.Delete(sinyaller);
        }

        public List<IslenmisSinyaller> GetAboneSinyal(string aboneNo)
        {
            return _islenmisSinyaller.GetList(x => x.AboneNo == aboneNo);
        }
    }
}