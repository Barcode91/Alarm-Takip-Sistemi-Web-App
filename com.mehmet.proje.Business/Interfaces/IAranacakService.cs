using System;
using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.Business.Interfaces
{
    public interface IAranacakService
    {
        List<Aranacaklar> GetAll(String aboneNo);
        void Add(Aranacaklar aranacaklar);
        void Update(Aranacaklar aranacaklar);
        void Delete(Aranacaklar aranacaklar);
    }
}