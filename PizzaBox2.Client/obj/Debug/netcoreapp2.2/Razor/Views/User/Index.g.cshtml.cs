#pragma checksum "C:\Revature\Project1\PizzaBox2.Client\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70fa3bcc3ae34ead7a9201eb4517476d80f391ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70fa3bcc3ae34ead7a9201eb4517476d80f391ff", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bf6029131851d93c801b95dc3191f224ae1b1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Revature\Project1\PizzaBox2.Client\Views\User\Index.cshtml"
  
    Layout="_Layout2";

#line default
#line hidden
            BeginContext(33, 96, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 >Welcome to PizzaBox 2</h1>\r\n    <br><br><br><br>\r\n    <p> ");
            EndContext();
            BeginContext(130, 66, false);
#line 9 "C:\Revature\Project1\PizzaBox2.Client\Views\User\Index.cshtml"
   Write(Html.ActionLink("Select a location", "SelectLocation", "Location"));

#line default
#line hidden
            EndContext();
            BeginContext(196, 15, true);
            WriteLiteral(" </p>\r\n    <p> ");
            EndContext();
            BeginContext(212, 61, false);
#line 10 "C:\Revature\Project1\PizzaBox2.Client\Views\User\Index.cshtml"
   Write(Html.ActionLink("Account information", "UserAccount", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(273, 15, true);
            WriteLiteral(" </p>\r\n    <p> ");
            EndContext();
            BeginContext(289, 44, false);
#line 11 "C:\Revature\Project1\PizzaBox2.Client\Views\User\Index.cshtml"
   Write(Html.ActionLink("Sign out", "Login", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(333, 13, true);
            WriteLiteral(" </p>\r\n</div>");
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