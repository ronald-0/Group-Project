#pragma checksum "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20f20e2d959b95939ed6d9618ac34023fdb7352c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_PersonalSalary), @"mvc.1.0.view", @"/Views/User/PersonalSalary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/PersonalSalary.cshtml", typeof(AspNetCore.Views_User_PersonalSalary))]
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
#line 2 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
using CybProjWeb.Entities;

#line default
#line hidden
#line 5 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20f20e2d959b95939ed6d9618ac34023fdb7352c", @"/Views/User/PersonalSalary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd03a2c999631dd483775dc9b01fee0af1f6d649", @"/Views/_ViewImports.cshtml")]
    public class Views_User_PersonalSalary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CybProjWeb.Entities.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
  
    ViewData["Title"] = "Personal Salary";

#line default
#line hidden
#line 9 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
  
    var loggedInUserName = @UserManager.GetUserName(User);
    var loggedInEmail = await UserManager.GetEmailAsync(
                        UserManager.Users.FirstOrDefault(u => u.UserName == loggedInUserName));

#line default
#line hidden
#line 14 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
 foreach (var s in Model)
{

    

#line default
#line hidden
#line 17 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
     if (s.Account.Email == loggedInEmail)
    {

#line default
#line hidden
            BeginContext(538, 1866, true);
            WriteLiteral(@"        <div class=""container-fluid"">
            <div class=""row"">

                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">

                            <div class=""d-flex align-items-center mb-4"">
                                <h4 class=""card-title"">Employee Details</h4>
                            </div>

                            <div class=""table-responsive"">
                                <table class=""table no-wrap v-middle mb-0"">
                                    <thead>
                                        <tr class=""border-0"">
                                            <th class=""border-0 font-14 font-weight-medium text-muted"">
                                                Name
                                            </th>
                                            <th class=""border-0 font-14 font-weight-medium text-muted px-2"">
                                                Grade
                                 ");
            WriteLiteral(@"           </th>
                                            <th class=""border-0 font-14 font-weight-medium text-muted"">
                                                Level
                                            </th>
                                            <th class=""border-0 font-14 font-weight-medium text-muted px-2"">
                                                Step
                                            </th>

                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <td class=""border-top-0 px-2 py-4"">
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2404, "\"", 2428, 1);
#line 54 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 2412, s.Account.Email, 2412, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2429, 477, true);
            WriteLiteral(@" class=""form-control"" id=""name"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2906, "\"", 2926, 1);
#line 60 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 2914, s.GradeName, 2914, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2927, 459, true);
            WriteLiteral(@" class=""form-control"" id=""grade"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td class=""border-top-0 px-2 py-4"">
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3386, "\"", 3407, 1);
#line 66 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 3394, s.GradeLevel, 3394, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3408, 477, true);
            WriteLiteral(@" class=""form-control"" id=""name"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3885, "\"", 3905, 1);
#line 72 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 3893, s.GradeStep, 3893, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3906, 2107, true);
            WriteLiteral(@" class=""form-control"" id=""grade"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>

                                        </tr>



                                    </tbody>
                                </table>
                            </div>

                            <!--SALARY BREAKDOWN-->


                            <div class=""d-flex align-items-center mb-4"">
                                <h4 class=""card-title"">Salary Breakdown</h4>
                            </div>

                            <div class=""table-responsive"">
                                <table class=""table no-wrap v-middle mb-0"">
                                    <thead>
                                        <tr class=""border-0"">
                                            <th class=""border-0 font-14 font-weight-medium text-muted"">
                               ");
            WriteLiteral(@"                 PayItem
                                            </th>
                                            <th class=""border-0 font-14 font-weight-medium text-muted px-2"">
                                                Percentage(N)
                                            </th>

                                            <th class=""border-0 font-14 font-weight-medium text-muted text-center"">
                                                PayItem Type
                                            </th>

                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <td>
                                                <label for=""Housing"">Housing</label>
                                            </td>

                                            <td>
                                                <div class=""form-group"">
           ");
            WriteLiteral("                                         <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6013, "\"", 6031, 1);
#line 118 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 6021, s.Housing, 6021, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6032, 418, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td>

                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6450, "\"", 6476, 1);
#line 125 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 6458, s.HousingItemType, 6458, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6477, 641, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>

                                        </tr>

                                        <tr>
                                            <td>
                                                <label for=""Lunch"">Lunch</label>

                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7118, "\"", 7134, 1);
#line 138 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 7126, s.Lunch, 7126, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7135, 418, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td>

                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7553, "\"", 7577, 1);
#line 145 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 7561, s.LunchItemType, 7561, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7578, 697, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td>
                                                <label for=""Transport"">Transport</label>
                                            </td>
                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8275, "\"", 8295, 1);
#line 157 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 8283, s.Transport, 8283, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8296, 418, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>

                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8714, "\"", 8742, 1);
