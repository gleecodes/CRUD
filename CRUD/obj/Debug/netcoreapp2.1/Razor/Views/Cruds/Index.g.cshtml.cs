#pragma checksum "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb4b42ce450821e8c04331eb74581b6e4f98dc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cruds_Index), @"mvc.1.0.view", @"/Views/Cruds/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cruds/Index.cshtml", typeof(AspNetCore.Views_Cruds_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb4b42ce450821e8c04331eb74581b6e4f98dc0", @"/Views/Cruds/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813d028d5e7480ef09b6d196de8cd6b00c3ad294", @"/Views/_ViewImports.cshtml")]
    public class Views_Cruds_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dishes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 175, true);
            WriteLiteral("    \r\n<div class=\"jumbotron\">\r\n    \r\n<h1>Welcome to CRUDelicious</h1>\r\n\r\n<a href=\"/new\">Add a Dish</a>\r\n<div class=\"container\">\r\n\r\n<p>Check out some recent dishes!</p><hr>\r\n\r\n");
            EndContext();
#line 12 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Index.cshtml"
 foreach (var dish in Model){

#line default
#line hidden
            BeginContext(227, 9, true);
            WriteLiteral("    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 236, "\"", 252, 2);
            WriteAttributeValue("", 243, "/", 243, 1, true);
#line 13 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Index.cshtml"
WriteAttributeValue("", 244, dish.Id, 244, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(253, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(255, 9, false);
#line 13 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Index.cshtml"
                      Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(264, 5, true);
            WriteLiteral("</a> ");
            EndContext();
            BeginContext(270, 9, false);
#line 13 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Index.cshtml"
                                     Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(279, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 14 "/Users/gina/Desktop/C#/Entity/CRUD/Views/Cruds/Index.cshtml"
}

#line default
#line hidden
            BeginContext(289, 18, true);
            WriteLiteral("\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dishes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
