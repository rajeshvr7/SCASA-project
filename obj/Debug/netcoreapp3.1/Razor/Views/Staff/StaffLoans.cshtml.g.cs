#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ca6c268a59dd683c8615db29d5ac941c8401cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_StaffLoans), @"mvc.1.0.view", @"/Views/Staff/StaffLoans.cshtml")]
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
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ca6c268a59dd683c8615db29d5ac941c8401cd", @"/Views/Staff/StaffLoans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_StaffLoans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SCASA.Models.ModelClasses.StaffLoansDisplay>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Staff/StaffLoansData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
  
    int rCnt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-dashboard""></i>
        </div>
        <div class=""header-title"">
            <h1>Staff Loans</h1>
            <small></small>
            
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-lg-12 pinpin"">
                <div class=""card"" data-sortable=""true"">
                    <div class=""card-header"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""card-title custom_title"">
                                    <h4>Staff Loans</h4>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""btn-group float-right"" role=""group"">
  ");
            WriteLiteral("                                  <div class=\"buttonexport\" id=\"buttonlist\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03ca6c268a59dd683c8615db29d5ac941c8401cd5209", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-plus\"></i> Add New\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                        <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                        <div class=""table-responsive"">
                            <table id=""dataTableExample1"" class=""table table-bordered table-striped table-hover"">
                                <thead class=""back_table_color"">
                                    <tr class=""info"">
                                        <th>#.</th>
                                        <th>Staff Name</th>
                                        <th>Employee Code</th>
                                        <th>Amount Taken</th>
                                        <th>Taken On</th>
                                        <th>R");
            WriteLiteral(@"epayment Mode</th>
                                        <th>Monthly EMI</th>
                                        <th>Loan Status</th>
                                        <th>Remarks</th>
                                     
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 64 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                     foreach (var u in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 67 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                        Write(rCnt ++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 68 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                       Write(u.StaffName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 69 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                       Write(u.EmpCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 70 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                       Write(u.AmountTaken);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 71 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                           
                                            DateTime dt = Convert.ToDateTime(u.TakenOn);
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 74 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                       Write(dt.ToString("dd/MMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 75 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                       Write(u.RepaymentMode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 76 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                       Write(u.MonthlyEMI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 77 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                       Write(u.LoanStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 78 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                       Write(u.Remarks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                       \r\n                                    </tr>\r\n");
#nullable restore
#line 82 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Staff\StaffLoans.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- /.content -->\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SCASA.Models.ModelClasses.StaffLoansDisplay>> Html { get; private set; }
    }
}
#pragma warning restore 1591
