#pragma checksum "D:\dotnet\asprazor01\Pages\FirstPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37bae73793fff00600680198cde9ebc03f7814f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_FirstPage), @"mvc.1.0.razor-page", @"/Pages/FirstPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/trang-dau-tien/{solanlap:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37bae73793fff00600680198cde9ebc03f7814f0", @"/Pages/FirstPage.cshtml")]
    public class Pages_FirstPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 3 "D:\dotnet\asprazor01\Pages\FirstPage.cshtml"
Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>hello</h1>\r\n");
#nullable restore
#line 5 "D:\dotnet\asprazor01\Pages\FirstPage.cshtml"
  
    var solanlapstring= this.Request.RouteValues["solanlap"]??"0";
    int solanlap =Int32.Parse(solanlapstring.ToString());
    for(int i=0;i< solanlap;i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Lần ");
#nullable restore
#line 10 "D:\dotnet\asprazor01\Pages\FirstPage.cshtml"
          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "D:\dotnet\asprazor01\Pages\FirstPage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstPageModel>)PageContext?.ViewData;
        public FirstPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
