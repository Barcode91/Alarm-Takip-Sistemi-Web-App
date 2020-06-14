using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.MVCWebUI.Models;
using FluentNHibernate.Conventions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;


namespace com.mehmet.proje.MVCWebUI.Controllers
{      
    [Authorize(Policy = "UserClaimPositionPolicy")]
    public class AdminController : Controller
    {
        public AdminController(IPersonelService personelService,IMusteriService musteriService, IAranacakService aranacakService, ISinyallerService sinyallerService, IIslenmisSinyallerService islenmisSinyallerService)
        {
            _musteriService = musteriService;
            _aranacakService = aranacakService;
            _SinyallerService = sinyallerService;
            _islenmisSinyallerService = islenmisSinyallerService;
            _PersonelService = personelService;
        }

        public IMusteriService _musteriService;
        public IAranacakService _aranacakService;
        public ISinyallerService _SinyallerService;
        public IPersonelService _PersonelService;
        public IIslenmisSinyallerService _islenmisSinyallerService;
      
        public IActionResult Index()
        {
            return RedirectToAction("BekleyenSinyal");
        }
       
        public IActionResult Kayit()
        {   
            
            MusteriAddModel musteriAddModel = new MusteriAddModel
            {
                musteri = new Musteri(),
               Aranacaklars = new List<Aranacaklar>
               {
                   new Aranacaklar(),
                   new Aranacaklar()
               }
               
              };
            ViewBag.baslik = "Kayıt Paneli";
            
            return View(musteriAddModel); //Boş model gönderildi
        }
       
        [HttpPost]
        public IActionResult Kayit(MusteriAddModel musteriAddModel)
        {
            if (ModelState.IsValid) // Gerekli Alanlar Dolduruldu ise
            {
                try
                {
                    // Veri tabanına kayıt işlemleri
                    musteriAddModel.musteri.Parola = "1234";
                    _musteriService.Add(musteriAddModel.musteri);
                    foreach (var arakisi in musteriAddModel.Aranacaklars)
                    {
                        arakisi.aboneNo = musteriAddModel.musteri.AboneNo;
                        _aranacakService.Add(arakisi);
                    }
                    TempData["sonuc"] = "0";
                }
                catch (Exception e)
                { Console.WriteLine(e);
                    TempData["sonuc"] = "1";
                   
                }
            }
            return View();
        }
        
       
        public IActionResult Aboneler()
        {
            AdminAbonelerModel abonelerModel = new AdminAbonelerModel
            {
                musteriler = _musteriService.GetAll()
            };
            return View(abonelerModel);
        }
        
      
        [HttpPost]
        public IActionResult Aboneler(string aboneNo)
        {
            
            AdminAbonelerModel abonelerModel;
            if (string.IsNullOrEmpty(aboneNo))
            {
                return RedirectToAction("Aboneler");
            }
            else
            {
                Console.WriteLine("Birden fazla Abone --------"+aboneNo);
                abonelerModel = new AdminAbonelerModel
                {
                    tekMusteri = _musteriService.GetAbone(aboneNo)

                };
                
                if (abonelerModel.tekMusteri==null)
                {
                    return RedirectToAction("Aboneler");
                
                }
                List<Musteri> musteris = new List<Musteri>();
                musteris.Add(abonelerModel.tekMusteri);
                //abonelerModel.musteriler.Add(abonelerModel.tekMusteri);
                Console.WriteLine("Birden fazla Abone --------"+abonelerModel.tekMusteri.Kimlik+"boyut   "+musteris.Count);
                abonelerModel.musteriler = musteris;
                //return RedirectToAction("Aboneler", "Admin", abonelerModel);
                return View(abonelerModel);
            }
            

            
            //Console.WriteLine("Birden fazla Abone"+abonelerModel.musteriler.Count);
            //Console.WriteLine("Tek müşteri",abonelerModel.tekMusteri);
            //TempData["mesaj"] =null;
            //
        }
        
        
        public IActionResult AboneGuncelle(int musteriId)
        {
            if (musteriId!=0)
            {
                MusteriAddModel addModel = new MusteriAddModel
                {
                    musteri = _musteriService.GetById(musteriId),
                    Aranacaklars = _aranacakService.GetAll(_musteriService.GetByAboneNo(musteriId))
                };
               
                return View(addModel);
            }
            return View();
        }
        [HttpPost]
        public IActionResult AboneGuncelle(MusteriAddModel model)
        {
            if (ModelState.IsValid) // Gerekli Alanlar Dolduruldu ise
            {
                try
                {
                    // Veri tabanına kayıt işlemleri
                    _musteriService.Update(model.musteri);
                    foreach (var arakisi in model.Aranacaklars)
                    {
                        _aranacakService.Update(arakisi);
                    }
                    TempData["sonuc"] = "0";
                }
                catch (Exception e)
                { Console.WriteLine(e);
                    TempData["sonuc"] = "1";
                }
            }
            return View();
        }

