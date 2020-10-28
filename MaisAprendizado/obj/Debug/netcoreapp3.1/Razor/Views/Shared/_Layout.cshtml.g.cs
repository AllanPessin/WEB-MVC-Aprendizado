#pragma checksum "C:\Users\Guilherme\Documents\GitHub\WEB-MVC-Aprendizado\MaisAprendizado\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb029d80562cd074ce3f6413c84d67b588beccf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Guilherme\Documents\GitHub\WEB-MVC-Aprendizado\MaisAprendizado\Views\_ViewImports.cshtml"
using MaisAprendizado;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme\Documents\GitHub\WEB-MVC-Aprendizado\MaisAprendizado\Views\_ViewImports.cshtml"
using MaisAprendizado.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb029d80562cd074ce3f6413c84d67b588beccf7", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a16ad9855f4897d3b63a8bc55d2b88fc56c4ae1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb029d80562cd074ce3f6413c84d67b588beccf73983", async() => {
                WriteLiteral(@"
    <!-- Meta tags Obrigatórias -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css""
          integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">

    <!-- Fontawesome CSS -->
    <link rel=""stylesheet"" href=""fontawesome/css/all.css"">

    <!-- Estilo customizado -->
    <link rel=""stylesheet"" type=""text/css"" href=""css/site.css"">

    <title>+Aprendizados</title>
    <link rel=""icon""");
                BeginWriteAttribute("type", " type=\"", 711, "\"", 718, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"img/favicon.png\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb029d80562cd074ce3f6413c84d67b588beccf75817", async() => {
                WriteLiteral(@"

    <header>
        <!-- Inicio Cabeçalho -->
        <nav class=""navbar fixed-top navbar-expand-lg navbar-light"" style=""background:#FFFFFF;"">
            <a class=""navbar-brand"" href=""#""><img src=""img/logo2.png"" width=""247""></a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#conteudoNavbarSuportado""
                    aria-controls=""conteudoNavbarSuportado"" aria-expanded=""false"" aria-label=""Alterna navegação"">
                <span class=""navbar-toggler-icon""></span>
            </button>


            <div class=""collapse navbar-collapse justify-content-end"" id=""conteudoNavbarSuportado"">
                <div class=""navbar-nav"">
                    <a class=""nav-item nav-link"" href=""#"">
                        HOME <span class=""sr-only"">
                            (Página
                            atual)
                        </span>
                    </a>
                    <a class=""nav-item nav-link"" href=""#"">SOBRE</a>
       ");
                WriteLiteral("             <a class=\"nav-item nav-link\" href=\"#\">CURSOS</a>\r\n\r\n                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb029d80562cd074ce3f6413c84d67b588beccf77290", async() => {
                    WriteLiteral(@"
                    <a class=""nav-item nav-link"" href=""#"" style=""color: #333333;"">
                        <img src=""img/8-512.png""
                             width=""50"">LOGIN |
                    </a>

                    <div class=""text-center"">
                        <button class=""btn btn-outline-danger my-2 my-sm-0"" type=""submit"">CADASTRAR</button>

                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </nav>\r\n\r\n\r\n\r\n\r\n    </header> <!-- Fim Cabeçalho -->\r\n\r\n            ");
#nullable restore
#line 65 "C:\Users\Guilherme\Documents\GitHub\WEB-MVC-Aprendizado\MaisAprendizado\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-2"">
                    <img src=""img/logo2.png"" width=""100"">
                </div>
                <div class=""col-md-2"">
                    <h4>company</h4>
                    <ul class=""navbar-nav"">
                        <li>
                            <a");
                BeginWriteAttribute("href", " href=\"", 2852, "\"", 2859, 0);
                EndWriteAttribute();
                WriteLiteral(">HOME</a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 2962, "\"", 2969, 0);
                EndWriteAttribute();
                WriteLiteral(">SOBRE</a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3073, "\"", 3080, 0);
                EndWriteAttribute();
                WriteLiteral(">CURSOS</a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <ul>\r\n                        <li>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3302, "\"", 3309, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <img src=\"img/download.png\" width=\"50\">\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3511, "\"", 3518, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <img src=\"img/download.jpg\" width=\"50\">\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </footer>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
