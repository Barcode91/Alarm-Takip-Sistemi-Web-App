#pragma checksum "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bdc248c06f3d21699d1d6c8675cfb20756a9b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AboneBilgi), @"mvc.1.0.view", @"/Views/Admin/AboneBilgi.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/_ViewImports.cshtml"
using com.mehmet.proje.MVCWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/_ViewImports.cshtml"
using com.mehmet.proje.MVCWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bdc248c06f3d21699d1d6c8675cfb20756a9b7a", @"/Views/Admin/AboneBilgi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0039429b96211ce8aa66cd6a5ecb6253b58227b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AboneBilgi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusteriModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
  var sayac=1;
  var kimlik = Model.MusteriBilgiler;
  var sinyaller = Model.MusteriSinyaller;
  var aranacak = Model.Aranacaklars;
    
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <!-- Button trigger modal -->
  <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalLong"">
    Abone Ayrıntıları için Tıklayınız
  </button>

  <!-- Modal -->
<div class=""modal fade bd-example-modal-xl"" id=""exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle""
     aria-hidden=""true"">
  <div class=""modal-dialog modal-xl"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Ayrıntılı Abone Bilgileri</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""container-fluid"">
            
             
          <div class=""container"">
            <h2 class=""text-danger""> Abonelik Bilgileri </h2>
            <br>

            <h3 class=""text-center""> Kimlik Bilgileri </h3>
            <div c");
            WriteLiteral("lass=\"b form-row\">\n              <div class=\"form-group col-md-2\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 1302, "\"", 1308, 0);
            EndWriteAttribute();
            WriteLiteral(">Abone No:</label>\n                <p class=\"form-control\">");
#nullable restore
#line 39 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-4\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 1480, "\"", 1486, 0);
            EndWriteAttribute();
            WriteLiteral(">Tc. Kimlik No:</label>\n                <p class=\"form-control\">");
#nullable restore
#line 44 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.MusteriTcNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-4\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 1667, "\"", 1673, 0);
            EndWriteAttribute();
            WriteLiteral(">Ad Soyad:</label>\n                <p class=\"form-control\">");
#nullable restore
#line 49 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.Kimlik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n            </div>\n            <br>\n            <h3 class=\"text-center\"> Adres Bilgileri </h3>\n            <div class=\"b form-row\">\n              <div class=\"form-group col-md-8\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 1976, "\"", 1982, 0);
            EndWriteAttribute();
            WriteLiteral(">Adres</label>\n                <p class=\"form-control\">");
#nullable restore
#line 58 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-2\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 2148, "\"", 2154, 0);
            EndWriteAttribute();
            WriteLiteral(">İlçe</label>\n                <p class=\"form-control\">");
#nullable restore
#line 63 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.AdresIlce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-2\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 2323, "\"", 2329, 0);
            EndWriteAttribute();
            WriteLiteral(">İl</label>\n                <p class=\"form-control\">");
#nullable restore
#line 68 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.AdresIl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n            </div>\n            <br>\n            <h3 class=\"text-center\"> İletişim ve Abonelik Bilgileri </h3>\n            <div class=\"b form-row\">\n              <div class=\"form-group col-md-2\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 2641, "\"", 2647, 0);
            EndWriteAttribute();
            WriteLiteral(">Sabit Numara</label>\n                <p class=\"form-control\">");
#nullable restore
#line 77 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.EvTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-2\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 2820, "\"", 2826, 0);
            EndWriteAttribute();
            WriteLiteral(">Cep Telefonu-1</label>\n                <p class=\"form-control\">");
#nullable restore
#line 82 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.CepTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-2\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 3002, "\"", 3008, 0);
            EndWriteAttribute();
            WriteLiteral(">Cep Telefonu-2</label>\n                <p class=\"form-control\">");
#nullable restore
#line 87 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.CepTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-3\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 3184, "\"", 3190, 0);
            EndWriteAttribute();
            WriteLiteral(">Abonelik Bağlangıç Tarihi</label>\n                <p class=\"form-control\">");
