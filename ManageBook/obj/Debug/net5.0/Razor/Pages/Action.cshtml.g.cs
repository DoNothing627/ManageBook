#pragma checksum "C:\Users\An\source\repos\ManageBook\ManageBook\Pages\Action.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca161fae47355b5753c17c756a5bbd05b2e84c6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ManageBook.Pages.Pages_Action), @"mvc.1.0.razor-page", @"/Pages/Action.cshtml")]
namespace ManageBook.Pages
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
#line 1 "C:\Users\An\source\repos\ManageBook\ManageBook\Pages\_ViewImports.cshtml"
using ManageBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\An\source\repos\ManageBook\ManageBook\Pages\Action.cshtml"
using ManageBook.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca161fae47355b5753c17c756a5bbd05b2e84c6e", @"/Pages/Action.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcddd303523a44a92a16f5bee0ea684b30d9f1b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Action : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\An\source\repos\ManageBook\ManageBook\Pages\Action.cshtml"
  
    ViewData["Title"] = "Action";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\An\source\repos\ManageBook\ManageBook\Pages\Action.cshtml"
Write(await Html.RenderComponentAsync<Admin>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script src=\"_framework/blazor.server.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActionModel>)PageContext?.ViewData;
        public ActionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
