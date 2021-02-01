#pragma checksum "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab73468af726f460fc83802f199a4216608e721a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
#line 1 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab73468af726f460fc83802f199a4216608e721a", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe4547a8cacf5364b9360f7575f19b5b210142f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopSolution.ViewModels.Catalog.Common.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
  
    //pageIndex=?&keyword=?
    var urlTemplate = Url.Action() + "?page={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "page")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 32 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 980, "\"", 1019, 1);
#nullable restore
#line 35 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 987, urlTemplate.Replace("{0}", "1"), 987, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1121, "\"", 1187, 1);
#nullable restore
#line 38 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1128, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1128, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n            </li>\r\n");
#nullable restore
#line 40 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 46 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 48 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1626, "\"", 1653, 2);
            WriteAttributeValue("", 1634, "Trang", 1634, 5, true);
#nullable restore
#line 51 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1639, i.ToString(), 1640, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1654, "\"", 1702, 1);
#nullable restore
#line 51 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1661, urlTemplate.Replace("{0}", i.ToString()), 1661, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 52 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1872, "\"", 1907, 1);
#nullable restore
#line 57 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1880, Model.PageCount.ToString(), 1880, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1908, "\"", 1974, 1);
#nullable restore
#line 57 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1915, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1915, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2076, "\"", 2138, 1);
#nullable restore
#line 60 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2083, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2083, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n            </li>\r\n");
#nullable restore
#line 62 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 64 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopSolution.ViewModels.Catalog.Common.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
