using System.Linq;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList;


namespace com.mehmet.proje.MVCWebUI.Controllers
{
    //[Authorize]
    public class SinyallerController : Controller
    {
        private ISinyallerService _sinyallerService;

        public SinyallerController(ISinyallerService sinyallerService)
        {
            _sinyallerService = sinyallerService;
        }

        // GET
        public IActionResult Index(int? page)
        {    
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int pageSize = 2; // Get 25 students for each requested page.
            var sinyaller = _sinyallerService.GetAll().ToPagedList(pageNumber, pageSize);
            return View(sinyaller);

            //var sinyaller = _sinyallerService.GetAll();
            //return View(sinyaller);
        }
    }
}