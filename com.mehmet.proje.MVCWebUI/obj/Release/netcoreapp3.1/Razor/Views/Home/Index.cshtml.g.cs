#pragma checksum "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b435f5b918e3a3a0b57d538b48217b32fdf024f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 4 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b435f5b918e3a3a0b57d538b48217b32fdf024f6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bbc8dec0f5616cb7704077617a323a6bac9c77", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("mailto:info@maguvenlik.com"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ccs-ek/font-awesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Home/Index.cshtml"
  
    Layout="_Layout";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container text-center\">\n    <img src=\"image/banner1.png\" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 123, "\"", 129, 0);
            EndWriteAttribute();
            WriteLiteral(@">
</div>


<div class=""container"">
    <ul class=""nav nav-tabs justify-content-center nav-fill navbar-dark"" style=""background-color: #60E7DCD3;"">
        <li class=""nav-item"">
        
            <a class=""nav-link active"" href=""#anasayfa"" data-toggle=""tab"">Anasayfa</a>
        <li/>

        <li class=""nav-item dropdown"">
            <a class=""nav-link dropdown-toggle""");
            BeginWriteAttribute("href", " href=\"", 503, "\"", 510, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""dropdown"">Hizmetlerimiz</a>
            <div class=""dropdown-menu"">
                <a href=""#alarm"" class=""dropdown-item"" data-toggle=""tab"">Alarm Sistemleri</a>
                <a href=""#kamera"" class=""dropdown-item"" data-toggle=""tab"">Kamera Sistemleri</a>
                <a href=""#haberalma"" class=""dropdown-item"" data-toggle=""tab"">HaberAlma Merkezi</a>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""#hakkimizda"" data-toggle=""tab"">Hakkımızda</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""#iletisim"" data-toggle=""tab"">İletişim</a>
        </li>
      
        
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-success dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
           <span
                               class=""spinner-grow spinner-grow-sm text-light""></span>GİRİŞ
          </button>
          <div class=""dropdown-menu"">
            <a");
            WriteLiteral(@" class=""dropdown-item"" href=""/Login/YetkiliLogin"">Personel</a>
              <a class=""dropdown-item"" href=""/Login/Index"">Abone</a>
            
          </div>
        </div>
        
       </ul>


</div>
<!--  tab verilirini içeriği   -->
<br>
<div class=""container"">

<div class=""tab-content"">
<div class=""tab-pane active"" id=""anasayfa"">
    <div class=""text-center"">
        <img src=""image/haberalma11.png""/>
        <p class=""mt-2"">
            Alarm haber alma merkezi, güvenlik alarm sistemleri aracılığıyla algıladığı alarmı, daha önce 
            belirlediğiniz kişilere ve size bildirir. Alarm haber alma sistemleri, panik alarmı aktif 
            olduğunda polis merkezine çağrı yapar. Ayrıca, yangın alarmı aktif olduğunda, sistem, itfaiyeye 
            çağrı yapar. Sağlık alarmı durumunda da, sistem, sağlık birimlerine çağrı yapar. Alarm haber alma 
            merkezlerinin bu özelliği sayesinde, potansiyel tehlikelerden doğabilecek zararları minimum seviyeye 
            indirebiliriz. Tehlike anın");
            WriteLiteral(@"da anlık müdahale çok önemli olduğundan, alarm haber alma merkezlerinin 
            yükümlülüklerinden birisi de, alarm sistemlerinin düzenli olarak kontrolünün sağlanmasıdır. 
            Ayrıca, kullanıcı istediği zaman alarm haber alma merkezi ile iletişime geçerek, durum hakkında bilgi elde edebilir. 
            İsteğinize bağlı olarak günlük haftalık ve aylık raporlama alabilirsiniz. Panel ile iletişime geçerek, 
            yapabileceğiniz işlemleri pratik bir şekilde uygulayabilirsiniz. Alarm izleme merkezlerinin her zaman aktif olarak hizmet 
            vermesinden dolayı, evlerimizin ve iş yerlerimizin güvenliği 7/24 takip edilmektedir. Bundan dolayı tatile çıktığımızda
            veya kısa süreli seyahat ettiğimizde, güvenlik açısından endişelenmemize gerek kalmamaktadır.
        </p>
    </div>
   
</div>
<div class=""tab-pane"" id=""hakkimizda"">
    <br>
    <br>
    <p class=""lead text-center"">
        Teknoloji ve bilgiyi, hizmetlerine entegre ederek hızla büyüyen <strong>M.A Güvenlik</strong> ");
            WriteLiteral(@",
        Türkiye pazarında bilgi lideri misyonunu koruyor. Pazara, uluslararası kalite ve deneyimlerini,
        yerellikle birleştirerek öncülük ediyor.
    </p>
    <br>
    <p class=""text-center"">
        Firmamız, endüstriyel tesislerden perakende zincirlerine,
        turizmden enerjiye, alışveriş merkezlerinden havacılığıa kadar 26 farklı sektörden 1000'in
        üzerinde iş ortağına, 75 ilde, 2900 hizmet noktasında güvenlik hizmeti sunar. Securitas Türkiye’nin
        11
        bölge müdürlüğü, 70 şube müdürlüğü ve 20 bin çalışanı bulunmaktadır.
    </p>

</div>
<div class=""tab-pane"" id=""iletisim"">
    <section class=""mb-4"">
        
        <!--Section heading-->
        <h2 class=""h1-responsive font-weight-bold text-center my-4"">İletişim</h2>
        <!--Section description-->
        <p class=""text-center w-responsive mx-auto mb-5"">Her türlü sorununuzda bize iletebilirsiniz...</p>
        
        <div class=""row"">
        
            <!--Grid column-->
            <div class=""col-md-9 mb-md-0 m");
            WriteLiteral("b-5\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b435f5b918e3a3a0b57d538b48217b32fdf024f610799", async() => {
                WriteLiteral(@"
        
                    <!--Grid row-->
                    <div class=""row"">
        
                        <!--Grid column-->
                        <div class=""col-md-4"">
                            <div class=""md-form mb-0"">
                                <label for=""name""");
                BeginWriteAttribute("class", " class=\"", 4996, "\"", 5004, 0);
                EndWriteAttribute();
                WriteLiteral(@">Ad ve Soyadınız</label>
                                <input type=""text"" id=""name"" name=""name"" class=""form-control"">
                                    
                            </div>
                        </div>
                        <!--Grid column-->
        
                        <!--Grid column-->
                        <div class=""col-md-4"">
                            <div class=""md-form mb-0"">
                                <label for=""email""");
                BeginWriteAttribute("class", " class=\"", 5475, "\"", 5483, 0);
                EndWriteAttribute();
                WriteLiteral(@">Abone Numaranız</label>
                                <input type=""text"" id=""aboneNo"" name=""aboneNo"" class=""form-control"">
                                    
                            </div>
                        </div>
                        <!--Grid column-->
                            
                        <div class=""col-md-4"">
                            <div class=""md-form mb-0"">
                                <label for=""email""");
                BeginWriteAttribute("class", " class=\"", 5937, "\"", 5945, 0);
                EndWriteAttribute();
                WriteLiteral(@">E-mail Adresiniz</label>
                                <input type=""email"" id=""email"" name=""email"" class=""form-control"">
                                    
                            </div>
                        </div>
                            
        
                    </div>
                    <!--Grid row-->
        
                    <!--Grid row-->
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""md-form mb-0"">
                                <label for=""subject""");
                BeginWriteAttribute("class", " class=\"", 6512, "\"", 6520, 0);
                EndWriteAttribute();
                WriteLiteral(@">Konu</label>
                                <input type=""text"" id=""subject"" name=""subject"" class=""form-control"">
                                    
                            </div>
                        </div>
                    </div>
                    <!--Grid row-->
        
                    <!--Grid row-->
                    <div class=""row"">
        
                        <!--Grid column-->
                        <div class=""col-md-12"">
                            <div class=""md-form"">
                                <label for=""message"">Mesajınız</label>
                                <textarea type=""text"" id=""body"" name=""body"" rows=""2"" class=""form-control md-textarea""></textarea>
                            </div>
                        </div>
                    </div>
                    <!--Grid row-->
        
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"                   
                <div class=""text-center text-md-left"">
                    <a class=""btn btn-primary"" id=""butonn"" onclick=""document.getElementById('contact-form').submit();"">Gönder</a>
                </div>
                <div class=""status""></div>
            </div>
            <!--Grid column-->
            <div class=""col-md-3 text-center"">
                <ul class=""list-unstyled mb-0"">
                    <li>
                        <svg class=""bi bi-geo-alt"" width=""4em"" height=""4em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M8 16s6-5.686 6-10A6 6 0 0 0 2 6c0 4.314 6 10 6 10zm0-7a3 3 0 1 0 0-6 3 3 0 0 0 0 6z""/>
                        </svg>
                        <p>Emniyet Mah. No:12 Gazi Üniversitesi Yenimahalle ANKARA</p>
                    </li>
        
                    <li>
                        <svg class=""bi bi-emoji-smile"" width=""4em"" height=""4em"" viewBox=""0 0 16 16"" fill=""cu");
            WriteLiteral(@"rrentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z""/>
                            <path fill-rule=""evenodd"" d=""M4.285 9.567a.5.5 0 0 1 .683.183A3.498 3.498 0 0 0 8 11.5a3.498 3.498 0 0 0 3.032-1.75.5.5 0 1 1 .866.5A4.498 4.498 0 0 1 8 12.5a4.498 4.498 0 0 1-3.898-2.25.5.5 0 0 1 .183-.683z""/>
                            <path d=""M7 6.5C7 7.328 6.552 8 6 8s-1-.672-1-1.5S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 1.5-1 1.5s-1-.672-1-1.5S9.448 5 10 5s1 .672 1 1.5z""/>
                        </svg>
                        <p>0555 541 41 41</p>
                    </li>
        
                    <li>
                        <svg class=""bi bi-envelope-fill"" width=""4em"" height=""4em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M.05 3.555A2 2 0 0 1 2 2h12a2 2 0 0 1 1.95 1.555L8 8.414.05 3.555zM0 4.697v7.104l");
            WriteLiteral(@"5.803-3.558L0 4.697zM6.761 8.83l-6.57 4.027A2 2 0 0 0 2 14h12a2 2 0 0 0 1.808-1.144l-6.57-4.027L8 9.586l-1.239-.757zm3.436-.586L16 11.801V4.697l-5.803 3.546z""/>
                        </svg>
                        <p>info@maguvelik.com</p>
                    </li>
                </ul>
            </div>
            <!--Grid column-->
        </div>
    </section>
</div>
<!-- Hizmetler -->
<div class=""tab-pane"" id=""alarm"">
    <p class=""h3""> Alarm Sistemleri </p>
    <div class=""row"">
        <div class=""col-md-4"">
            <img src=""image/alarm-sistemleri-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10020, "\"", 10026, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100%"" height=""100%"">
        </div>
        <div class=""col-8"">
            <h3 class=""lead"">
                Alarm sistemleri soygunu önleyici özelliği ve soygunu erken ihbar edici özelliğe
                sahiptirler.Birincisi alarm sistemi
                kurulan yerde dış ortamında siren insanların göreceği bir noktaya takılırki bu durum
                hırsızın alarm sisteminin sirenini
                görmesini ve yapacak olduğu hırsızlıktan vazgeçmesine neden olabilir.Yada her şeye rağmen
                hırsızlık teşebbüsünde bulunulması
                durumunda sesli ikaz vererek içeridekileri ve çevredekileri sesli ve ışıklı olarak ikaz
                eder.Aynı zamanda hırsız alarm sistemlerinde
                bulunan telefon arama modülleri vasıtasıyla istenilen telefonlara ikaz yapılmasına olanak
                tanır.Birkaç adet telefon tespit edilip sistemin
                hafızasına kayıt yapılır ve hırsız alarm sistemi herhangi bir sensörden hırsız
                algılandığında sı");
            WriteLiteral(@"rasıyla sistemin hafızasına
                kayıtlı telefonlar sırasıyla aranır ve hırsız girdiği belirtilir.Buda insanlara anında
                müdahale etmeyi sağlar.
            </h3>
            <p>Alarm Sistemleri (Alarım Sistemi) Belli Parçalardan oluşmaktadır. Bu Parçalar Hırsız Alarm
                Panelleri
                ki bu sistemin beynidir. Bütün işlemler hırsız alarm panelleri üzerinden yapılır.Diğer
                güvenlik alarm sistemi parçaları ise
                PIR Dedektörler,Manyetik Kontaklar,Cam KIR(Cam Kırılma Dedektörleri),Harici Ortam
                Sirenleri,Dahili Ortam Sirenleri, Sistemin
                Kontrolünü sağlayan Keypad(Tuş Takımı) sistemin ana parçalarıdır.
                Bunlara ilave olarak telefon arama modülleri,gerektiğinde kablosuz olarak sistemi açıp
                kapamaya yarayan uzaktan kumanda modülleri bulunmaktadır.
            </p>
        </div>
    </div>
</div>
<div class=""tab-pane"" id=""kamera"">
    <p class=""h3""> Kameralı Güvenlik Sistemler");
            WriteLiteral("i </p>\n    <div class=\"row\">\n        <div class=\"col-md-4\">\n            <img src=\"image/kamera.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12174, "\"", 12180, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100%"" height=""100%"">
        </div>
        <div class=""col-8"">
            <p> Ev güvenlik kamera sistemi, ev içi güvenlik ve tedbiri sağlamak amaçlı kullanılan
                görüntüleme sistemidir.
                Bu sistem ile evde olunmayan zamanlarda izleme, görüntüleme ve kayıt
                işlemleri gerçekleştirilebilmektedir. Ev güvenlik sistemleri aracılığıyla bakıcıya
                bırakılmış çocuk, kritik
                bölgelerin izlenmesi, hasta takibi, olası hırsızlık durumlarına karşı güvenlik sağlama
                imkanları bulunabilmektedir.
            </p>
            <p> Uzaktan izleme yapılacak ev güvenlik kamerası sisteminde IP kamera ile yüksek ve kesintisiz
                görüntü iletimi için
                geniş bant internet bağlantısı gerekebilmektedir. İnternetin bağlantısının bulunduğu her
                yerde tarayıcı üzerinden
                bilgisayar, tablet ile ya da IOS, Android, Windows Phone gibi akıllı cihazlara yüklenecek
                mobil uygul");
            WriteLiteral(@"amalar aracılığıyla
                ev içi canlı ya da kayıtlı görüntüler izlenebilmektedir. Güvenlik kamerasının yetkisiz
                kişilerce uzaktan izlenmesine karşı
                kullanıcılara şifre verilmektedir. Bu şifre kişiye özel olup kolay tahmin edilebilir
                olmaması kamera güvenliğini arttırabilmektedir.
            </p>
            <p>Ev güvenlik kamera sisteminde programlanabilir bir özellik bulunması durumunda kamera
                istenilen saatlerde ya da harekete
                duyarlı olarak çalıştırılabilmektedir. Bunun yanında kamera sisteminin özelliklerine göre
                ses kaydı da yapılabilmektedir.
                Bunun için dahili mikrofon bulunan kameralar tercih edilmelidir.
            </p>
        </div>
    </div>
</div>
<div class=""tab-pane"" id=""haberalma"">
    <p class=""h3""> Alarm İzleme Sistemleri </p>
    <div class=""row"">
        <div class=""col-md-4"">
            <img src=""image/haberalma.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14180, "\"", 14186, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100%"" height=""100%"">
        </div>
        <div class=""col-8"">
            <h3 class=""lead"">
                Hırsızlık, gaz kaçağı, yangın, su baskını gibi acil ve
                tehlikeli durumlarda; Alarm İzleme Merkezi, alarm sistemleri ile eş zamanlı harekete geçer.
            </h3>
            <p>
                Ev veya işyerlerine kurulabilen alarm sistemleri, izinsiz giriş, hırsızlık, soygun, su
                baskınları,
                gaz kaçakları, yangın gibi acil durumları algılayıcıları aracılığıyla algılarlar.
                Ayrıca, bireyler, sisteme bağlı panik butonu ile tüm acil durumlarda Uzaktan İzleme
                Merkezi’ni harekete geçirebilirler. <br>

                Geleneksel alarm sistemlerine ek olarak, elektriğin olmadığı arazi koşullarında dahi
                çalışabilen Harici Alarm Sistemleri ile Uzaktan İzleme Merkezi bu alanların
                güvenliğinin sağlanmasına destek olabilmektedir.
            </p>
        </div>
    </div>
</div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b435f5b918e3a3a0b57d538b48217b32fdf024f624069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    $('#butonn').click(function() {
        alert(""sdsdsdsds"");
        var mesaj = document.getElementById(""name"").innerHTML;
        mesaj=mesaj+document.getElementById(""aboneNo"").innerHTML;
        var sonuc = document.getElementById(""body"").innerHTML;
        document.getElementById('body').innerHTML=mesaj+sonuc;
      
    });
    
    </script>
    
");
            }
            );
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
