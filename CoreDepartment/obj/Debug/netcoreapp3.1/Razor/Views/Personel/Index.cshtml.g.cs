#pragma checksum "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aaac8b23678995ea85907ed52cd48fec639759e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Index), @"mvc.1.0.view", @"/Views/Personel/Index.cshtml")]
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
#line 1 "D:\.netPro\CoreDepartment\CoreDepartment\Views\_ViewImports.cshtml"
using CoreDepartment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
using CoreDepartment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aaac8b23678995ea85907ed52cd48fec639759e", @"/Views/Personel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d47f65a20e6f844f53af1deef077b39ebd34325", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Personel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>ID</td>\r\n        <td>Department</td>\r\n        <td>Delete</td>\r\n        <td>Update</td>\r\n        <td>Details</td>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
           Write(x.PerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
           Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
           Write(x.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
           Write(x.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 548, "\"", 592, 2);
            WriteAttributeValue("", 555, "/Department/DeleteDepartment/", 555, 29, true);
#nullable restore
#line 27 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
WriteAttributeValue("", 584, x.PerId, 584, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 652, "\"", 696, 2);
            WriteAttributeValue("", 659, "/Department/UpdateDepartment/", 659, 29, true);
#nullable restore
#line 28 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
WriteAttributeValue("", 688, x.PerId, 688, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-info\">Details</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "D:\.netPro\CoreDepartment\CoreDepartment\Views\Personel\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a hr");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
