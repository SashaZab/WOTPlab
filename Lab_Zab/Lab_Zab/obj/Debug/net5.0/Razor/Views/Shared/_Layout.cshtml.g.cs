#pragma checksum "C:\Users\VnElite\source\repos\Lab_Zab\Lab_Zab\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3623df5e401642b4ec897cbfe82c4c5896b95e73"
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
#line 1 "C:\Users\VnElite\source\repos\Lab_Zab\Lab_Zab\Views\_ViewImports.cshtml"
using Lab_Zab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VnElite\source\repos\Lab_Zab\Lab_Zab\Views\_ViewImports.cshtml"
using Lab_Zab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3623df5e401642b4ec897cbfe82c4c5896b95e73", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d2e318924773499e282cd4cbcbc5142040769b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3623df5e401642b4ec897cbfe82c4c5896b95e734158", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n    <title>FlexStart Bootstrap Template - Index</title>\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 217, "\"", 227, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"description\">\r\n\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 261, "\"", 271, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

    <!-- Favicons -->
    <link href=""assets/img/favicon.png"" rel=""icon"">
    <link href=""assets/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Nunito:300,300i,400,400i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""assets/vendor/aos/aos.css"" rel=""stylesheet"">
    <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"">
    <link href=""assets/vendor/glightbox/css/glightbox.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/remixicon/remixicon.css"" rel=""stylesheet"">
    <link href=""assets/vendor/swiper/swiper-bundle.min.css"" rel=""stylesheet"">

    <!-- Template Main CSS File -->
    <link href=""assets/css/style.css"" rel=""stylesheet"">

    <!-- =");
                WriteLiteral(@"======================================================
    * Template Name: FlexStart - v1.9.0
    * Template URL: https://bootstrapmade.com/flexstart-bootstrap-startup-template/
    * Author: BootstrapMade.com
    * License: https://bootstrapmade.com/license/
    ======================================================== -->
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3623df5e401642b4ec897cbfe82c4c5896b95e737096", async() => {
                WriteLiteral(@"

    <!-- ======= Header ======= -->
    <header id=""header"" class=""header fixed-top"">
        <div class=""container-fluid container-xl d-flex align-items-center justify-content-between"">

            <a href=""index.html"" class=""logo d-flex align-items-center"">
                <img src=""assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 1959, "\"", 1965, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <span>FlexStart</span>
            </a>

            <nav id=""navbar"" class=""navbar"">
                <ul>
                    <li><a class=""nav-link scrollto active"" href=""#hero"">Home</a></li>
                    <li><a class=""nav-link scrollto"" href=""#about"">About</a></li>
                    <li><a class=""nav-link scrollto"" href=""#services"">Services</a></li>
                    <li><a class=""nav-link scrollto"" href=""#portfolio"">Portfolio</a></li>
                    <li><a class=""nav-link scrollto"" href=""#team"">Team</a></li>
                    <li><a href=""blog.html"">Blog</a></li>
                    <li class=""dropdown"">
                        <a href=""#""><span>Drop Down</span> <i class=""bi bi-chevron-down""></i></a>
                        <ul>
                            <li><a href=""#"">Drop Down 1</a></li>
                            <li class=""dropdown"">
                                <a href=""#""><span>Deep Drop Down</span> <i class=""bi bi-chevron-right""></i></a>
");
                WriteLiteral(@"                                <ul>
                                    <li><a href=""#"">Deep Drop Down 1</a></li>
                                    <li><a href=""#"">Deep Drop Down 2</a></li>
                                    <li><a href=""#"">Deep Drop Down 3</a></li>
                                    <li><a href=""#"">Deep Drop Down 4</a></li>
                                    <li><a href=""#"">Deep Drop Down 5</a></li>
                                </ul>
                            </li>
                            <li><a href=""#"">Drop Down 2</a></li>
                            <li><a href=""#"">Drop Down 3</a></li>
                            <li><a href=""#"">Drop Down 4</a></li>
                        </ul>
                    </li>
                    <li><a class=""nav-link scrollto"" href=""#contact"">Contact</a></li>
                    <li><a class=""getstarted scrollto"" href=""#about"">Get Started</a></li>
                </ul>
                <i class=""bi bi-list mobile-nav-toggle""></i>");
                WriteLiteral("\r\n            </nav><!-- .navbar -->\r\n\r\n        </div>\r\n    </header><!-- End Header -->\r\n    ");
#nullable restore
#line 84 "C:\Users\VnElite\source\repos\Lab_Zab\Lab_Zab\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- ======= Footer ======= -->
    <footer id=""footer"" class=""footer"">

        <div class=""footer-newsletter"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-12 text-center"">
                        <h4>Our Newsletter</h4>
                        <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>
                    </div>
                    <div class=""col-lg-6"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3623df5e401642b4ec897cbfe82c4c5896b95e7310870", async() => {
                    WriteLiteral("\r\n                            <input type=\"email\" name=\"email\"><input type=\"submit\" value=\"Subscribe\">\r\n                        ");
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
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>

        <div class=""footer-top"">
            <div class=""container"">
                <div class=""row gy-4"">
                    <div class=""col-lg-5 col-md-12 footer-info"">
                        <a href=""index.html"" class=""logo d-flex align-items-center"">
                            <img src=""assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 5223, "\"", 5229, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <span>FlexStart</span>
                        </a>
                        <p>Cras fermentum odio eu feugiat lide par naso tierra. Justo eget nada terra videa magna derita valies darta donna mare fermentum iaculis eu non diam phasellus.</p>
                        <div class=""social-links mt-3"">
                            <a href=""#"" class=""twitter""><i class=""bi bi-twitter""></i></a>
                            <a href=""#"" class=""facebook""><i class=""bi bi-facebook""></i></a>
                            <a href=""#"" class=""instagram""><i class=""bi bi-instagram""></i></a>
                            <a href=""#"" class=""linkedin""><i class=""bi bi-linkedin""></i></a>
                        </div>
                    </div>

                    <div class=""col-lg-2 col-6 footer-links"">
                        <h4>Useful Links</h4>
                        <ul>
                            <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Home</a></li>
                      ");
                WriteLiteral(@"      <li><i class=""bi bi-chevron-right""></i> <a href=""#"">About us</a></li>
                            <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Services</a></li>
                            <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Terms of service</a></li>
                            <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Privacy policy</a></li>
                        </ul>
                    </div>

                    <div class=""col-lg-2 col-6 footer-links"">
                        <h4>Our Services</h4>
                        <ul>
                            <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Web Design</a></li>
                            <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Web Development</a></li>
                            <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Product Management</a></li>
                            <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Marketing</a></li>
                   ");
                WriteLiteral(@"         <li><i class=""bi bi-chevron-right""></i> <a href=""#"">Graphic Design</a></li>
                        </ul>
                    </div>

                    <div class=""col-lg-3 col-md-12 footer-contact text-center text-md-start"">
                        <h4>Contact Us</h4>
                        <p>
                            A108 Adam Street <br>
                            New York, NY 535022<br>
                            United States <br><br>
                            <strong>Phone:</strong> +1 5589 55488 55<br>
                            <strong>Email:</strong> info@example.com<br>
                        </p>

                    </div>

                </div>
            </div>
        </div>

        <div class=""container"">
            <div class=""copyright"">
                &copy; Copyright <strong><span>FlexStart</span></strong>. All Rights Reserved
            </div>
            <div class=""credits"">
                <!-- All the links in the footer should rema");
                WriteLiteral(@"in intact. -->
                <!-- You can delete the links only if you purchased the pro version. -->
                <!-- Licensing information: https://bootstrapmade.com/license/ -->
                <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/flexstart-bootstrap-startup-template/ -->
                Designed by <a href=""https://bootstrapmade.com/"">BootstrapMade</a>
            </div>
        </div>
    </footer><!-- End Footer -->
    ");
#nullable restore
#line 173 "C:\Users\VnElite\source\repos\Lab_Zab\Lab_Zab\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


    <!-- Vendor JS Files -->
    <script src=""assets/vendor/purecounter/purecounter.js""></script>
    <script src=""assets/vendor/aos/aos.js""></script>
    <script src=""assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/vendor/glightbox/js/glightbox.min.js""></script>
    <script src=""assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
    <script src=""assets/vendor/swiper/swiper-bundle.min.js""></script>
    <script src=""assets/vendor/php-email-form/validate.js""></script>

    <!-- Template Main JS File -->
    <script src=""assets/js/main.js""></script>
    ");
#nullable restore
#line 187 "C:\Users\VnElite\source\repos\Lab_Zab\Lab_Zab\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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