#pragma checksum "D:\netcore\WebBanHang\Views\Admin\Taikhoan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b05f822589c1e01d42fe4f0b4a4131c1cacd8881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Taikhoan), @"mvc.1.0.view", @"/Views/Admin/Taikhoan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Taikhoan.cshtml", typeof(AspNetCore.Views_Admin_Taikhoan))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05f822589c1e01d42fe4f0b4a4131c1cacd8881", @"/Views/Admin/Taikhoan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4596769894547467fa804c57f78ed1d3ff57c864", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Taikhoan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBanHang.Models.TaiKhoan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\netcore\WebBanHang\Views\Admin\Taikhoan.cshtml"
  
    ViewData["Title"] = "Taikhoan";

#line default
#line hidden
            BeginContext(92, 215, true);
            WriteLiteral("\r\n<h2>Taikhoan</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n               ten\r\n            </th>\r\n            <th>mat khau</th>\r\n          \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "D:\netcore\WebBanHang\Views\Admin\Taikhoan.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(356, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(405, 46, false);
#line 23 "D:\netcore\WebBanHang\Views\Admin\Taikhoan.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenDangNhap));

#line default
#line hidden
            EndContext();
            BeginContext(451, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(507, 42, false);
#line 26 "D:\netcore\WebBanHang\Views\Admin\Taikhoan.cshtml"
           Write(Html.DisplayFor(modelItem => item.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(549, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "D:\netcore\WebBanHang\Views\Admin\Taikhoan.cshtml"
        }

#line default
#line hidden
            BeginContext(596, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBanHang.Models.TaiKhoan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
