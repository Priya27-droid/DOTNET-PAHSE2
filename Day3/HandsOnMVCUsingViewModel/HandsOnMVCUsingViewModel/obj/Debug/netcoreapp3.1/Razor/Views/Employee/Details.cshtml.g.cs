#pragma checksum "D:\IIHT\SOCGEN\Batch1\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d7d026e3b5b213dc577f501cbc2110cf6100da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "D:\IIHT\SOCGEN\Batch1\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\_ViewImports.cshtml"
using HandsOnMVCUsingViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IIHT\SOCGEN\Batch1\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\_ViewImports.cshtml"
using HandsOnMVCUsingViewModel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d7d026e3b5b213dc577f501cbc2110cf6100da", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d555f2c5bab75ca5c7aa6540159446fd7b6e5ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnMVCUsingViewModel.ViewModels.EmpWork>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n\t<pre>\r\nID:");
#nullable restore
#line 9 "D:\IIHT\SOCGEN\Batch1\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Employee\Details.cshtml"
Write(Model.Eid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nName:");
#nullable restore
#line 10 "D:\IIHT\SOCGEN\Batch1\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Employee\Details.cshtml"
Write(Model.Ename);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nProject Name:");
#nullable restore
#line 11 "D:\IIHT\SOCGEN\Batch1\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Employee\Details.cshtml"
        Write(Model.Pname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</pre>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnMVCUsingViewModel.ViewModels.EmpWork> Html { get; private set; }
    }
}
#pragma warning restore 1591
