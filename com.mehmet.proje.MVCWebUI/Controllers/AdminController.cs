using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Policy;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.MVCWebUI.Models;
using FluentNHibernate.Conventions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace com.mehmet.proje.MVCWebUI.Controllers
{      
    [Authorize(Policy = "UserClaimPositionPolicy")]
    public class AdminController : Controller
    {
        public AdminController(IPersonelService personelService,IMusteriService musteriService, IAranacakService aranacakService, ISinyallerService sinyallerService)
        {
            _musteriService = musteriService;
            _aranacakService = aranacakService;
            _SinyallerService = sinyallerService;
            _PersonelService = personelService;
        }

        public IMusteriService _musteriService;
        public IAranacakService _aranacakService;
        public ISinyallerService _SinyallerService;
        public IPersonelService _PersonelService;
      
        public IActionResult Index()
        {
            return View();
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
                abonelerModel = new AdminAbonelerModel
                {   
                    musteriler =  _musteriService.GetAll()
                };
            }
            else
            {
                abonelerModel = new AdminAbonelerModel
                {   
                    
                    tekMusteri = _musteriService.GetByAbone(aboneNo)
                       
                    
                };
            }

            if (abonelerModel.tekMusteri==null)
            {
                abonelerModel = new AdminAbonelerModel
                {   
                    musteriler =  _musteriService.GetAll()
                };
            }
           
            return View(abonelerModel);
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

        public IActionResult AboneBilgi(int musteriId)
        {
            if (musteriId!=0)
            {
                MusteriModel addModel = new MusteriModel()
                {
                    MusteriBilgiler = _musteriService.GetById(musteriId),
                    Aranacaklars = _aranacakService.GetAll(_musteriService.GetByAboneNo(musteriId)),
                    MusteriSinyaller = _SinyallerService.GetAboneSinyal(_musteriService.GetByAboneNo(musteriId))
                    
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
    }
}