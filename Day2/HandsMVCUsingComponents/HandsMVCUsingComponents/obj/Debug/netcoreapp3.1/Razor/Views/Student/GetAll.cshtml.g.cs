#pragma checksum "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\Student\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a51191a517d851fab775458b9166c8a68a214d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetAll), @"mvc.1.0.view", @"/Views/Student/GetAll.cshtml")]
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
#line 1 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\_ViewImports.cshtml"
using HandsMVCUsingComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\_ViewImports.cshtml"
using HandsMVCUsingComponents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a51191a517d851fab775458b9166c8a68a214d", @"/Views/Student/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8202db332944c70e017c5e1e8450e0dbb07ff87c", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HandsMVCUsingComponents.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\Student\GetAll.cshtml"
  
    ViewData["Title"] = "GetAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List</h1>\r\n<div class=\"container\">\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>ID</th><th>Name</th><th>Age</th><th></th>\r\n        </tr>\r\n");
#nullable restore
#line 12 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\Student\GetAll.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 15 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\Student\GetAll.cshtml"
       Write(item.Sid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\Student\GetAll.cshtml"
       Write(item.Sname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\Student\GetAll.cshtml"
       Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 409, "\"", 437, 2);
            WriteAttributeValue("", 416, "Details?uid=", 416, 12, true);
#nullable restore
#line 18 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\Student\GetAll.cshtml"
WriteAttributeValue("", 428, item.Sid, 428, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ViewInfo</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 20 "D:\IIHT\SOCGEN\Batch1\Day2\HandsMVCUsingComponents\HandsMVCUsingComponents\Views\Student\GetAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HandsMVCUsingComponents.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591