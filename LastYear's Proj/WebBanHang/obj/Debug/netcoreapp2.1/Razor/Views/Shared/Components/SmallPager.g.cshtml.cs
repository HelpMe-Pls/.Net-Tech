#pragma checksum "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1debcf959743fe8af93133ff5507742226e6c05d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SmallPager), @"mvc.1.0.view", @"/Views/Shared/Components/SmallPager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SmallPager.cshtml", typeof(AspNetCore.Views_Shared_Components_SmallPager))]
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
#line 1 "D:\netcore\WebBanHang\Views\_ViewImports.cshtml"
using WebBanHang;

#line default
#line hidden
#line 2 "D:\netcore\WebBanHang\Views\_ViewImports.cshtml"
using WebBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1debcf959743fe8af93133ff5507742226e6c05d", @"/Views/Shared/Components/SmallPager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4596769894547467fa804c57f78ed1d3ff57c864", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SmallPager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.IPagingList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
  
    var start = this.Model.StartPageIndex;
    var stop = this.Model.StopPageIndex;

#line default
#line hidden
            BeginContext(172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
 if (this.Model.PageCount > 1) {

#line default
#line hidden
            BeginContext(208, 39, true);
            WriteLiteral("    <ul class=\"pagination\">\r\n        \r\n");
            EndContext();
#line 13 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
         if (start > 1) {

#line default
#line hidden
            BeginContext(274, 54, true);
            WriteLiteral("            <li class=\"page-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 328, "\"", 391, 1);
#line 15 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
WriteAttributeValue("", 335, Url.Action(Model.Action, Model.GetRouteValueForPage(1)), 335, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(392, 136, true);
            WriteLiteral(" aria-label=\"First\" class=\"page-link\">\r\n                    <span aria-hidden=\"true\">1</span>\r\n                </a>\r\n            </li>\r\n");
            EndContext();
#line 19 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
        }

#line default
#line hidden
            BeginContext(539, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
         if (this.Model.PageIndex > 1) {

#line default
#line hidden
            BeginContext(583, 54, true);
            WriteLiteral("            <li class=\"page-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 637, "\"", 723, 1);
#line 23 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
WriteAttributeValue("", 644, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex - 1)), 644, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(724, 145, true);
            WriteLiteral(" aria-label=\"Previous\" class=\"page-link\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
            EndContext();
#line 27 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
        }

#line default
#line hidden
            BeginContext(880, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
         for (int i = start; i <= stop; i++) {

#line default
#line hidden
            BeginContext(930, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 945, "\"", 1006, 2);
            WriteAttributeValue("", 953, "page-item", 953, 9, true);
#line 30 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
WriteAttributeValue(" ", 962, (Model.PageIndex == i) ? "active" : null, 963, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1007, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1027, 104, false);
#line 31 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
           Write(Html.ActionLink(i.ToString(), Model.Action, Model.GetRouteValueForPage(i), new { @class = "page-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 33 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
        }

#line default
#line hidden
            BeginContext(1163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
         if (this.Model.PageIndex < this.Model.PageCount) {

#line default
#line hidden
            BeginContext(1226, 54, true);
            WriteLiteral("            <li class=\"page-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1280, "\"", 1366, 1);
#line 37 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
WriteAttributeValue("", 1287, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex + 1)), 1287, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1367, 141, true);
            WriteLiteral(" aria-label=\"Next\" class=\"page-link\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
            EndContext();
#line 41 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
        }

#line default
#line hidden
            BeginContext(1519, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
         if (stop < this.Model.PageCount) {

#line default
#line hidden
            BeginContext(1566, 54, true);
            WriteLiteral("            <li class=\"page-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1620, "\"", 1702, 1);
#line 45 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
WriteAttributeValue("", 1627, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageCount)), 1627, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1703, 84, true);
            WriteLiteral(" aria-label=\"Last\" class=\"page-link\">\r\n                    <span aria-hidden=\"true\">");
            EndContext();
            BeginContext(1788, 20, false);
#line 46 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
                                        Write(this.Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1808, 50, true);
            WriteLiteral("</span>\r\n                </a>\r\n            </li>\r\n");
            EndContext();
#line 49 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
        }

#line default
#line hidden
            BeginContext(1869, 13, true);
            WriteLiteral("\r\n    </ul>\r\n");
            EndContext();
#line 52 "D:\netcore\WebBanHang\Views\Shared\Components\SmallPager.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.IPagingList> Html { get; private set; }
    }
}
#pragma warning restore 1591
