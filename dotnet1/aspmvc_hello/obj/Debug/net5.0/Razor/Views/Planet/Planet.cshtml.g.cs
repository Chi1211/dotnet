#pragma checksum "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c857b932a4d0616fba442d095b561eceb95956"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planet_Planet), @"mvc.1.0.view", @"/Views/Planet/Planet.cshtml")]
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
#line 1 "D:\dotnet\aspmvc_hello\Views\_ViewImports.cshtml"
using aspmvc_hello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
using aspmvc_hello.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
using aspmvc_hello.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c857b932a4d0616fba442d095b561eceb95956", @"/Views/Planet/Planet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e999af8d2b9182cbcb88cf7084213c7eeb4cefab", @"/Views/_ViewImports.cshtml")]
    public class Views_Planet_Planet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
  
    string url(int _id){
        return Url.RouteUrl("detail", new{ id=_id});
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> Danh sách các hành tinh trong hệ mặt trời</h1>\r\n\r\n<div>\r\n    <ul>\r\n\r\n");
#nullable restore
#line 15 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
         foreach (var planet in planetService.planet)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <li>\r\n                 <div>\r\n                   <img");
            BeginWriteAttribute("src", " src=\"", 421, "\"", 443, 1);
#nullable restore
#line 19 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
WriteAttributeValue("", 427, planet.urlImage, 427, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                 </div>\r\n                 <div>\r\n                     <a");
            BeginWriteAttribute("href", " href=\"", 519, "\"", 542, 1);
#nullable restore
#line 22 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
WriteAttributeValue("", 526, url(@planet.id), 526, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 22 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
                                            Write(planet.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" --- ");
#nullable restore
#line 22 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
                                                             Write(planet.vnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    \r\n                 </div>\r\n            </li>\r\n");
#nullable restore
#line 26 "D:\dotnet\aspmvc_hello\Views\Planet\Planet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n\r\n        </li>\r\n    </ul>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public PlanetService planetService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
