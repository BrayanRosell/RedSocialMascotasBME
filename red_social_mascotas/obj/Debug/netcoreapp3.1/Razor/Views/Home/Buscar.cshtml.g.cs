#pragma checksum "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "470d89232a8cf00e486263172b83400d19ee39bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Buscar), @"mvc.1.0.view", @"/Views/Home/Buscar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470d89232a8cf00e486263172b83400d19ee39bc", @"/Views/Home/Buscar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb2450aed90dc7ac21b2a43c8a340799a0f5581", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Buscar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline tm-mb-40 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-3 img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "470d89232a8cf00e486263172b83400d19ee39bc5746", async() => {
                WriteLiteral(@"
    <title>Dashboard - pets</title>

    <style>
        .tm-main {
            width: 90%;
            float: right;
            left: 15%;
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
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "470d89232a8cf00e486263172b83400d19ee39bc7451", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n        <main class=\"tm-main\">\r\n\r\n            <div class=\"row tm-row\">\r\n                <div class=\"col-12\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "470d89232a8cf00e486263172b83400d19ee39bc7916", async() => {
                    WriteLiteral(@"
                        <input class=""form-control tm-search-input"" name=""search"" type=""text"" placeholder=""Buscar..."" aria-label=""Search"">
                        <button class=""tm-search-button"" type=""submit"">
                            <i class=""fas fa-search tm-search-icon"" aria-hidden=""true""></i>
                        </button>
                    ");
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
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 55 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
             if (ViewBag.VerificaMascota != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                 foreach (var item in @ViewBag.mascotaPase)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row tm-row\">\r\n                        <div class=\"col-12\">\r\n                            <hr class=\"tm-hr-primary tm-mb-55\">\r\n");
#nullable restore
#line 62 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                               int n = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                             foreach (var itemx in @item.Fotos)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                 if (n == 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "470d89232a8cf00e486263172b83400d19ee39bc11445", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2023, "~/images/", 2023, 9, true);
#nullable restore
#line 67 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
AddHtmlAttributeValue("", 2032, itemx.Imagen, 2032, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 68 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"

                                    n++;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                 

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row tm-row"">
                        <div class=""col-lg-8 tm-post-col"">
                            <div class=""tm-post-full"">
                                <div class=""mb-4"">
                                    <h2 class=""pt-2 tm-color-primary tm-post-title"">");
#nullable restore
#line 80 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                                                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                                  
                                    
                                    <p>
                                        Si ud está interesado en esta mascota, puede contactarle a traves de:

                                        <a href=""https://web.whatsapp.com/""><button class=""btn btn-success"">WhatsApp</button></a>
                                       
                                    </p>

                                </div>


                            </div>
                        </div>
                        <aside class=""col-lg-4 tm-aside-col"">
                            <div class=""tm-post-sidebar"">
                                <hr class=""mb-3 tm-hr-primary"">
                                <h2 class=""mb-4 tm-post-title tm-color-primary"">Datos del Dueño</h2>

                                <ul class=""tm-mb-75 pl-5 tm-category-list"">


                                    <li><h6 class=""card-title""><b>Nombre: </b> ");
#nullable restore
#line 103 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                                                          Write(item.Usuarios.Nombres);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></li>\r\n                                    <li><h6 class=\"card-title\"><b>Apellido Paterno: </b>");
#nullable restore
#line 104 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                                                                   Write(item.Usuarios.ApellidoPaterno);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></li>\r\n                                    <li><h6 class=\"card-title\"><b>Apellido Materno: </b>");
#nullable restore
#line 105 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                                                                   Write(item.Usuarios.ApellidoMaterno);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></li>\r\n                                    <li><h6 class=\"card-title\"><b>Edad: </b>");
#nullable restore
#line 106 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                                                       Write(item.Usuarios.FechaNacimiento);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></li>\r\n                                    <li><h6 class=\"card-title\"><b>D.N.I: </b>");
#nullable restore
#line 107 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                                                        Write(item.Usuarios.Dni);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></li>\r\n                                    <li><h6 class=\"card-title\"><b>Teléfono: </b>");
#nullable restore
#line 108 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                                                                           Write(item.Usuarios.Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></li>\r\n\r\n                                </ul>\r\n\r\n\r\n\r\n                            </div>\r\n                        </aside>\r\n                    </div>\r\n");
                WriteLiteral("                    <hr class=\"mb-3 tm-hr-primary\">\r\n                    <h2 class=\"tm-mb-40 tm-post-title tm-color-primary\">Mas fotos</h2>\r\n");
#nullable restore
#line 120 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                     foreach (var item3 in @item.Fotos)
                    {
                              

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 4651, "\"", 4659, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <figure>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "470d89232a8cf00e486263172b83400d19ee39bc18847", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4769, "~/images/", 4769, 9, true);
#nullable restore
#line 125 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
AddHtmlAttributeValue("", 4778, item3.Imagen, 4778, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            </figure>\r\n                        </a>\r\n");
#nullable restore
#line 129 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h5> No se encontro nada</h5>\r\n");
#nullable restore
#line 136 "E:\Brayan\Calidad\red_social_mascotas\red_social_mascotas\Views\Home\Buscar.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <footer class=""row tm-row"">
                <div class=""col-md-6 col-12 tm-color-gray"">

                </div>
                <div class=""col-md-6 col-12 tm-color-gray tm-copyright"">
                    Copyright 2022 calidad UPN
                </div>
            </footer>
        </main>
    </div>
");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
