#pragma checksum "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Order\CheckoutComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e21201ba89747e82437fd5c86c5a254d2ce200f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutComplete), @"mvc.1.0.view", @"/Views/Order/CheckoutComplete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/CheckoutComplete.cshtml", typeof(AspNetCore.Views_Order_CheckoutComplete))]
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
#line 1 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\_ViewImports.cshtml"
using Bakery.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\_ViewImports.cshtml"
using Bakery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21201ba89747e82437fd5c86c5a254d2ce200f2", @"/Views/Order/CheckoutComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce9a0bb7156fb1977de8680bb6195ba0d5a7e8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(5, 31, false);
#line 1 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Order\CheckoutComplete.cshtml"
Write(ViewBag.CheckoutCompleteMessage);

#line default
#line hidden
            EndContext();
            BeginContext(36, 6, true);
            WriteLiteral(" </h1>");
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
