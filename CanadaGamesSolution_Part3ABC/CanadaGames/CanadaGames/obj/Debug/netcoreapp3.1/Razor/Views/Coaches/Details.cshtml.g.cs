#pragma checksum "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41dbe76318b80ba598491ea2c63abb7e8fe1563b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coaches_Details), @"mvc.1.0.view", @"/Views/Coaches/Details.cshtml")]
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
#line 1 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\_ViewImports.cshtml"
using CanadaGames;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\_ViewImports.cshtml"
using CanadaGames.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41dbe76318b80ba598491ea2c63abb7e8fe1563b", @"/Views/Coaches/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca7df126862f209c84e5945aadfc51472a2f68b", @"/Views/_ViewImports.cshtml")]
    public class Views_Coaches_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CanadaGames.Models.Coach>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
  
    ViewData["Title"] = "Coach Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Coach: ");
#nullable restore
#line 7 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
      Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Athletes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <table class=\"table table-striped\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 38 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                       Write(Html.DisplayNameFor(modelItem => Model.Athletes.FirstOrDefault().FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 41 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                       Write(Html.DisplayNameFor(modelItem => Model.Athletes.FirstOrDefault().Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 44 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                       Write(Html.DisplayNameFor(modelItem => Model.Athletes.FirstOrDefault().Sport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 49 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                     foreach (var item in Model.Athletes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Sport.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 62 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41dbe76318b80ba598491ea2c63abb7e8fe1563b10061", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    <a");
            BeginWriteAttribute("href", " href=\'", 2355, "\'", 2384, 1);
#nullable restore
#line 70 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Coaches\Details.cshtml"
WriteAttributeValue("", 2362, ViewData["returnURL"], 2362, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back to Coach List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CanadaGames.Models.Coach> Html { get; private set; }
    }
}
#pragma warning restore 1591
