#pragma checksum "C:\Users\Piteu\OneDrive\Documentos\GitHub\Samuel\SITCC\SITCC\Views\Acessorio\atualizar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "55ec87f46146388dccd1b7b5b8794505eb3e937a4d5e1f2bce345220961aca4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acessorio_atualizar), @"mvc.1.0.view", @"/Views/Acessorio/atualizar.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Piteu\OneDrive\Documentos\GitHub\Samuel\SITCC\SITCC\Views\_ViewImports.cshtml"
using SITCC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Piteu\OneDrive\Documentos\GitHub\Samuel\SITCC\SITCC\Views\_ViewImports.cshtml"
using SITCC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"55ec87f46146388dccd1b7b5b8794505eb3e937a4d5e1f2bce345220961aca4d", @"/Views/Acessorio/atualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bdc09f00fecdf4f1858707e9ea9216ab738265045b16aa4741ac05c843399be7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Acessorio_atualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55ec87f46146388dccd1b7b5b8794505eb3e937a4d5e1f2bce345220961aca4d4113", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"codigo\">Código</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"codigo\"");
                BeginWriteAttribute("value", " value=\"", 199, "\"", 240, 1);
#nullable restore
#line 7 "C:\Users\Piteu\OneDrive\Documentos\GitHub\Samuel\SITCC\SITCC\Views\Acessorio\atualizar.cshtml"
WriteAttributeValue("", 207, ViewBag.AcessorioAtualizar.proID, 207, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"codigo\">\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"nomeproduto\">Nome</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"nomeproduto\"");
                BeginWriteAttribute("value", " value=\"", 415, "\"", 462, 1);
#nullable restore
#line 13 "C:\Users\Piteu\OneDrive\Documentos\GitHub\Samuel\SITCC\SITCC\Views\Acessorio\atualizar.cshtml"
WriteAttributeValue("", 423, ViewBag.AcessorioAtualizar.nomeproduto, 423, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"nomeproduto\">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"descricaoproduto\">Descricao</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"descricaoproduto\"");
                BeginWriteAttribute("value", " value=\"", 655, "\"", 707, 1);
#nullable restore
#line 18 "C:\Users\Piteu\OneDrive\Documentos\GitHub\Samuel\SITCC\SITCC\Views\Acessorio\atualizar.cshtml"
WriteAttributeValue("", 663, ViewBag.AcessorioAtualizar.descricaoproduto, 663, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"descricaoproduto\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"preco\">Preço</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"preco\"");
                BeginWriteAttribute("value", " value=\"", 877, "\"", 918, 1);
#nullable restore
#line 22 "C:\Users\Piteu\OneDrive\Documentos\GitHub\Samuel\SITCC\SITCC\Views\Acessorio\atualizar.cshtml"
WriteAttributeValue("", 885, ViewBag.AcessorioAtualizar.preco, 885, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"preco\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"fotoproduto\">Foto</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"fotoproduto\"");
                BeginWriteAttribute("value", " value=\"", 1088, "\"", 1135, 1);
#nullable restore
#line 26 "C:\Users\Piteu\OneDrive\Documentos\GitHub\Samuel\SITCC\SITCC\Views\Acessorio\atualizar.cshtml"
WriteAttributeValue("", 1096, ViewBag.AcessorioAtualizar.fotoproduto, 1096, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"fotoproduto\">\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
