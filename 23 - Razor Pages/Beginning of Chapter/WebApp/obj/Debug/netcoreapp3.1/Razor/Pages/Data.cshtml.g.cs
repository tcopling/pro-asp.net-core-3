#pragma checksum "D:\git\pro-asp.net-core-3\23 - Razor Pages\Beginning of Chapter\WebApp\Pages\Data.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bbde64d751f21c1ad74399f12dd06a97e22bcd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_Data), @"mvc.1.0.razor-page", @"/Pages/Data.cshtml")]
namespace WebApp.Pages
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
#line 2 "D:\git\pro-asp.net-core-3\23 - Razor Pages\Beginning of Chapter\WebApp\Pages\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bbde64d751f21c1ad74399f12dd06a97e22bcd8", @"/Pages/Data.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e523526ccc9bde6e7e876719e7ae5d3b7a9f7d39", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Data : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h5 class=\"bg-primary text-white text-center m-2 p-2\">Categories</h5>\r\n<ul>\r\n");
#nullable restore
#line 6 "D:\git\pro-asp.net-core-3\23 - Razor Pages\Beginning of Chapter\WebApp\Pages\Data.cshtml"
     foreach (Category c in context.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">");
#nullable restore
#line 8 "D:\git\pro-asp.net-core-3\23 - Razor Pages\Beginning of Chapter\WebApp\Pages\Data.cshtml"
                               Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 9 "D:\git\pro-asp.net-core-3\23 - Razor Pages\Beginning of Chapter\WebApp\Pages\Data.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DataContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Data> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Data> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Data>)PageContext?.ViewData;
        public Pages_Data Model => ViewData.Model;
    }
}
#pragma warning restore 1591