#pragma checksum "C:\Revature\Project1\PizzaBox2.Client\Views\Preset\PresetTopping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90f40261b339610a25cff97ae748ced967390329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Preset_PresetTopping), @"mvc.1.0.view", @"/Views/Preset/PresetTopping.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Preset/PresetTopping.cshtml", typeof(AspNetCore.Views_Preset_PresetTopping))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90f40261b339610a25cff97ae748ced967390329", @"/Views/Preset/PresetTopping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bf6029131851d93c801b95dc3191f224ae1b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Preset_PresetTopping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Preset/PresetTopping"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Revature\Project1\PizzaBox2.Client\Views\Preset\PresetTopping.cshtml"
  
  Layout="_Layout";

#line default
#line hidden
            BeginContext(30, 184, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4 >Classic Pizza Builder</h4>\r\n    <p>Please choose your Toppings</p><br>\r\n    <p>Include at least two toppings and at most five toppings</p>\r\n\r\n    ");
            EndContext();
            BeginContext(214, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90f40261b339610a25cff97ae748ced9673903294445", async() => {
                BeginContext(265, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 12 "C:\Revature\Project1\PizzaBox2.Client\Views\Preset\PresetTopping.cshtml"
      foreach (var t in ViewBag.top)
      {

#line default
#line hidden
                BeginContext(314, 63, true);
                WriteLiteral("        <br>\r\n        <label><input type=\"checkbox\" name=\"List\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 377, "\"", 387, 1);
#line 15 "C:\Revature\Project1\PizzaBox2.Client\Views\Preset\PresetTopping.cshtml"
WriteAttributeValue("", 385, t, 385, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(388, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(390, 1, false);
#line 15 "C:\Revature\Project1\PizzaBox2.Client\Views\Preset\PresetTopping.cshtml"
                                                        Write(t);

#line default
#line hidden
                EndContext();
                BeginContext(391, 10, true);
                WriteLiteral("</label>\r\n");
                EndContext();
#line 16 "C:\Revature\Project1\PizzaBox2.Client\Views\Preset\PresetTopping.cshtml"
      }

#line default
#line hidden
                BeginContext(410, 78, true);
                WriteLiteral("      <br><br>\r\n    <button type=\"submit\">Submit Toppings</button>\r\n    \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(495, 18, true);
            WriteLiteral("\r\n    <p> \r\n</div>");
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