        public IActionResult AboneBilgi(int musteriId, int? page)
        {
            var pageNumber = page ?? 1; 
            int pageSize = 30; 
            if (musteriId!=0)
            {
                MusteriModel addModel = new MusteriModel()
                {
                    MusteriBilgiler = _musteriService.GetById(musteriId),
                    Aranacaklars = _aranacakService.GetAll(_musteriService.GetByAboneNo(musteriId)),
                    MusteriSinyaller = _SinyallerService.GetAboneSinyal(_musteriService.GetByAboneNo(musteriId)).OrderByDescending(x=>x.SinyalId).ToList().ToPagedList(pageNumber, pageSize),
                    IslenmisSinyallers = _islenmisSinyallerService.GetAboneSinyal(_musteriService.GetByAboneNo(musteriId)).OrderByDescending(x=>x.SinyalId).ToList().ToPagedList(pageNumber, pageSize)
                    
                };
               
                return View(addModel);
            }
            return View();
        }

        public IActionResult AboneSil(int musteriId)
        {
            Musteri musteri = _musteriService.GetById(musteriId);
            List<Aranacaklar> aranacaklars = _aranacakService.GetAll(musteri.AboneNo);
            List<Sinyaller> sinyallers = _SinyallerService.GetAboneSinyal(musteri.AboneNo);
            try
            {
                _musteriService.Delete(musteri);
                foreach (var aranacak in aranacaklars)
                {
                    _aranacakService.Delete(aranacak);
                }

                foreach (var sinyal in sinyallers)
                {
                    _SinyallerService.Delete(sinyal);
                }

                TempData["mesaj"] = "0";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TempData["mesaj"] = "1";
                
            }


            return RedirectToAction("Aboneler", "Admin");
        }


        public IActionResult Personeller()
        {
            AdminPersonelModel personelModel = new AdminPersonelModel
            {
                _personels = _PersonelService.GetAll()
            };
            return View(personelModel);
        }

        public IActionResult personelEkle()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult personelEkle(PersonelEkleModel model)
        {
            model._personel.CalismaDurumu = "Aktif";
            model._personel.Parola = "0000";
            _PersonelService.Add(model._personel);
            //ViewData["sonuc"] = "Personel Kayıt Edildi";
            ModelState.AddModelError("Sonuc","Personel Başarı İle Kayıt Edildi.");
            return View();
        }
        [HttpPost]
        public IActionResult personelUpdate(PersonelEkleModel model)
        { _PersonelService.Update(model._personel);
            ModelState.AddModelError("Sonuc","Personel Başarı İle Güncellendi.");
            return View("personelEkle");
        }

        public IActionResult PersonelBilgi(int id)
        