#nullable restore
#line 92 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.AboneBasTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-3\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 3385, "\"", 3391, 0);
            EndWriteAttribute();
            WriteLiteral(">Abonelik Bitiş Tarihi</label>\n                <p class=\"form-control\">");
#nullable restore
#line 97 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.AboneBitTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

              </div>
            </div>
            <br>
            <h3 class=""text-center"">Aranacak Kişiler</h3>
            <div class="" b table-responsive "">
              <table class=""table table-striped table-hover say"">
                <thead>
                <tr>

                  <td>#</td>
                  <td>Adı Soyadı</td>
                  <td>Cep Telefonu 1</td>
                  <td>Cep Telefonu 2</td>
                </tr>

                </thead>
                <tbody>

");
#nullable restore
#line 117 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                 foreach (var arkisi in aranacak)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\n                    <td>");
#nullable restore
#line 120 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                   Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 121 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                   Write(arkisi.kimlik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 122 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                   Write(arkisi.ceptel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 123 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                   Write(arkisi.ceptel2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                  </tr>\n");
#nullable restore
#line 125 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"

                  sayac++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
              </table>
            </div>

            <br>
            <h3 class=""text-center""> Alarm Cihazı Bilgileri </h3>
            <div class=""b form-row"">

              <div class=""form-group col-md-2"">
                <label");
            BeginWriteAttribute("for", " for=\"", 4578, "\"", 4584, 0);
            EndWriteAttribute();
            WriteLiteral(">Cihaz Marka</label>\n                <p class=\"form-control\">");
#nullable restore
#line 138 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.ChMarka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              </div>\n              <div class=\"form-group col-md-2\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 4758, "\"", 4764, 0);
            EndWriteAttribute();
            WriteLiteral(">Cihaz Model</label>\n                <p class=\"form-control\">");
#nullable restore
#line 143 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.ChModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n              </div>\n              <div class=\"form-group col-md-2\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 4937, "\"", 4943, 0);
            EndWriteAttribute();
            WriteLiteral(">İletişim Türü</label>\n                <p class=\"form-control\">");
#nullable restore
#line 147 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.HaberlesmeTuru);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n              </div>\n              <div class=\"form-group col-md-3\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 5125, "\"", 5131, 0);
            EndWriteAttribute();
            WriteLiteral(">İletişim Numarası</label>\n                <p class=\"form-control\">");
#nullable restore
#line 151 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.EvTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n              </div>\n              <div class=\"form-group col-md-3\">\n                <label");
            BeginWriteAttribute("for", " for=\"", 5308, "\"", 5314, 0);
            EndWriteAttribute();
            WriteLiteral(">Garanti Süresi</label>\n                <p class=\"form-control\">");
#nullable restore
#line 155 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
                                   Write(kimlik.ChGarantiSuresi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
              </div>
            </div>


          </div>

          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>

<div class=""container"" id=""sinyaller"">
  <table class=""table table-striped table-hover table-sm"">
    <thead class=""thead"">
    <td>Sinyal Tarihi</td>
    <td>Sinyal Saati</td>
    <td>Sinyal Kodu</td>
    <td>Bölge No</td>
    <td>Zone</td>
    <td>Sinyal Açıklama</td>
    </thead>
    <tbody>
");
#nullable restore
#line 182 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
     foreach (var sinyal in sinyaller)
    {
      if (sinyal.SinyalKod == "E400")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"bg-danger\">\n          <td>");
#nullable restore
#line 187 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 188 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 189 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 190 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 191 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>ger erertertre ertertertertert asdsadasdasdasdasd</td>\n        </tr>\n");
#nullable restore
#line 194 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"bg-light\">\n          <td>");
#nullable restore
#line 198 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 199 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 200 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 201 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 202 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
         Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>ger erertertre ertertertertert asdsadasdasdasdasd</td>\n        </tr>\n");
#nullable restore
#line 205 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/AboneBilgi.cshtml"
      }
            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n  </table>\n</div>\n\n                        \n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusteriModel> Html { get; private set; }
    }
}
#pragma warning restore 1591