using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.MVCWebUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IdentityUser = com.mehmet.proje.MVCWebUI.Identity.IdentityUser;

namespace com.mehmet.proje.MVCWebUI.Controllers
{
    public class LoginController : Controller
    {
        private IMusteriService _musteriService;
        private IPersonelService _personelService;
        

        public LoginController(IMusteriService musteriService, IPersonelService personelService)
        {
            _musteriService = musteriService;
            _personelService = personelService;
        }
        
        LoginModel model1 = new LoginModel
        {
            kullaniciTurler = new List<SelectListItem>
            {
                new SelectListItem(text:"Müşteri", value:"1"),
                new SelectListItem(text:"Operatör", value:"2"),
                new SelectListItem(text:"Yönetici", value:"3"),}
        };
        
        LoginModel model2 = new LoginModel();
    
        public ActionResult Index()
        {
          
            return View(model1);
        }
        /*
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.kullaniciTur=="1")
                {
                    var musteri = _musteriService.LoginCont(model.aboneNo, model.parola);
                    if (musteri!=null)
                    {    
                        return RedirectToAction("Index", "Musteri", musteri);
                    }
                }
                else if (model.kullaniciTur=="2")
                {
                    var personel = _personelService.LoginCont(model.aboneNo, model.parola);
                    if (personel!=null)
                    {
                        return RedirectToAction("Index", "Operator", personel);
                    }
                }
                else if (model.kullaniciTur=="3")
                {
                    var personel = _personelService.LoginCont(model.aboneNo, model.parola);
                    if (personel!=null)
                    {
                        return RedirectToAction("Index", "Admin", personel);
                    }
                }

                
            }
            
            
            if (!ModelState.IsValid) // Bilgiler Eksikse
            {
                return View(model1);
            }

            return View(model1);
        }
        */
        
        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.kullaniciTur=="1")
                {
                    var musteri = _musteriService.LoginCont(model.aboneNo, model.parola);
                    if (musteri!=null)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, model.aboneNo),
                            new Claim("gorevturu","müsteri")
                        };
 
                        var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
 
                        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                        await HttpContext.SignInAsync(principal);
                        
                        
                        return RedirectToAction("Index", "Musteri", musteri);
                    }
                }
                else if (model.kullaniciTur=="2")
                {
                    var personel = _personelService.LoginCont(model.aboneNo, model.parola);
                    if (personel!=null)
                    {   Console.WriteLine("operator kntrolde");
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, model.aboneNo),
                            new Claim("gorevturu","operatör")
                        };
 
                        var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        Console.WriteLine("operator"+userIdentity.Name);
                        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                        Console.WriteLine("operator"+principal.ToString());
                        HttpContext.SignInAsync(principal).Wait();
                        
                        
                        
                        return RedirectToAction("Index", "Operator", personel);
                    }
                }
                else if (model.kullaniciTur=="3")
                {
                    var personel = _personelService.LoginCont(model.aboneNo, model.parola);
                    if (personel!=null)
                    {
                        
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, model.aboneNo),
                            new Claim("gorevturu","yönetici")
                            
                        };
 
                        var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
 
                        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                        await HttpContext.SignInAsync(principal);
                        return RedirectToAction("Index", "Admin", personel);
                    }
                }

                
            }
            if (!ModelState.IsValid) // Bilgiler Eksikse
            {   ModelState.AddModelError("Sonuc","Giriş Bilgileriniz Hatalı...");
                return View(model1);
            }
            ModelState.AddModelError("Sonuc","Giriş Bilgileriniz Hatalı...");
            return View(model1);
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        
        
        public IActionResult AdminLogin()
        {
            return View(model1);
        }
        [HttpPost]
        public async Task<IActionResult> AdminLogin(LoginModel model)
        {
             if (ModelState.IsValid)
             {
                 var personel = _personelService.LoginCont(model.aboneNo, model.parola);
                 if (personel!=null)
                 {
                     var claims = new List<Claim>
                     {
                         new Claim(ClaimTypes.Name, model.aboneNo),
                         new Claim("gorevturu","yönetici")
                     };
                     var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                     ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                     await HttpContext.SignInAsync(principal);
                     return RedirectToAction("Index", "Admin", personel);
                 }
                
             }
             if (!ModelState.IsValid) // Bilgiler Eksikse
             {   ModelState.AddModelError("Sonuc","Giriş Bilgileriniz Hatalı...");
                 return View(model2);
             }
             ModelState.AddModelError("Sonuc","Giriş Bilgileriniz Hatalı...");
             return View(model2);
        }
        
        public IActionResult OperatorLogin()
        {
            return View(model1);
        }
        [HttpPost]
        public async Task<IActionResult> OperatorLogin(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var personel = _personelService.LoginCont(model.aboneNo, model.parola);
                if (personel!=null)
                {   Console.WriteLine("operator kntrolde");
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.aboneNo),
                        new Claim("gorevturu","operatör")
                    };
 
                    var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    Console.WriteLine("operator"+userIdentity.Name);
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    Console.WriteLine("operator"+principal.ToString());
                    HttpContext.SignInAsync(principal).Wait();
                        
                        
                    return RedirectToAction("Index", "Operator", personel.PersonelId);
                }
                
                
            }
            if (!ModelState.IsValid) // Bilgiler Eksikse
            {   ModelState.AddModelError("Sonuc","Giriş Bilgileriniz Hatalı...");
                return View(model2);
            }
            ModelState.AddModelError("Sonuc","Giriş Bilgileriniz Hatalı...");
            return View(model2);
        }
        

    }
}