#pragma checksum "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\Validation\ControllerSide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21608554694a5bffd7af4a56e60337012cc7b928"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Validation_ControllerSide), @"mvc.1.0.view", @"/Views/Validation/ControllerSide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Validation/ControllerSide.cshtml", typeof(AspNetCore.Views_Validation_ControllerSide))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21608554694a5bffd7af4a56e60337012cc7b928", @"/Views/Validation/ControllerSide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c484353cf842f8338eb6a82fb94138801ad636", @"/Views/_ViewImports.cshtml")]
    public class Views_Validation_ControllerSide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf0ace856624a758002bbf1dfd011f1", async() => {
                BeginContext(19, 263, true);
                WriteLiteral(@"
    <h2>Name</h2>
    <input type=""text"" name=""Name""/>

    <h2>Species</h2>
    <input type=""text"" name=""Species""/>

    <h2>Scales</h2>
    <input type=""text"" name=""Scales""/>

    <h2>IsFreshWater</h2>
    <input type=""checkbox"" />

    <input type=""submit""/>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(289, 28, true);
            WriteLiteral("\n\n\n<h2>Output</h2>\n<p>Name: ");
            EndContext();
            BeginContext(318, 12, false);
#line 19 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\Validation\ControllerSide.cshtml"
    Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(330, 16, true);
            WriteLiteral("</p>\n<p>Scales: ");
            EndContext();
            BeginContext(347, 14, false);
#line 20 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\Validation\ControllerSide.cshtml"
      Write(ViewBag.Scales);

#line default
#line hidden
            EndContext();
            BeginContext(361, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(370, 13, false);
#line 21 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\Validation\ControllerSide.cshtml"
Write(ViewBag.Water);

#line default
#line hidden
            EndContext();
            BeginContext(383, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(392, 14, false);
#line 22 "C:\Users\GC Student\FirstMVCApp\FirstMVCApp\Views\Validation\ControllerSide.cshtml"
Write(ViewBag.Salmon);

#line default
#line hidden
            EndContext();
            BeginContext(406, 4, true);
            WriteLiteral("</p>");
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
