#pragma checksum "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d36cc3a42fa1f4174846220a2b6b07a3aaa0d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.Frontend.Pages.Pacientes.Pages_Pacientes_Details), @"mvc.1.0.razor-page", @"/Pages/Pacientes/Details.cshtml")]
namespace HospiEnCasa.App.Frontend.Pages.Pacientes
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
#line 1 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d36cc3a42fa1f4174846220a2b6b07a3aaa0d4", @"/Pages/Pacientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29c1093da579e7f24923c861712d3287de7427a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pacientes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddSignoVital", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle del paciente</h1>\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th scope=\"col\">Nombre</th>\r\n        <td>");
#nullable restore
#line 9 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Apellidos</th>\r\n        <td>");
#nullable restore
#line 13 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
       Write(Model.paciente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Medico</th>\r\n");
#nullable restore
#line 17 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
         if (Model.paciente.Medico == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d36cc3a42fa1f4174846220a2b6b07a3aaa0d45496", async() => {
                WriteLiteral("Asignar medico");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
                                                                    WriteLiteral(Model.paciente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 20 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
        } 
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 23 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
           Write(Model.paciente.Medico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 24 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
        }        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Signos vitales</th>\r\n        <td>\r\n            <ul>\r\n");
#nullable restore
#line 30 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
                 foreach (var signoVital in Model.paciente.SignosVitales)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 32 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
                   Write(signoVital.Signo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 32 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
                                       Write(signoVital.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>                    \r\n");
#nullable restore
#line 33 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d36cc3a42fa1f4174846220a2b6b07a3aaa0d410050", async() => {
                WriteLiteral("\r\n                Asignar signo vital\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Heri\UdeC\Formacion\Ciclo 3\Grupo 1\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Details.cshtml"
                                                                    WriteLiteral(Model.paciente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d36cc3a42fa1f4174846220a2b6b07a3aaa0d412458", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.Frontend.Pages.Pacientes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Frontend.Pages.Pacientes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Frontend.Pages.Pacientes.DetailsModel>)PageContext?.ViewData;
        public HospiEnCasa.App.Frontend.Pages.Pacientes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
