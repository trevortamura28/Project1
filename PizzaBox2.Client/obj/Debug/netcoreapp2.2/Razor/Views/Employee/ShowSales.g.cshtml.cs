#pragma checksum "C:\Revature\Project1\PizzaBox2.Client\Views\Employee\ShowSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df308c93d00e8039da6291dbca447b7c68f5f34a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ShowSales), @"mvc.1.0.view", @"/Views/Employee/ShowSales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/ShowSales.cshtml", typeof(AspNetCore.Views_Employee_ShowSales))]
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
#line 1 "C:\Revature\Project1\PizzaBox2.Client\Views\_ViewImports.cshtml"
using PizzaBox2.Client;

#line default
#line hidden
#line 2 "C:\Revature\Project1\PizzaBox2.Client\Views\_ViewImports.cshtml"
using PizzaBox2.Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df308c93d00e8039da6291dbca447b7c68f5f34a", @"/Views/Employee/ShowSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bf6029131851d93c801b95dc3191f224ae1b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ShowSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Revature\Project1\PizzaBox2.Client\Views\Employee\ShowSales.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
            BeginContext(32, 71, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 >Recent Sales</h1>\r\n    <br><br>\r\n");
            EndContext();
#line 9 "C:\Revature\Project1\PizzaBox2.Client\Views\Employee\ShowSales.cshtml"
     foreach (decimal d in ViewBag.costs)
      {

#line default
#line hidden
            BeginContext(155, 12, true);
            WriteLiteral("        <p>$");
            EndContext();
            BeginContext(168, 1, false);
#line 11 "C:\Revature\Project1\PizzaBox2.Client\Views\Employee\ShowSales.cshtml"
       Write(d);

#line default
#line hidden
            EndContext();
            BeginContext(169, 10, true);
            WriteLiteral("</p><br>\r\n");
            EndContext();
#line 12 "C:\Revature\Project1\PizzaBox2.Client\Views\Employee\ShowSales.cshtml"
      }

#line default
#line hidden
            BeginContext(188, 45, true);
            WriteLiteral("      <br><br>\r\n       \r\n       \r\n       <p> ");
            EndContext();
            BeginContext(234, 44, false);
#line 16 "C:\Revature\Project1\PizzaBox2.Client\Views\Employee\ShowSales.cshtml"
      Write(Html.ActionLink("Back", "Index", "Employee"));

#line default
#line hidden
            EndContext();
            BeginContext(278, 19, true);
            WriteLiteral(" </p>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
