using System;
using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.oracle.entities.ComplexClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.MVCWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace com.mehmet.proje.MVCWebUI.Properties
{
    //[Authorize]
    public class OperatorController : Controller
    {
        IPersonelService _personelService;
        IMusteriService _musteriService;
        ISinyallerService _sinyallerService;
        IAranacakService _aranacakService;
        IIslenmisSinyallerService _islenmisSinyallerService;

        public OperatorController(IPersonelService personelService, IMusteriService musteriService, ISinyallerService sinyallerService, IAranacakService aranacakService, IIslenmisSinyallerService islenmisSinyallerService)
        {
            _personelService = personelService;
            _musteriService = musteriService;
            _sinyallerService = sinyallerService;
            _aranacakService = aranacakService;
            _islenmisSinyallerService = islenmisSinyallerService;
        }

        public IActionResult Index(Personel personel)
        {    //sinyaller tablosunda yer alan abone nolar getirilir.
            List<string> aboneler = _sinyallerService.GetSinyalAboneNo();
           
            List<TamMusteri> musteris = new List<TamMusteri>();
            // tüm sinyaller getirilir
            List<Sinyaller> listSin = _sinyallerService.GetAll();
            
            foreach (var abone in aboneler)
            {   TamMusteri tm = new TamMusteri();
                tm._musteri = _musteriService.GetByAbone(abone);
                tm._aranacaklars = _aranacakService.GetAll(abone);
                tm._sinyallers = _sinyallerService.GetAboneSinyal(abone);
                tm.IslenmisSinyallers = _islenmisSinyallerService.GetAboneSinyal(abone);
                musteris.Add(tm);
            }
            
            OperaTorModel operaTorModel = new OperaTorModel
            {
                personel = personel,
               TamMusteris = musteris,
               Sinyallers = listSin
            };
            
            return View(operaTorModel);
        }
        [HttpPost]
        public IActionResult SinyalIslem(int id, string operatorKimlik, int opId , string islem)
        {
            Personel personel = _personelService.GetById(opId);
            Sinyaller sinyal = _sinyallerService.getSinyalId(id);
            
            IslenmisSinyaller islenmisSinyal = new IslenmisSinyaller()
            {
                AboneNo = sinyal.AboneNo,
                Bolum = sinyal.Bolum,
                SinyalKod = sinyal.SinyalKod,
                Zone = sinyal.Zone,
                SinyalNitelik = sinyal.SinyalNitelik,
                SinyalSaat = sinyal.SinyalSaat,
                SinyalTarih = sinyal.SinyalTarih,
                SinyalTAnim = sinyal.SinyalTAnim
            };
           
            var tarih = DateTime.Now.ToString("dd/MM/yyyy");
            var saat = DateTime.Now.ToString("T");
            islenmisSinyal.IslemAcıklama = islem;
            islenmisSinyal.OperatorId = operatorKimlik;
            islenmisSinyal.IslemTarih = tarih;
            islenmisSinyal.IslemSaat = saat;
            _islenmisSinyallerService.Add(islenmisSinyal);
            _sinyallerService.Delete(sinyal);

            TempData["info"] = "Sinyal Başarıyla İşlendi";
            return RedirectToAction("Index", personel);
        }

      
        [HttpPost]
        public JsonResult MusteriDetay(string aboneNo)
        {
            MusteriAddModel model = new MusteriAddModel
            {
                musteri = _musteriService.GetByAbone(aboneNo),
                Aranacaklars = _aranacakService.GetAll(aboneNo)
            };
            
            return Json(model);
        } 

/*
        public IActionResult OperatorUpdate(Personel personel)
        {
            return View();
        } 
        */
    }
}