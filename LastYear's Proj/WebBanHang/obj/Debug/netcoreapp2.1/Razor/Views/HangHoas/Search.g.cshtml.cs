#pragma checksum "C:\Users\LEGION\Source\Repos\HelpMe-Pls\.Net-Tech\LastYear's Proj\WebBanHang\Views\HangHoas\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5888d4cd65d46e26fc72154c75650955daccbb95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangHoas_Search), @"mvc.1.0.view", @"/Views/HangHoas/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HangHoas/Search.cshtml", typeof(AspNetCore.Views_HangHoas_Search))]
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
#line 1 "C:\Users\LEGION\Source\Repos\HelpMe-Pls\.Net-Tech\LastYear's Proj\WebBanHang\Views\_ViewImports.cshtml"
using WebBanHang;

#line default
#line hidden
#line 2 "C:\Users\LEGION\Source\Repos\HelpMe-Pls\.Net-Tech\LastYear's Proj\WebBanHang\Views\_ViewImports.cshtml"
using WebBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5888d4cd65d46e26fc72154c75650955daccbb95", @"/Views/HangHoas/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4596769894547467fa804c57f78ed1d3ff57c864", @"/Views/_ViewImports.cshtml")]
    public class Views_HangHoas_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TimKiem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\LEGION\Source\Repos\HelpMe-Pls\.Net-Tech\LastYear's Proj\WebBanHang\Views\HangHoas\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(48, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20bd5ee3f2bd4689a444c75083ffeace", async() => {
                BeginContext(98, 17, true);
                WriteLiteral("Tìm kiếm nâng cao");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(119, 133, true);
            WriteLiteral("</h3>\r\n<h2>Tìm kiếm hàng hóa</h2>\r\n\r\n\r\n\r\n<input type=\"text\" id=\"txtSearch\" placeholder=\"Input here..\" />\r\n<div id=\"result\"></div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(269, 423, true);
                WriteLiteral(@"
    <script>
        //gắn hàm xử lý cho sự kiện nhấn phím trên textbox
        $(""#txtSearch"").keyup(function () {
            $.ajax({
                url: ""/HangHoas/Search"",
                type: ""POST"",
                data: { ""Keyword"": $(this).val() },
                success: function (data) {
                    $(""#result"").html(data);
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(695, 1245, true);
            WriteLiteral(@"    <script>
        $(""#btnTim"").click(function () {
            var ten = $(""#txtTen"").val().trim();
            var giaTu = $(""#txtGiaTu"").val();
            var giaDen = $(""#txtGiaDen"").val();
            $.ajax({
                url: ""/HangHoas/JSONSearch"",
                type: ""GET"",
                data: {
                    ""Name"": ten, ""From"": giaTu, ""To"": giaDen
                },
                success: function (data) {
                    //console.log(data);
                    $(""#content"").html("""");
                    //duyệt qua từng phần tử của tập kết quả
                    $(data).each(function (index, value) {
                        //tạo thẻ tr
                        var tr = $(""<tr />"");
                        //tạo nội dung cho thẻ tr
                        $(""<td/>"").html(index + 1).appendTo(tr);
                        $(""<td/>"").html(value.TenHH).appendTo(tr);
                        $(""<td/>"").html(value.DonGia).appendTo(tr);
                        $");
            WriteLiteral("(\"<td/>\").html(value.Loai).appendTo(tr);\r\n                        //thêm vào tbody\r\n                        tr.appendTo(\"#content\");\r\n                    });\r\n                }\r\n            });\r\n        });\r\n    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
