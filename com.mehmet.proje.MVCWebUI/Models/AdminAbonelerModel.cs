using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class AdminAbonelerModel
    {
        public List<Musteri> musteriler { get; set; }
        public Musteri tekMusteri { get; set; }
    }
}