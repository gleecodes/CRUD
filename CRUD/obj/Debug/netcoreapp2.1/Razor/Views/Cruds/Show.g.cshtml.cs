#pragma checksum "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ade3d9c925f7a5ae3c1474d07cce315fd9700e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cruds_Show), @"mvc.1.0.view", @"/Views/Cruds/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cruds/Show.cshtml", typeof(AspNetCore.Views_Cruds_Show))]
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
#line 1 "/Users/gina/Desktop/C#/Entity/CRUD/Views/_ViewImports.cshtml"
using CRUD;

#line default
#line hidden
#line 2 "/Users/gina/Desktop/C#/Entity/CRUD/Views/_ViewImports.cshtml"
using CRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ade3d9c925f7a5ae3c1474d07cce315fd9700e9", @"/Views/Cruds/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813d028d5e7480ef09b6d196de8cd6b00c3ad294", @"/Views/_ViewImports.cshtml")]
    public class Views_Cruds_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dishes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 31, true);
            WriteLiteral("\n\n\n\n<a href=\"/\" >HOME</a>\n\n<h1>");
            EndContext();
            BeginContext(46, 10, false);
#line 8 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Show.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(56, 12, true);
            WriteLiteral("</h1> \n<h3> ");
            EndContext();
            BeginContext(69, 10, false);
#line 9 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Show.cshtml"
Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(79, 15, true);
            WriteLiteral(" </h3><hr>\n<p> ");
            EndContext();
            BeginContext(95, 17, false);
#line 10 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Show.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(112, 21, true);
            WriteLiteral(" </p> \n<p> Calories: ");
            EndContext();
            BeginContext(134, 14, false);
#line 11 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Show.cshtml"
         Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(148, 21, true);
            WriteLiteral(" </p>\n<p> Tastiness: ");
            EndContext();
            BeginContext(170, 15, false);
#line 12 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Show.cshtml"
          Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(185, 9, true);
            WriteLiteral(" </p>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 194, "\"", 218, 2);
            WriteAttributeValue("", 201, "/delete/", 201, 8, true);
#line 14 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Show.cshtml"
WriteAttributeValue("", 209, Model.Id, 209, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(219, 28, true);
            WriteLiteral(" type=\"button\">Delete</a>\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 247, "\"", 269, 2);
            WriteAttributeValue("", 254, "/edit/", 254, 6, true);
#line 15 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Show.cshtml"
WriteAttributeValue("", 260, Model.Id, 260, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(270, 23, true);
            WriteLiteral(" type=\"button\">Edit</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dishes> Html { get; private set; }
    }
}
#pragma warning restore 1591
