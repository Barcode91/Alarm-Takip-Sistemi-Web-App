using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Abone Numarası Giriniz")]
        public string aboneNo { get; set; }
        [Required(ErrorMessage = "Parola Bilgisini Giriniz")]
        public string parola{ get; set; }
        [Required(ErrorMessage = "Kullanıcı Türünü Seçiniz")]
        public string kullaniciTur{ get; set; }

        public List<SelectListItem> kullaniciTurler { get; set; }
    }
}