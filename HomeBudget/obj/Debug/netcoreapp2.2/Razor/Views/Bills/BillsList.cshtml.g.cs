#pragma checksum "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e961ed3b81bed249d607a1dc4ef1d94274e50a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_BillsList), @"mvc.1.0.view", @"/Views/Bills/BillsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bills/BillsList.cshtml", typeof(AspNetCore.Views_Bills_BillsList))]
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
#line 1 "H:\HomeBudged\HomeBudged\HomeBudget\Views\_ViewImports.cshtml"
using HomeBudget;

#line default
#line hidden
#line 2 "H:\HomeBudged\HomeBudged\HomeBudget\Views\_ViewImports.cshtml"
using HomeBudget.Models;

#line default
#line hidden
#line 3 "H:\HomeBudged\HomeBudged\HomeBudget\Views\_ViewImports.cshtml"
using HomeBudget.Models.Account;

#line default
#line hidden
#line 4 "H:\HomeBudged\HomeBudged\HomeBudget\Views\_ViewImports.cshtml"
using HomeBudget.Models.Bills;

#line default
#line hidden
#line 6 "H:\HomeBudged\HomeBudged\HomeBudget\Views\_ViewImports.cshtml"
using HomeBudget.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e961ed3b81bed249d607a1dc4ef1d94274e50a5", @"/Views/Bills/BillsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420488a93f905ef451b14dd62d806455e2509990", @"/Views/_ViewImports.cshtml")]
    public class Views_Bills_BillsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bills", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BillsList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 164, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h1>Bills of all family members</h1>\r\n        <button class=\"btn btn-success float-lg-right\">Add</button>\r\n        \r\n        ");
            EndContext();
            BeginContext(191, 356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e961ed3b81bed249d607a1dc4ef1d94274e50a55159", async() => {
                BeginContext(295, 116, true);
                WriteLiteral("\r\n            <input class=\"form-control mr-sm-2\" type=\"text\" name=\"search\" placeholder=\"Search\" aria-label=\"Search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 411, "\"", 432, 1);
#line 8 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
WriteAttributeValue("", 419, Model.Search, 419, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(433, 107, true);
                WriteLiteral(">\r\n            <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(547, 510, true);
            WriteLiteral(@"
        <table class=""table table-striped table-hover"">
            <thead>
                <tr>
                    <th hidden=""hidden"">Id</th>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Description</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Date</th>
                    <th scope=""col"">Amount</th>
                    <th scope=""col"">Actions</th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 25 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
                 foreach (var item in Model.Bills)
                {

#line default
#line hidden
            BeginContext(1128, 70, true);
            WriteLiteral("                    <tr>\r\n                        <th hidden=\"hidden\">");
            EndContext();
            BeginContext(1199, 7, false);
#line 28 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
                                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 47, true);
            WriteLiteral("</th>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1255, 29, false);
#line 29 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
                                    Write(Model.Bills.IndexOf(item) + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1285, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1321, 16, false);
#line 30 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1337, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1373, 15, false);
#line 31 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
                       Write(item.PersonName);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1424, 33, false);
#line 32 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
                       Write(item.BillDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1457, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1493, 11, false);
#line 33 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
                       Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 158, true);
            WriteLiteral("</td>\r\n                        <td><button class=\"btn btn-info\">Edit</button> <button class=\"btn btn-danger\">Remove</button></td>\r\n                    </tr>\r\n");
            EndContext();
#line 36 "H:\HomeBudged\HomeBudged\HomeBudget\Views\Bills\BillsList.cshtml"
                }

#line default
#line hidden
            BeginContext(1681, 50, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
