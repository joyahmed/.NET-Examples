#pragma checksum "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24be0465e535cddcf08cf91a1392e4b52a6ecd2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\_ViewImports.cshtml"
using Core2._2Identity;

#line default
#line hidden
#line 2 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\_ViewImports.cshtml"
using Core2._2Identity.Models;

#line default
#line hidden
#line 3 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\_ViewImports.cshtml"
using Core2._2Identity.ViewModels;

#line default
#line hidden
#line 4 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24be0465e535cddcf08cf91a1392e4b52a6ecd2e", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163fc3abd315f6e153c64e66844b0254f73dea0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\Shared\Error.cshtml"
 if (ViewBag.ErrorTitle == null)
{

#line default
#line hidden
            BeginContext(37, 193, true);
            WriteLiteral("    <h3>\r\n        An error occured while processing your request.\r\n        The support team is notified and we are working on the fix\r\n    </h3>\r\n    <h5>Please contact us on ana@joy.com</h5>\r\n");
            EndContext();
#line 8 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\Shared\Error.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(242, 28, true);
            WriteLiteral("    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(271, 18, false);
#line 11 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorTitle);

#line default
#line hidden
            EndContext();
            BeginContext(289, 35, true);
            WriteLiteral("</h1>\r\n    <h6 class=\"text-danger\">");
            EndContext();
            BeginContext(325, 20, false);
#line 12 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(345, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 13 "D:\Projects\ASP.NET Projects\Examples\Core2.2Identity\Core2.2Identity\Views\Shared\Error.cshtml"
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
