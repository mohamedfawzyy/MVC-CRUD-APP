#pragma checksum "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b5b6d733484977d59c1ea554704640b63efff7c3657b326e8be3ff4c09e43fd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\_ViewImports.cshtml"
using MVC.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\_ViewImports.cshtml"
using MVC.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\_ViewImports.cshtml"
using MVC.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\_ViewImports.cshtml"
using MVC.BLL.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b5b6d733484977d59c1ea554704640b63efff7c3657b326e8be3ff4c09e43fd0", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2a9a4a3dd4630ebd5cb739374e4f91ef1a648609488d8836611119aae8d608c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DepartmentViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "department", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex justify-content-between align-items-center alert alert-success\">\r\n   \r\n    <h1");
            BeginWriteAttribute("class", " class=\"", 227, "\"", 235, 0);
            EndWriteAttribute();
            WriteLiteral(">Department Mangement System</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5b6d733484977d59c1ea554704640b63efff7c3657b326e8be3ff4c09e43fd05936", async() => {
                WriteLiteral("Add new Department");
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
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 11 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 16 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 17 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 18 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.DateOfCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Detailes</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 25 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
             foreach (var department in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
                   Write(department.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
                   Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
                   Write(department.DateOfCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5b6d733484977d59c1ea554704640b63efff7c3657b326e8be3ff4c09e43fd010349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 31 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = department;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 33 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 36 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
   
    
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">Sorry there is no deparrtments to show</div>    \r\n");
#nullable restore
#line 42 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ToasrtShow", async() => {
                WriteLiteral("\r\n    <script>\r\n        if (\'");
#nullable restore
#line 46 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
        Write(string.IsNullOrEmpty(TempData["Message"] as string));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' == \"False\") {\r\n            toastr.info(\'");
#nullable restore
#line 47 "D:\engineering terms\front-end-engineer\Route\C41 RouteBackend\08 ASP.NET Core MVC\MVCProject\MVCProject\MVC.PL\Views\Department\Index.cshtml"
                    Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        } \r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DepartmentViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
