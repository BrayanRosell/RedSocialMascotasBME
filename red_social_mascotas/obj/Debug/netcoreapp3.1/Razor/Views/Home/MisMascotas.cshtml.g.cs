#pragma checksum "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1780328a5ae9942d5e5e2ea11556fb86e0cd697e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MisMascotas), @"mvc.1.0.view", @"/Views/Home/MisMascotas.cshtml")]
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
#line 1 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\_ViewImports.cshtml"
using red_social_mascotas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\_ViewImports.cshtml"
using red_social_mascotas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1780328a5ae9942d5e5e2ea11556fb86e0cd697e", @"/Views/Home/MisMascotas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb2450aed90dc7ac21b2a43c8a340799a0f5581", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MisMascotas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border: silver 1px solid; border-radius: 12px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1780328a5ae9942d5e5e2ea11556fb86e0cd697e4933", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Dashboard - pets</title>\r\n    <!-- FRAMEWORK BOOTSTRAP para el estilo de la pagina-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1780328a5ae9942d5e5e2ea11556fb86e0cd697e5415", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1780328a5ae9942d5e5e2ea11556fb86e0cd697e6593", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <!-- Los iconos tipo Solid de Fontawesome-->
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.0.8/css/solid.css"">
    <script src=""https://use.fontawesome.com/releases/v5.0.7/js/all.js""></script>
    <style>
        
        body {
            background-image: url(../Img/interface2.jpg);
            height: 100vh;
            background-position: top center;
            background-size: cover;
        }
        .album-poster2 {
            position: relative;
            display: block;
            border-radius: 7px;
            width: 230px;
            height: 525px;
            overflow: hidden;
            box-shadow: 0 15px 35px #3d2173a1;
            transition: all ease 0.4s;
        }

            .album-poster2:hover {
                box-shadow: none;
                transform: scale(0.98) translateY(5px);
            }

            .album-poster2 img {
                width: 200px;
                height: 200px;
            }
    </st");
                WriteLiteral("yle>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1780328a5ae9942d5e5e2ea11556fb86e0cd697e9466", async() => {
                WriteLiteral("\r\n    <div class=\"fondo\">\r\n        <div align=\"center\">\r\n            <a href=\"#\" class=\"btn btn-outline-light rounded-pill pl-5 pr-5\" style=\"color: silver\"><h2><strong>Usuario: </strong> ");
#nullable restore
#line 48 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                                                                                                                             Write(ViewBag.usurioLoged);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2></a>
            <br />
           
        </div>
       
        <div align=""right"">
            <h3><a href=""/Home/RegistarMascota"" class=""btn btn-outline-success"">Registrar mascota</a></h3>
        </div>


        <div class=""container my-4"">

            <!--Carousel Wrapper-->
            <div id=""multi-item-example"" class=""carousel slide carousel-multi-item"" data-ride=""carousel"">

                <!--Slides-->
                <div class=""carousel-inner"" role=""listbox"">

                    <!--First slide-->
                    <div class=""carousel-item active"">

");
#nullable restore
#line 69 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                         foreach (var item in @ViewBag.mismascotas)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""col-md-3"" style=""float:left"">
                                <div class=""album-poster2"">

                                    <div class=""card mb-2"">
                                        <div style=""color: blue"" align=""center"">
                                            <br />
                                            <h3>");
#nullable restore
#line 77 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                            <hr style=\"border-color:red;\" />\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1780328a5ae9942d5e5e2ea11556fb86e0cd697e11999", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2855, "~/images/", 2855, 9, true);
#nullable restore
#line 79 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
AddHtmlAttributeValue("", 2864, item.Imagen, 2864, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n\r\n\r\n                                        <div class=\"card-body\">\r\n\r\n                                            <strong class=\"card-title\"><b>Raza: </b>");
#nullable restore
#line 85 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                                                                               Write(ViewBag.raza[@item.IdRaza].Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong><br />\r\n                                            <strong class=\"card-title\"><b>Especie: </b>");
#nullable restore
#line 86 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                                                                                  Write(ViewBag.especie[@item.IdEspecie].Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong><br />\r\n\r\n                                            <strong class=\"card-title\">\r\n");
#nullable restore
#line 89 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                                                 if (@item.EstadoAdoptivo == false)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    <div style=""color: forestgreen"">
                                                        <b>No está en adopción</b>
                                                    </div>
                                                    <br />
                                                    <h3><a");
                BeginWriteAttribute("href", " href=\"", 3893, "\"", 3941, 2);
                WriteAttributeValue("", 3900, "/Home/PonerEnAdopccion?IdMascota=", 3900, 33, true);
#nullable restore
#line 95 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
WriteAttributeValue("", 3933, item.Id, 3933, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Poner en adopcion</a></h3> ");
#nullable restore
#line 95 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                                                                                                                                                               }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    <div style=""color: darkred"">
                                                        <b>Está en adopción</b>
                                                    </div>
                                                    <br />
                                                    <h3><a");
                BeginWriteAttribute("href", " href=\"", 4443, "\"", 4490, 2);
                WriteAttributeValue("", 4450, "/Home/SacarDeAdopcion?IdMascota=", 4450, 32, true);
#nullable restore
#line 102 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
WriteAttributeValue("", 4482, item.Id, 4482, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary\">Sacar de adopcion</a></h3>");
#nullable restore
#line 102 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                                                                                                                                                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </strong>\r\n                                        </div>\r\n\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 110 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\MisMascotas.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <!--/.First slide-->\r\n\r\n                </div>\r\n                <!--/.Slides-->\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
