#pragma checksum "C:\Users\android\source\repos\SITCC\SITCC\Views\Home\atualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "436bb96577416a78a38d1ac9120ee871ae630bea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_atualizar), @"mvc.1.0.view", @"/Views/Home/atualizar.cshtml")]
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
#line 1 "C:\Users\android\source\repos\SITCC\SITCC\Views\_ViewImports.cshtml"
using SITCC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\android\source\repos\SITCC\SITCC\Views\_ViewImports.cshtml"
using SITCC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436bb96577416a78a38d1ac9120ee871ae630bea", @"/Views/Home/atualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec351d2c3eb8aa16e71e4b84c365fd3d43f7c3d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_atualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Atualizar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<h1>Atualizar </h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "436bb96577416a78a38d1ac9120ee871ae630bea3853", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"codigo\">Código</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"codigo\"");
                BeginWriteAttribute("value", " value=\"", 199, "\"", 238, 1);
#nullable restore
#line 7 "C:\Users\android\source\repos\SITCC\SITCC\Views\Home\atualizar.cshtml"
WriteAttributeValue("", 207, ViewBag.ProdutoAtualizar.proID, 207, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"codigo\" >\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"nomeproduto\">Nome</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"nomeproduto\"");
                BeginWriteAttribute("value", " value=\"", 414, "\"", 459, 1);
#nullable restore
#line 13 "C:\Users\android\source\repos\SITCC\SITCC\Views\Home\atualizar.cshtml"
WriteAttributeValue("", 422, ViewBag.ProdutoAtualizar.nomeproduto, 422, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"nomeproduto\">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"descricaoproduto\">Descricao</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"descricaoproduto\"");
                BeginWriteAttribute("value", " value=\"", 652, "\"", 702, 1);
#nullable restore
#line 18 "C:\Users\android\source\repos\SITCC\SITCC\Views\Home\atualizar.cshtml"
WriteAttributeValue("", 660, ViewBag.ProdutoAtualizar.descricaoproduto, 660, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"descricaoproduto\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"preco\">Preço</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"preco\"");
                BeginWriteAttribute("value", " value=\"", 872, "\"", 911, 1);
#nullable restore
#line 22 "C:\Users\android\source\repos\SITCC\SITCC\Views\Home\atualizar.cshtml"
WriteAttributeValue("", 880, ViewBag.ProdutoAtualizar.preco, 880, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"preco\">\r\n    </div>\r\n \r\n\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
