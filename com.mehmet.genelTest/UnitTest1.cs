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

            List<string> abone = new List<string>{"A1001", "A1002", "A1003", "A1004", "A1005", "A1006", "A1007", "A1008"};
            List<string> sinyalkod = new List<string>
            {
                "E400", "E402","E401", "E405","E403", "E200", "E211", "E222", "E233", "E255"
                , "E100", "E120", "E140"
 
                
            };
            
            List<string> sinyaltanim = new List<string>
            {
                "İş yeri Açıldı", "Erken Açılış","Kumanda İle Açılış", "Kumanda ile Mesai Dışı Giriş","Mesai Dışı Giriş", "Tek Göz Hırsılık Alarmı", "Sabotaj", "Heryerden Hırsılık Alarmı", "Darbe Alarmı", "Ambulans Alarmı"
                , "Sistem Arızası", "Elektrik Arızası", "Telefon Arızası"
            };

            List<string> tarih = new List<string> { "13-06-2020","13-06-2020","13-06-2020","13-06-2020"
                ,"13-06-2020","13-06-2020","13-06-2020","13-06-2020","13-06-2020","13-06-2020","13-06-2020",
                "13-06-2020","13-06-2020" };
            
            List<string> saat = new List<string>
            {
                "07:00","07:32","08:23","10:12","17:02","07:55","11:00","15:00","16:12",
                "23:00","21:32","01:23","03:12","18:02","13:55","09:45","23:56","05:12"
            };

            
            
            
            Random rastgele = new Random();
           

            for (int i = 0; i < 15; i++)
            {
                int sayi = rastgele.Next(8);
                int sayi2 = rastgele.Next(12);
                int sayi3 = rastgele.Next(17);
                var a = new Sinyaller() { 
                    SinyalKod = sinyalkod[sayi2] ,SinyalNitelik = "YENİ",SinyalSaat = saat[sayi3],SinyalTarih = "14.06.2020",IslemDurumu = 1,
                    AboneNo = abone[sayi],Bolum = sayi.ToString(),Zone = sayi2.ToString(), SinyalTAnim = sinyaltanim[sayi2]
                
                };
                
                var sonuc = sinyaller.Add(a);
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