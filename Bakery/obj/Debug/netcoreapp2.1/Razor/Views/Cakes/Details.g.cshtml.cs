#pragma checksum "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5260fbf24cc7b94fbe2fd162ac8a9fd70b6d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cakes_Details), @"mvc.1.0.view", @"/Views/Cakes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cakes/Details.cshtml", typeof(AspNetCore.Views_Cakes_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5260fbf24cc7b94fbe2fd162ac8a9fd70b6d33", @"/Views/Cakes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce9a0bb7156fb1977de8680bb6195ba0d5a7e8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cakes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cakes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(14, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(21, 10, false);
#line 3 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(31, 42, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 73, "\"", 90, 1);
#line 6 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml"
WriteAttributeValue("", 79, Model.Name, 79, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 91, "\"", 112, 1);
#line 6 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml"
WriteAttributeValue("", 97, Model.ImageUrl, 97, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(113, 66, true);
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(180, 11, false);
#line 8 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(191, 45, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(237, 10, false);
#line 10 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(247, 33, true);
            WriteLiteral("</a>\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(281, 22, false);
#line 12 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(303, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(322, 21, false);
#line 13 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(343, 87, true);
            WriteLiteral("</p>\r\n        <div class=\"addToCart\">\r\n            <p class=\"button\">\r\n                ");
            EndContext();
            BeginContext(430, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "784fac7449ec455d80ccca99dfb631d9", async() => {
                BeginContext(611, 11, true);
                WriteLiteral("Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\quazi\source\repos\Bakery\Bakery\Views\Cakes\Details.cshtml"
                        WriteLiteral(Model.CakesId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(626, 56, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cakes> Html { get; private set; }
    }
}
#pragma warning restore 1591
