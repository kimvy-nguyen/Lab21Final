#pragma checksum "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\StateManagement\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d06b070d81e5e9cb152fa742a43b3d25e986f3b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateManagement_Logout), @"mvc.1.0.view", @"/Views/StateManagement/Logout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StateManagement/Logout.cshtml", typeof(AspNetCore.Views_StateManagement_Logout))]
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
#line 1 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\_ViewImports.cshtml"
using FirstMVCApp;

#line default
#line hidden
#line 2 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\_ViewImports.cshtml"
using FirstMVCApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d06b070d81e5e9cb152fa742a43b3d25e986f3b2", @"/Views/StateManagement/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c484353cf842f8338eb6a82fb94138801ad636", @"/Views/_ViewImports.cshtml")]
    public class Views_StateManagement_Logout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\StateManagement\Logout.cshtml"
 if (TempData.Peek("name") != null) {

#line default
#line hidden
            BeginContext(38, 15, true);
            WriteLiteral("    <p>GoodBye ");
            EndContext();
            BeginContext(54, 16, false);
#line 2 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\StateManagement\Logout.cshtml"
          Write(TempData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(70, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 3 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\StateManagement\Logout.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