        {    Console.WriteLine("Personel id"+id);
             PersonelEkleModel model = new PersonelEkleModel
            {
                _personel = _PersonelService.GetById(id)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult PersonelSil(int perid)
        {    Console.WriteLine("test----"+perid);
            Personel per = _PersonelService.GetById(perid);
            Console.WriteLine("test----"+per.Kimlik);
           _PersonelService.Delete(per);
           return View("Index");
        }

        public IActionResult IslenmisSinyal(int? page)
        {
            var pageNumber = page ?? 1; 
            int pageSize = 30; 
            TumSinyaller model = new TumSinyaller
            {
                _islenmisSinyal = _islenmisSinyallerService.GetAll().OrderByDescending(x=>x.SinyalId).ToPagedList(pageNumber,pageSize)
            };
            return View(model);
        }

        public IActionResult BekleyenSinyal(int? page)
        {
            var pageNumber = page ?? 1; 
            int pageSize = 30;
            BekleyenSinyalModel model = new BekleyenSinyalModel
            {
                _sinyaller = _SinyallerService.GetAll().OrderByDescending(x=>x.SinyalId).ToPagedList(pageNumber, pageSize)
            };
            return View(model);
        }

        
        public IActionResult PersonelSinyal(String Kimlik)
        {
            Console.WriteLine(Kimlik);
            PersonelSinyalIslemModel model = new PersonelSinyalIslemModel
            {
                IslenmisSinyallers = _islenmisSinyallerService.GetOperatorSinyal(Kimlik)
            };
            Console.WriteLine("VERİ SAYISI ",model.IslenmisSinyallers.Count());
            ViewBag.kimlik = Kimlik;
            return View(model);
        }

        public IActionResult Dashboard()
        {
            var sinyallers = _SinyallerService.GetAll();
            var ist = sinyallers.OrderBy(x => x.SinyalKod)
                .GroupBy(x => x.SinyalKod)
                .Select(sinyalist => new sinyalIst {sinyalTur = sinyalist.Key, sinyalsayi = sinyalist.Count()});

            var issinyaller = _islenmisSinyallerService.GetAll();
            var isist = issinyaller.OrderBy(x => x.SinyalKod)
                .GroupBy(x => x.SinyalKod)
                .Select(sinyalist => new sinyalIst {sinyalTur = sinyalist.Key, sinyalsayi = sinyalist.Count()});
                
            List<int> islenmisIstsay = new List<int>();
            List<string> islenmisIsttur = new List<string>();
            
            List<int> islenmemisIstsay = new List<int>();
            List<string> islenmemisIsttur = new List<string>();
            
            foreach (var sayi in ist)
            {
                islenmemisIstsay.Add(sayi.sinyalsayi);
                islenmemisIsttur.Add(sayi.sinyalTur);
            }
            
            foreach (var sayi in isist)
            {
                islenmisIstsay.Add(sayi.sinyalsayi);
                islenmisIsttur.Add(sayi.sinyalTur);
            }

            ViewBag.SINYALSAYI = islenmemisIstsay; // işlenmemiş sinyal sayiları
            ViewBag.SINYALTUR = islenmemisIsttur; // işlenmemiş sinyal türleri
            ViewBag.ISSINYALSAYI = islenmisIstsay; // işlenmiş sinyal sayiları
            ViewBag.ISSINYALTUR = islenmisIsttur; // işlenmiş sinyal türleri
           
            //müşterilerin sinyal istatistlikleri
            //x---abone no
            //y--sinyal sayi
            //işlenmemiş sinyaller
            var aboneist = sinyallers.OrderBy(x => x.AboneNo)
                .GroupBy(x => x.AboneNo)
                .Select(sinyalist => new sinyalIst {sinyalTur = sinyalist.Key, sinyalsayi = sinyalist.Count()});
            //işlenmiş sinyaller
            var aboneisist = issinyaller.OrderBy(x => x.AboneNo)
                .GroupBy(x => x.AboneNo)
                .Select(sinyalist => new sinyalIst {sinyalTur = sinyalist.Key, sinyalsayi = sinyalist.Count()});
            
            List<int> islenmisAbnSay = new List<int>();
            List<string> islenmisAbno = new List<string>();
            
            List<int> islenmemisAbnSay = new List<int>();
            List<string> islenmemisAbno = new List<string>();
            
            foreach (var sayi in aboneist)
            {
                islenmemisAbnSay.Add(sayi.sinyalsayi); // Abone no
                islenmemisAbno.Add(sayi.sinyalTur); // sinyal sayıları
            }
            
            foreach (var sayi in aboneisist)
            {
                islenmisAbnSay.Add(sayi.sinyalsayi);
                islenmisAbno.Add(sayi.sinyalTur);
            }

            ViewBag.ISLENMISABNSAY = islenmisAbnSay;
            ViewBag.ISLENMISABNO = islenmisAbno;
            ViewBag.ISLENMEMISABNSAY = islenmemisAbnSay;
            ViewBag.ISLENMEMISABNO = islenmemisAbno;
            
            
            //Tarihe göre sinyal sayıları
            var Tarihist = sinyallers.OrderByDescending(x => x.SinyalTarih)
                .GroupBy(x => x.SinyalTarih)
                .Select(Tarihist => new sinyalIst {sinyalTur = Tarihist.Key, sinyalsayi = Tarihist.Count()});
            //işlenmiş sinyaller
            var Tarihisist = issinyaller.OrderByDescending(x => x.SinyalTarih)
                .GroupBy(x => x.SinyalTarih)
                .Select(Tarihisist => new sinyalIst {sinyalTur = Tarihisist.Key, sinyalsayi = Tarihisist.Count()});
            
            List<int> islenmisTarihSay = new List<int>();
            List<string> islenmisTarih = new List<string>();
            
            List<int> islenmemisTarihSay = new List<int>();
            List<string> islenmemisTarih = new List<string>();
            
            foreach (var sayi in Tarihisist)
            {
                islenmisTarihSay.Add(sayi.sinyalsayi); // sinyal sayıları
                islenmisTarih.Add(sayi.sinyalTur); //  Tarihler
            }
            
            foreach (var sayi in Tarihist)
            {
                islenmemisTarihSay.Add(sayi.sinyalsayi);
                islenmemisTarih.Add(sayi.sinyalTur);
            }
            
            ViewBag.ISLENMISTRHSAY = islenmisTarihSay;
            ViewBag.ISLENMISTRH = islenmisTarih;
            ViewBag.ISLENMEMISTRHSAY = islenmemisTarihSay;
            ViewBag.ISLENMEMISTRH = islenmemisTarih;
            
            
            //Operatör istatistikleri
            var operatr = issinyaller.OrderByDescending(x => x.OperatorId)
                .GroupBy(x => x.OperatorId)
                .Select(operatr => new sinyalIst {sinyalTur = operatr.Key, sinyalsayi = operatr.Count()});
            
            List<int> operSayi = new List<int>();
            List<string> operId = new List<string>();
            
            foreach (var sayi in operatr)
            {
                operSayi.Add(sayi.sinyalsayi); // sinyal sayıları
                operId.Add(sayi.sinyalTur); //  operatör id
            }
            
            ViewBag.OPERATORSAY = operSayi;
            ViewBag.OPERATORNO = operId;
            

            return View();
        }
    }
}