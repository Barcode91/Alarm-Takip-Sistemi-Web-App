#pragma checksum "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00f49b0fe395bce5efd7d2087f4ce4dcdd281f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_IslenmisSinyal), @"mvc.1.0.view", @"/Views/Admin/IslenmisSinyal.cshtml")]
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
#nullable restore
#line 1 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
using com.mehmet.oracle.entities.BaseClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00f49b0fe395bce5efd7d2087f4ce4dcdd281f64", @"/Views/Admin/IslenmisSinyal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bbc8dec0f5616cb7704077617a323a6bac9c77", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_IslenmisSinyal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TumSinyaller>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
  
    /*
    "E400","E401", // normal açılış yeşil
    "E402", // erken açılış sarı
    "E403","E405" // mesai dışı giriş turuncu
    "E200", // tek gözden gelen alarm (krımızı)
    "E211", // sabotaj
    "E222", // birden çok gözden gelen alarm
    "E233", // sabotaj
    "E255" // ambulans
    "E100", // sistem arızası gri
    "E120", // elektrik arızası pembe
    "E140", // telefon aruzası // mavi
    */
    Layout = "_AdminLayout";
    var issinyal = Model._islenmisSinyal;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid text-center"">
    <h3 class=""bg-warning mt-2 mb-2"" >İşlem Yapılmış Sinyaller</h3>
    <div class=""table-responsive"">
        <table class=""table table-striped table-hover table-sm "">
            <thead class=""thead"">
            <td>Sid</td>
                       <td>Abone No</td>
                       <td>Sinyal Tarihi</td>
                       <td>Sinyal Saati</td>
                       <td>İşl.Saati</td>
                       <td>İşl.Tarihi</td>
                       <td>Sinyal Kodu</td>
                       <td>Bölge/Zone</td>
                       <td>Operatör</td>
                       <td>Sinyal Açıklama</td>
                       <td>İşlem</td>
            </thead>
            <tbody>
");
#nullable restore
#line 42 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
             foreach(var sinyal in issinyal)
            {
                if (sinyal.SinyalKod== "E200" ||
                    sinyal.SinyalKod=="E211"||
                    sinyal.SinyalKod=="E222"||
                    sinyal.SinyalKod=="E233"||
                    sinyal.SinyalKod=="E255")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-danger\" >\n                        <td>");
#nullable restore
#line 51 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 52 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 53 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 54 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 55 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.IslemSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 56 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.IslemTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 57 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 58 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 58 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                                            Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 59 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 60 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 61 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.IslemAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 63 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                }
                if (sinyal.SinyalKod== "E400" ||
                    sinyal.SinyalKod=="E401" ||
                    sinyal.SinyalKod=="E404")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-success\" >\n                         <td>");
#nullable restore
#line 69 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                        Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 70 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 71 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 72 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 73 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 74 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 75 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 76 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 76 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                                             Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 77 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 78 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 79 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        \n                    </tr>  \n");
#nullable restore
#line 82 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                }
                if (sinyal.SinyalKod== "E402" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-warning\" >\n                         <td>");
#nullable restore
#line 86 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                        Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 87 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 88 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 89 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 90 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 91 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 92 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 93 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 93 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                                             Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 94 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 95 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 96 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 98 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                }
                if (sinyal.SinyalKod== "E403" || sinyal.SinyalKod== "E405" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-primary\" >\n                         <td>");
#nullable restore
#line 102 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                        Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 103 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 104 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 105 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 106 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 107 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 108 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 109 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 109 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                                             Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 110 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 111 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 112 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 114 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                }
                if (sinyal.SinyalKod== "E140" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-secondary\" >\n                         <td>");
#nullable restore
#line 118 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                        Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 119 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 120 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 121 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 122 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 123 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 124 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 125 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 125 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                                             Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 126 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 127 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 128 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 130 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                }
                if (sinyal.SinyalKod== "E120" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-info\" >\n                        <td>");
#nullable restore
#line 134 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 135 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 136 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 137 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 138 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.IslemSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 139 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.IslemTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 140 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 141 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 141 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                                            Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 142 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 143 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                               <td>");
#nullable restore
#line 144 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                              Write(sinyal.IslemAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        \n                    </tr>  \n");
#nullable restore
#line 147 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                }
                if (sinyal.SinyalKod== "E100" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-dark\" >\n                         <td>");
#nullable restore
#line 151 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                        Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 152 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 153 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 154 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 155 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 156 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 157 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 158 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 158 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                                             Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 159 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 160 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 161 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                                               Write(sinyal.IslemAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        \n                    </tr>  \n");
#nullable restore
#line 164 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n     ");
#nullable restore
#line 169 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/IslenmisSinyal.cshtml"
Write(Html.PagedListPager((IPagedList)issinyal, page => Url.Action("IslenmisSinyal", new { page = page }),
                new PagedListRenderOptions
                {
                    DisplayItemSliceAndTotal = false,
                    ContainerDivClasses = new[] { "navigation" },
                    LiElementClasses = new[] { "page-item" },
                    PageClasses = new[] { "page-link" }
                }
                ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        \n</div>\n\n <script>\n            $(document).ready(function () {\n            $(\'ul.pagination> li.disabled > a\').addClass(\'page-link\');\n            $(\'ul.pagination\').addClass(\'justify-content-center\');\n            \n        });\n    </script>\n\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TumSinyaller> Html { get; private set; }
    }
}
#pragma warning restore 1591
