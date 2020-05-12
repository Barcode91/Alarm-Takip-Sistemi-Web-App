using com.mehmet.proje.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public IActionResult Index()
        {
            var sinyaller = _sinyallerService.GetAll();
            return View(sinyaller);
        }
    }
}