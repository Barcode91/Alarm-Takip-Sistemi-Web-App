using System;
using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Manager;
using com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate;
using com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.ErisimSiniflari;
using com.mehmet.proje.DataAccess.SoyutSiniflar;
using Moq;
using NUnit.Framework;

namespace com.mehmet.genelTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1() // Veri Erişim Katmanı Testi
        { NhSinyallerDal sinyaller = new NhSinyallerDal(new PostgreHelper());
           

            
            
            var sinyal = new Sinyaller() { 
               SinyalKod = "E200",SinyalNitelik = "YENİ",SinyalSaat = "03:20",SinyalTarih = "20.02.2020",IslemDurumu = 1,
               AboneNo = "A1001",Bolum = "08",Zone = "12", SinyalTAnim = "Hırsızlık Alarmı"
                
            };


            for (int i = 0; i < 2; i++)
            {
                var sonuc = sinyaller.Add(sinyal);
            }
            
           
            //Assert.AreNotEqual(0,sonuc.SinyalId);
        }
        [Test]
        public void Test2() // Service Katmanı Testi
        {    var marka = new CihazMarka()
            {
                MarkaAdi = "DSC"
            };
            Mock<ICihazMarkaDal> mok = new Mock<ICihazMarkaDal>();
            CihazMarkaManager cihazMarkaManager = new CihazMarkaManager(mok.Object);
            cihazMarkaManager.Add(marka);
            
            
        }
        
        [Test]
        public void UpdateTEst() // Veri Erişim Katmanı Testi
        { 
            NhMusteriDal musteriDal = new NhMusteriDal(new PostgreHelper());

            var musteri = new Musteri() { 
                MusteriId = 381,
                Kimlik = "fatma aktaş",AboneNo = "A10032",Adres = "ajdasj",AdresIl = "anakra",
                AdresIlce = "yenimahalle",CepTel = "34534545",EvTel = "234324324",AboneBasTarihi = "23434",AboneBitTarihi = "32434",
                ChGarantiSuresi = "3434",HaberlesmeTuru = "gsm",hatDurumu = "res",Parola = "123",ChMarka = "paradox",ChModel = "sp400",
                MusteriTcNo = "1232131238"
                
            };
            var sonuc = musteriDal.Update(musteri);
           
            //Assert.Equals(0,sonuc.MusteriId);
        }
        [Test]
        public void aranacaktest() // Veri Erişim Katmanı Testi
        { 
            NhAranacakDal aranacakDal = new NhAranacakDal(new PostgreHelper());

            var ara = new Aranacaklar() { 
                aboneNo = "A10033",kimlik = "fatma aktaş",ceptel = "121123123",ceptel2 = "89898989"
                
            };
            var sonuc = aranacakDal.Add(ara);
           
            //Assert.Equals(0,sonuc.MusteriId);
        }
        [Test]
        public void logintest() // Veri Erişim Katmanı Testi
        {     
            MusteriManager manager = new MusteriManager(new NhMusteriDal(new PostgreHelper()));
            
            Musteri musteri=manager.LoginCont("A1001", "123");
            if (musteri==null)
            {
                Console.WriteLine("HASYDA");
            }
            else
            {
                Console.WriteLine(musteri.Kimlik);
            }
            
           
           
           
            //Assert.Equals(1,musteri.MusteriId);
            
        }
        
        [Test]
        public void gettest() // Veri Erişim Katmanı Testi
        {     
            SinyallerManager manager = new SinyallerManager(new NhSinyallerDal(new PostgreHelper()));

           List<string> memo= manager.GetSinyalAboneNo();

           foreach (var mem in memo)
           {
               Console.WriteLine("HASYDA"+mem);
           }
               
            
            
               // Console.WriteLine(musteri.Kimlik);
            
            
           
           
           
            //Assert.Equals(1,musteri.MusteriId);
            
        }
        
        [Test]
        public void aratest() // Veri Erişim Katmanı Testi
        {     
            MusteriManager manager = new MusteriManager(new NhMusteriDal(new PostgreHelper()));

            var musteri = manager.GetAbone("A1001");

          
            
            
             //Console.WriteLine("YAZ"+musteri.MusteriId);
            
            
           
           
           
            //Assert.Equals("A1001",musteri.AboneNo);
            
        }

        
        
        
    }
}