#line 164 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 8722, s.TransportItemType, 8722, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8743, 694, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td>
                                                <label for=""Medical"">Medical</label>
                                            </td>

                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9437, "\"", 9455, 1);
#line 177 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 9445, s.Medical, 9445, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9456, 418, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td>

                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9874, "\"", 9900, 1);
#line 184 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 9882, s.MedicalItemType, 9882, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9901, 566, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Tax </td>
                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 10467, "\"", 10483, 2);
            WriteAttributeValue("", 10475, "N", 10475, 1, true);
#line 193 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue(" ", 10476, s.Tax, 10477, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10484, 1304, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>


                        </div>
                    </div>
                </div>

                <!--Total Salary-->

                <div class=""d-flex align-items-center mb-4"">
                    <h3 class=""card-title"">Total Salary</h3>
                </div>
                <div class=""table-responsive"">
                    <table class=""table no-wrap v-middle mb-0"">

                        <tbody>
                            <tr>
                                <td class=""border-top-0 px-2 py-4"">
                                    <h4>Basic Salary:</h4>
                                </td>
                        ");
            WriteLiteral(@"        <td class=""border-top-0 px-2 py-4"">
                                    --------------------------------
                                </td>
                                <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                    <h4>N ");
            EndContext();
            BeginContext(11789, 13, false);
#line 224 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
                                     Write(s.BasicSalary);

#line default
#line hidden
            EndContext();
            BeginContext(11802, 581, true);
            WriteLiteral(@"</h4>
                                </td>

                            </tr>
                            <tr>
                                <td class=""border-top-0 px-2 py-4"">
                                    <h4>Gross Salary:</h4>
                                </td>
                                <td class=""border-top-0 px-2 py-4"">
                                    --------------------------------
                                </td>
                                <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                    <h4>N ");
            EndContext();
            BeginContext(12384, 13, false);
#line 236 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
                                     Write(s.GrossSalary);

#line default
#line hidden
            EndContext();
            BeginContext(12397, 579, true);
            WriteLiteral(@"</h4>
                                </td>

                            </tr>
                            <tr>
                                <td class=""border-top-0 px-2 py-4"">
                                    <h4>Net Salary:</h4>
                                </td>
                                <td class=""border-top-0 px-2 py-4"">
                                    --------------------------------
                                </td>
                                <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                    <h4>N ");
            EndContext();
            BeginContext(12977, 11, false);
#line 248 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
                                     Write(s.NetSalary);

#line default
#line hidden
            EndContext();
            BeginContext(12988, 199, true);
            WriteLiteral("</h4>\n                                </td>\n\n                            </tr>\n                        </tbody>\n                    </table>\n                </div>\n\n            </div>\n        </div>\n");
            EndContext();
#line 258 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
    }
    

#line default
#line hidden
#line 270 "C:\Users\Ronald Onwubuya\Documents\Cyberspace Limited\Group Project\latest latest\EmpWebRepo-master\CybProjWeb\Views\User\PersonalSalary.cshtml"
       


}

#line default
#line hidden
            BeginContext(13532, 9, true);
            WriteLiteral("\n\n\n\n\n\n\n\n\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Account> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Account> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CybProjWeb.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
