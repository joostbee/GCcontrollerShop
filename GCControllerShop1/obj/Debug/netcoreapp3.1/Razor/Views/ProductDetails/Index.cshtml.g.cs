#pragma checksum "E:\ict\Schoolwerk\Jaar 1 semester 2 4.0o\GCcontrollerShop\GCcontrollerShop\GCControllerShop1\Views\ProductDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1532260568c11dfba4d1ee63738e2fba22748cbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetails_Index), @"mvc.1.0.view", @"/Views/ProductDetails/Index.cshtml")]
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
#line 1 "E:\ict\Schoolwerk\Jaar 1 semester 2 4.0o\GCcontrollerShop\GCcontrollerShop\GCControllerShop1\Views\_ViewImports.cshtml"
using GCControllerShop1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ict\Schoolwerk\Jaar 1 semester 2 4.0o\GCcontrollerShop\GCcontrollerShop\GCControllerShop1\Views\_ViewImports.cshtml"
using GCControllerShop1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1532260568c11dfba4d1ee63738e2fba22748cbb", @"/Views/ProductDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393f02319777ad00b8c816b2784625807f08d302", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.ViewModels.ProductView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ict\Schoolwerk\Jaar 1 semester 2 4.0o\GCcontrollerShop\GCcontrollerShop\GCControllerShop1\Views\ProductDetails\Index.cshtml"
  
    ViewData["Title"] = "ProductDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ProductDetails</h1>\r\n\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-lg-9\">\r\n\r\n            <div class=\"card mt-4\">\r\n                <img class=\"card-img-top img-fluid\" src=\"http://placehold.it/900x400\"");
            BeginWriteAttribute("alt", " alt=\"", 324, "\"", 330, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"card-title\">");
#nullable restore
#line 17 "E:\ict\Schoolwerk\Jaar 1 semester 2 4.0o\GCcontrollerShop\GCcontrollerShop\GCControllerShop1\Views\ProductDetails\Index.cshtml"
                                      Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h4>");
#nullable restore
#line 18 "E:\ict\Schoolwerk\Jaar 1 semester 2 4.0o\GCcontrollerShop\GCcontrollerShop\GCControllerShop1\Views\ProductDetails\Index.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 19 "E:\ict\Schoolwerk\Jaar 1 semester 2 4.0o\GCcontrollerShop\GCcontrollerShop\GCControllerShop1\Views\ProductDetails\Index.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.ViewModels.ProductView> Html { get; private set; }
    }
}
#pragma warning restore 1591
