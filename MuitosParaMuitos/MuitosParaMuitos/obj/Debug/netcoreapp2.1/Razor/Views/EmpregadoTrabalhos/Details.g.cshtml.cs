#pragma checksum "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c91c0ebf8589da7bb1636c180fbc381151ff65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmpregadoTrabalhos_Details), @"mvc.1.0.view", @"/Views/EmpregadoTrabalhos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmpregadoTrabalhos/Details.cshtml", typeof(AspNetCore.Views_EmpregadoTrabalhos_Details))]
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
#line 1 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\_ViewImports.cshtml"
using MuitosParaMuitos;

#line default
#line hidden
#line 2 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\_ViewImports.cshtml"
using MuitosParaMuitos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c91c0ebf8589da7bb1636c180fbc381151ff65", @"/Views/EmpregadoTrabalhos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c440b79e194b62fbba4aec9d1f0d6783973323", @"/Views/_ViewImports.cshtml")]
    public class Views_EmpregadoTrabalhos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MuitosParaMuitos.Models.EmpregadoTrabalho>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 131, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>EmpregadoTrabalho</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(227, 45, false);
#line 14 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empregado));

#line default
#line hidden
            EndContext();
            BeginContext(272, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(316, 53, false);
#line 17 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empregado.EmpregadoId));

#line default
#line hidden
            EndContext();
            BeginContext(369, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(413, 44, false);
#line 20 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Trabalho));

#line default
#line hidden
            EndContext();
            BeginContext(457, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(501, 51, false);
#line 23 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Trabalho.TrabalhoId));

#line default
#line hidden
            EndContext();
            BeginContext(552, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(596, 48, false);
#line 26 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CargaHoraria));

#line default
#line hidden
            EndContext();
            BeginContext(644, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(688, 44, false);
#line 29 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml"
       Write(Html.DisplayFor(model => model.CargaHoraria));

#line default
#line hidden
            EndContext();
            BeginContext(732, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(780, 68, false);
#line 34 "C:\Users\thiag\Desktop\MuitosParaMuitos\MuitosParaMuitos\Views\EmpregadoTrabalhos\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(848, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(856, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "397e09be86d147bba3b54986789f00df", async() => {
                BeginContext(878, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(894, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MuitosParaMuitos.Models.EmpregadoTrabalho> Html { get; private set; }
    }
}
#pragma warning restore 1591
