#pragma checksum "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a3c1b235f10f6e2f6850b162b3bc156e78b7778"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowData), @"mvc.1.0.view", @"/Views/Home/ShowData.cshtml")]
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
#line 1 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\_ViewImports.cshtml"
using Project.PresentationLayer_PL_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\_ViewImports.cshtml"
using Project.PresentationLayer_PL_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\_ViewImports.cshtml"
using Project.PresentationLayer_PL_.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\_ViewImports.cshtml"
using Project.DataAccessLayer_DAL_.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\_ViewImports.cshtml"
using Project.BussinessLogicLayer_BLL_.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a3c1b235f10f6e2f6850b162b3bc156e78b7778", @"/Views/Home/ShowData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b020925125ce08c1a1f0b4869d30ee1a5f28df7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ShowData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
  
    ViewData["Title"] = "ShowData";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Books Bublished By ");
#nullable restore
#line 5 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
                  Write(ViewBag.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3c1b235f10f6e2f6850b162b3bc156e78b77785239", async() => {
                WriteLiteral("Back To List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 10 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
 if (Model?.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped table-hover col-4\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 15 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
               Write(Html.DisplayNameFor(E=>E.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
               Write(Html.DisplayNameFor(E=>E.DateOfBublish));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
             foreach (var item in Model)
            {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
                   Write(Html.DisplayFor(E=>item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("       </td>\r\n                    <td>");
#nullable restore
#line 25 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
                   Write(Html.DisplayFor(E=>item.DateOfBublish));

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 30 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"alert alert-warning mt-5\">\r\n        <h3>No Books Found For Bublisher  ");
#nullable restore
#line 34 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
                                     Write(ViewBag.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n");
#nullable restore
#line 36 "G:\Cube Master Company\Task 1 MVC\Project.PresentationLayer(PL)\Views\Home\ShowData.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
