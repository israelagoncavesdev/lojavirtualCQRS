#pragma checksum "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebcf57075c6682a64233579cfd84b1049890882e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_ResumoDaCompra), @"mvc.1.0.view", @"/Views/Carrinho/ResumoDaCompra.cshtml")]
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
#line 1 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\_ViewImports.cshtml"
using MinhaLojaVirtual.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\_ViewImports.cshtml"
using MinhaLojaVirtual.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebcf57075c6682a64233579cfd84b1049890882e", @"/Views/Carrinho/ResumoDaCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"636dab0bd4713c3bcdd12f58f36d9dde722addc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_ResumoDaCompra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MinhaLojaVirtual.Vendas.Application.Queries.ViewModels.CarrinhoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("required", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IniciarPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <vc:summary />\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 12 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
          
            if (Model.Items.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4 order-md-2 mb-4"">
                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                        <span class=""text-muted"">Resumo da Compra</span>
                        <span class=""badge badge-secondary badge-pill"">");
#nullable restore
#line 18 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                                  Write(Model.Items.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h4>\r\n                    <ul class=\"list-group mb-3\">\r\n\r\n");
#nullable restore
#line 22 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                          
                            foreach (var item in Model.Items)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                                    <div>\r\n                                        <h6 class=\"my-0\">");
#nullable restore
#line 27 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                    Write(item.ProdutoNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <small class=\"text-muted\">");
#nullable restore
#line 28 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                             Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Unidades</small>\r\n                                    </div>\r\n                                    <span class=\"text-muted\">");
#nullable restore
#line 30 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                        Write(item.ValorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n");
#nullable restore
#line 32 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                            }

                            if (!string.IsNullOrEmpty(Model.VoucherCodigo))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""list-group-item d-flex justify-content-between bg-light"">
                                    <div class=""text-success"">
                                        <h6 class=""my-0"">Voucher Utilizado</h6>
                                        <small>");
#nullable restore
#line 39 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                          Write(Model.VoucherCodigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </div>\r\n                                    <span class=\"text-success\">-");
#nullable restore
#line 41 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                           Write(Model.ValorDesconto.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n");
#nullable restore
#line 43 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between\">\r\n                                <span>Total</span>\r\n                                <strong>");
#nullable restore
#line 47 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                   Write(Model.ValorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            </li>\r\n");
            WriteLiteral("                    </ul>\r\n\r\n                </div>\r\n                <div class=\"col-md-8 order-md-1\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebcf57075c6682a64233579cfd84b1049890882e11649", async() => {
                WriteLiteral(@"

                        <h4 class=""mb-3"">Pagamento</h4>
                        <hr class=""mb-4"">
                        <div class=""row"">
                            <img class=""img-fluid"" src=""Images/cards.png"">

                        </div>
                        <br /><br />
                        <div class=""row"">
                            <div class=""col-md-6 mb-3"">
                                <label>Nome no Cartão</label>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ebcf57075c6682a64233579cfd84b1049890882e12409", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 66 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pagamento.NomeCartao);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                <small class=""text-muted"">Nome completo como consta no cartão</small>
                            </div>
                            <div class=""col-md-6 mb-3"">
                                <label>Número do Cartão</label>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ebcf57075c6682a64233579cfd84b1049890882e14738", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 71 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pagamento.NumeroCartao);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-3 mb-3"">
                                <label>Data Expiração</label>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ebcf57075c6682a64233579cfd84b1049890882e17039", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 77 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pagamento.ExpiracaoCartao);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-3 mb-3\">\r\n                                <label>CVV</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ebcf57075c6682a64233579cfd84b1049890882e19262", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 81 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pagamento.CvvCartao);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <hr class=\"mb-4\">\r\n                        <button class=\"btn btn-primary btn-lg btn-block\" type=\"submit\">Finalizar Compra</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 88 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><p>Carrinho Vazio</p></div>\r\n");
#nullable restore
#line 92 "C:\Projects\israelagoncalvesdev\Magnum\lojavirtualCQRS\MinhaLojaVirtual\src\MinhaLoja.WebApps.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MinhaLojaVirtual.Vendas.Application.Queries.ViewModels.CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
