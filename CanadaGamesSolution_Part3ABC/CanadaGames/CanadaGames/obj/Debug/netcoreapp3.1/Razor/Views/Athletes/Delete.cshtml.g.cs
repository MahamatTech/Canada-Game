#pragma checksum "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02e46b0ab99a714a590d8a6247dd31cb0492c77b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Athletes_Delete), @"mvc.1.0.view", @"/Views/Athletes/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02e46b0ab99a714a590d8a6247dd31cb0492c77b", @"/Views/Athletes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca7df126862f209c84e5945aadfc51472a2f68b", @"/Views/_ViewImports.cshtml")]
    public class Views_Athletes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CanadaGames.Models.Athlete>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete Athlete</h2>\r\n\r\n<h4>Are you sure you want to delete: ");
#nullable restore
#line 9 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
                                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h4>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 14 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 17 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 20 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 23 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 26 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 29 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 32 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AthleteCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 35 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ACode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 38 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 41 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 44 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 47 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 50 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 53 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 56 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsInSport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 59 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsInSport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 62 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Affiliation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 65 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Affiliation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 68 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Goals));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 71 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Goals));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 74 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MediaInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 77 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MediaInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 80 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contingent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 83 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contingent.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 86 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hometown));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 89 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hometown.HometownContingent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 92 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 95 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sport.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 98 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AthleteSports));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n");
#nullable restore
#line 101 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
              
                int theCount = Model.AthleteSports.Count;
                if (theCount > 0)
                {
                    string first = Model.AthleteSports.FirstOrDefault().Sport.Name;
                    if (theCount > 1)
                    {
                        string theList = first;
                        var c = Model.AthleteSports.ToList();
                        for (int i = 1; i < theCount; i++)
                        {
                            theList += ", " + c[i].Sport.Name;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a tabindex=\"0\"");
            BeginWriteAttribute("class", " class=\"", 3864, "\"", 3872, 0);
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-toggle=\"popover\"\r\n                           data-trigger=\"focus\" title=\"Alternate Sports\" data-placement=\"bottom\"\r\n                           data-content=\"");
#nullable restore
#line 116 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
                                    Write(theList);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            ");
#nullable restore
#line 117 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
                       Write(first);

#line default
#line hidden
#nullable disable
            WriteLiteral("... <span class=\"badge badge-info\">\r\n                                ");
#nullable restore
#line 118 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
                           Write(theCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </a>\r\n");
#nullable restore
#line 121 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
                   Write(first);

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
                              
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 130 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 133 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 136 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Coach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 139 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Coach.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02e46b0ab99a714a590d8a6247dd31cb0492c77b19521", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02e46b0ab99a714a590d8a6247dd31cb0492c77b19788", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 144 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a");
                BeginWriteAttribute("href", " href=\'", 5009, "\'", 5038, 1);
#nullable restore
#line 146 "C:\CanadaGamesSolution_Part3ABC\CanadaGamesSolution_Part3ABC\CanadaGames\CanadaGames\Views\Athletes\Delete.cshtml"
WriteAttributeValue("", 5016, ViewData["returnURL"], 5016, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Back to Athlete List</a>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\'[data-toggle=\"popover\"]\').popover();\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CanadaGames.Models.Athlete> Html { get; private set; }
    }
}
#pragma warning restore 1591
