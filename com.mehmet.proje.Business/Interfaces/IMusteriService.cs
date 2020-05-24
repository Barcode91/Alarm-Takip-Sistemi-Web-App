using System;
using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.Business.Interfaces
{
    public interface IMusteriService
    {
        List<Musteri> GetAll();
        void Add(Musteri musteri);
        Musteri Update(Musteri musteri);
        void Delete(Musteri musteri);
        string GetByAboneNo(int musteriId);
        Musteri GetAbone(string aboneNo);
        Musteri GetById(int musteriId);
        
        Musteri LoginCont(string aboneNo, string parola);
    }
}