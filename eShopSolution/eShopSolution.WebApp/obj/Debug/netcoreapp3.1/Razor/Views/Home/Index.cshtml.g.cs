#pragma checksum "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "260074d88be1d09b59f7eb87267cee75caac5124"
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
#nullable restore
#line 2 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
using eShopSolution.ViewModels.Catalog.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"260074d88be1d09b59f7eb87267cee75caac5124", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe4547a8cacf5364b9360f7575f19b5b210142f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper;
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("slider", async() => {
                WriteLiteral("\r\n    <div id=\"carouselBlk\">\r\n        <div id=\"myCarousel\" class=\"carousel slide\">\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 14 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                 for (int index = 0; index < Model.Slides.Count; index++)
                {
                    var slide = Model.Slides[index];

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("class", " class=\"", 558, "\"", 596, 2);
                WriteAttributeValue("", 566, "item", 566, 4, true);
#nullable restore
#line 17 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 570, index == 0?"active":"", 571, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"container\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 679, "\"", 696, 1);
#nullable restore
#line 19 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 686, slide.Url, 686, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img style=\"width:100%\"");
                BeginWriteAttribute("src", " src=\"", 721, "\"", 739, 1);
#nullable restore
#line 19 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 727, slide.Image, 727, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 740, "\"", 757, 1);
#nullable restore
#line 19 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 746, slide.Name, 746, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></a>\r\n                            <div class=\"carousel-caption\">\r\n                                <h4>");
#nullable restore
#line 21 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                               Write(slide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 22 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                              Write(slide.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 26 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <a class=\"left carousel-control\" href=\"#myCarousel\" data-slide=\"prev\">&lsaquo;</a>\r\n            <a class=\"right carousel-control\" href=\"#myCarousel\" data-slide=\"next\">&rsaquo;</a>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("<div class=\"well well-small\">\r\n    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260074d88be1d09b59f7eb87267cee75caac51248313", async() => {
                WriteLiteral("Featured Products");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <small class=\"pull-right\">200+ featured products</small></h4>\r\n    <div class=\"row-fluid\">\r\n        <div id=\"featured\" class=\"carousel slide\">\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 38 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                  
                    List<List<ProductVm>> featuredProducts = new List<List<ProductVm>>();
                    List<ProductVm> featuredPart = new List<ProductVm>();
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                 for (int index = 0; index < Model.FeaturedProducts.Count; index++)
                {
                    featuredPart.Add(Model.FeaturedProducts[index]);
                    if (featuredPart.Count == 4 || Model.FeaturedProducts.Count < 4)
                    {
                        featuredProducts.Add(featuredPart);
                        featuredPart = new List<ProductVm>();
                    }

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                 for (int index = 0; index < featuredProducts.Count; index++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 2343, "\"", 2381, 2);
            WriteAttributeValue("", 2351, "item", 2351, 4, true);
#nullable restore
#line 55 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2355, index == 0?"active":"", 2356, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 57 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                             foreach (var item in featuredProducts[index])
                            {
                                var url = $"/{culture}/{_loc["productUrl"]}/{item.Id}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"span3\">\r\n                                    <div class=\"thumbnail\">\r\n                                        <i class=\"tag\"></i>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2846, "\"", 2857, 1);
#nullable restore
#line 63 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2853, url, 2853, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2863, "\"", 2889, 1);
#nullable restore
#line 63 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2869, item.ThumbnailImage, 2869, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2890, "\"", 2906, 1);
#nullable restore
#line 63 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2896, item.Name, 2896, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        <div class=\"caption\">\r\n                                            <h5>");
#nullable restore
#line 65 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260074d88be1d09b59f7eb87267cee75caac512413435", async() => {
                WriteLiteral("VIEW");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize = true;
            __tagHelperExecutionContext.AddTagHelperAttribute("localize-content", __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <span class=\"pull-right\">");
#nullable restore
#line 66 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                                                                                                                     Write(item.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 70 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 73 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <a class=\"left carousel-control\" href=\"#featured\" data-slide=\"prev\">‹</a>\r\n            <a class=\"right carousel-control\" href=\"#featured\" data-slide=\"next\">›</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h4", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260074d88be1d09b59f7eb87267cee75caac512416210", async() => {
                WriteLiteral("Latest Products");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize = true;
            __tagHelperExecutionContext.AddTagHelperAttribute("localize-content", __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<ul class=\"thumbnails\">\r\n");
#nullable restore
#line 82 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
     foreach (var item in Model.LatestProducts)
    {
        var url = $"/{culture}/{_loc["productUrl"]}/{item.Id}";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"span3\">\r\n            <div class=\"thumbnail\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3943, "\"", 3954, 1);
#nullable restore
#line 87 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3950, url, 3950, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3960, "\"", 3986, 1);
#nullable restore
#line 87 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3966, item.ThumbnailImage, 3966, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3987, "\"", 4003, 1);
#nullable restore
#line 87 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3993, item.Name, 3993, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                <div class=\"caption\">\r\n                    <h5>");
#nullable restore
#line 89 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>\r\n                        ");
#nullable restore
#line 91 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n\r\n                    <h4 style=\"text-align:center\">\r\n                        <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 4279, "\"", 4290, 1);
#nullable restore
#line 95 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4286, url, 4286, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"icon-zoom-in\"></i>\r\n                        </a> <a class=\"btn\" href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260074d88be1d09b59f7eb87267cee75caac512420266", async() => {
                WriteLiteral("Add to");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <i class=\"icon-shopping-cart\"></i></a>\r\n                        <a class=\"btn btn-primary\" href=\"#\">");
#nullable restore
#line 98 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h4>\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 103 "D:\Dev\eShopSolution\eShopSolution\eShopSolution.WebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
