#pragma checksum "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1ccdabbfde46403206d2a7e686a504cf51d059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grade_Index), @"mvc.1.0.view", @"/Views/Grade/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grade/Index.cshtml", typeof(AspNetCore.Views_Grade_Index))]
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
#line 1 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\_ViewImports.cshtml"
using CybProjWeb;

#line default
#line hidden
#line 2 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\_ViewImports.cshtml"
using CybProjWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1ccdabbfde46403206d2a7e686a504cf51d059", @"/Views/Grade/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd03a2c999631dd483775dc9b01fee0af1f6d649", @"/Views/_ViewImports.cshtml")]
    public class Views_Grade_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CybProjWeb.Entities.Grade>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Grade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-rounded btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-expanded", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete This record?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
  
    ViewData["Title"] = "Grade";

#line default
#line hidden
            BeginContext(84, 256, true);
            WriteLiteral(@"

<div class=""col-12"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Grades</h4>
        </div>
        <div class=""col-5 align-self-center"">
            <div class=""customize-input float-right"">
                ");
            EndContext();
            BeginContext(340, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ad0ad77395a4e2ca5c1a776f9a07ae2", async() => {
                BeginContext(419, 11, true);
                WriteLiteral("Setup Grade");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(434, 1005, true);
            WriteLiteral(@"
            </div>
        </div><br />
        <div class=""table-responsive"">
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Level</th>
                        <th scope=""col"">Step</th>
                        <th scope=""col"">Basic Salary(N)</th>
                        <th scope=""col"">Housing(N)</th>
                        <th scope=""col"">Medical(N)</th>
                        <th scope=""col"">Lunch(N)</th>
                        <th scope=""col"">Transport(N)</th>
                        <th scope=""col"">Gross Salary(N)</th>
                        <th scope=""col"">Tax(N)</th>
                        <th scope=""col"">Net Salary(N)</th>
                        <th scope=""col""></th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 38 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                     foreach (var g in Model)
                    {

#line default
#line hidden
            BeginContext(1507, 65, true);
            WriteLiteral("                    <tr>\n                        <td scope=\"row\">");
            EndContext();
            BeginContext(1573, 4, false);
#line 41 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                                   Write(g.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1577, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1612, 11, false);
#line 42 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.GradeName);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1658, 12, false);
#line 43 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.GradeLevel);

#line default
#line hidden
            EndContext();
            BeginContext(1670, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1705, 11, false);
#line 44 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.GradeStep);

#line default
#line hidden
            EndContext();
            BeginContext(1716, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1751, 13, false);
#line 45 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.BasicSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1764, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1799, 9, false);
#line 46 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.Housing);

#line default
#line hidden
            EndContext();
            BeginContext(1808, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1843, 9, false);
#line 47 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.Medical);

#line default
#line hidden
            EndContext();
            BeginContext(1852, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1887, 7, false);
#line 48 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.Lunch);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1929, 11, false);
#line 49 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.Transport);

#line default
#line hidden
            EndContext();
            BeginContext(1940, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1975, 13, false);
#line 50 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.GrossSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1988, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(2023, 5, false);
#line 51 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.Tax);

#line default
#line hidden
            EndContext();
            BeginContext(2028, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(2063, 11, false);
#line 52 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                       Write(g.NetSalary);

#line default
#line hidden
            EndContext();
            BeginContext(2074, 64, true);
            WriteLiteral("</td>\n\n                        <td>\n                            ");
            EndContext();
            BeginContext(2138, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff70fa29b8f347ae8901e843cb610645", async() => {
                BeginContext(2277, 153, true);
                WriteLiteral("\n                                <i class=\"fas fa-edit\"></i><span class=\"hide-menu\">\n                                </span>\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                                                                          WriteLiteral(g.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2434, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2522, 376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ba8035707547cab0e0cff34c6503dd", async() => {
                BeginContext(2736, 158, true);
                WriteLiteral("\n                                <i class=\"fas fa-trash-alt\"></i><span class=\"hide-menu\">\n                                </span>\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                                                                                                                                                     WriteLiteral(g.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2898, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 69 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\Grade\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2977, 80, true);
            WriteLiteral("\n                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CybProjWeb.Entities.Grade>> Html { get; private set; }
    }
}
#pragma warning restore 1591