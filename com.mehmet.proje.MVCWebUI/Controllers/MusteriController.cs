using System;
using System.Linq;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.MVCWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace com.mehmet.proje.MVCWebUI.Controllers
{      [Authorize(Policy = "UserClaimPositionPolicy3")]
    public class MusteriController : Controller
    {
        private IMusteriService _musteriService;
        private ISinyallerService _sinyallerService;
        private IAranacakService _aranacakService;
        private IIslenmisSinyallerService _islenmisSinyallerService;


        

        public MusteriController(IMusteriService musteriService, ISinyallerService sinyallerService, IAranacakService aranacakService, IIslenmisSinyallerService islenmisSinyallerService)
        {
            _musteriService = musteriService;
            _sinyallerService = sinyallerService;
            _aranacakService = aranacakService;
            _islenmisSinyallerService = islenmisSinyallerService;
        }

        public ActionResult Index(Musteri musteri,int page=1)
        {
            string aboneNo = musteri.AboneNo;
            //var musteri = _musteriService.GetByAbone(aboneNo);
            var sinyaller = _sinyallerService.GetAboneSinyal(aboneNo);
            var aranacak = _aranacakService.GetAll(aboneNo);
            var islenmisSinyaler = _islenmisSinyallerService.GetAboneSinyal(aboneNo);
            
            int sayfaBoyu = 10;

            MusteriModel model = new MusteriModel()
            {    Aranacaklars = aranacak,
                MusteriBilgiler = musteri,
                //bulunulan sayfa*sabit satır sayısı kadar atla
                MusteriSinyaller = sinyaller.Skip((page-1)*sayfaBoyu).Take(sayfaBoyu).ToList(),
                IslenmisSinyallers = islenmisSinyaler
            };


            return View(model);
        }
        [HttpPost]
        public ActionResult Index(MusteriModel model,int page=1)
        {
            
           Musteri musteri = _musteriService.GetById(model.MusteriBilgiler.MusteriId);
           musteri.Parola = model.MusteriBilgiler.Parola;
            var musteri1 = _musteriService.Update(musteri);
            
            string aboneNo = musteri1.AboneNo;
            var sinyaller = _sinyallerService.GetAboneSinyal(aboneNo);
            var aranacak = _aranacakService.GetAll(aboneNo);
            var islenmisSinyaler = _islenmisSinyallerService.GetAboneSinyal(aboneNo);
            int sayfaBoyu = 10;
            
            MusteriModel model1 = new MusteriModel()
            {    Aranacaklars = aranacak,
                MusteriBilgiler = musteri1,
                IslenmisSinyallers = islenmisSinyaler,
                //bulunulan sayfa*sabit satır sayısı kadar atla
                MusteriSinyaller = sinyaller.Skip((page-1)*sayfaBoyu).Take(sayfaBoyu).ToList()
            };

           
            
            return View(model1);
        }

      
    }

}