#pragma checksum "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c80781f84022d38b6cb0bf25a6b90fde2e307046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\_ViewImports.cshtml"
using Aspi.Net_EntityFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\_ViewImports.cshtml"
using Aspi.Net_EntityFramework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\_ViewImports.cshtml"
using Aspi.Net_EntityFramework.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c80781f84022d38b6cb0bf25a6b90fde2e307046", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb8c34a43dbed80b2fafe329e8cb0837424828c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- Start Banner Hero -->
    <div class=""banner-wrapper bg-light"">
        <div id=""index_banner"" class=""banner-vertical-center-index container-fluid pt-5"">

            <!-- Start slider -->
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-bs-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""0"" class=""active""></li>
                    <li data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""1""></li>
                    <li data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
");
#nullable restore
#line 18 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
                     foreach (var item in Model.SliderDetails)
                    {
                        var activeSlide = "active";
                        if(item != Model.SliderDetails.First())
                        {
                            activeSlide = "";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1118, "\"", 1153, 3);
            WriteAttributeValue("", 1126, "carousel-item", 1126, 13, true);
#nullable restore
#line 25 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1139, activeSlide, 1140, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1152, "", 1153, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">

                            <div class=""py-5 row d-flex align-items-center"">
                                <div class=""banner-content col-lg-8 col-8 offset-2 m-lg-auto text-left py-5 pb-5"">
                                    <h1 class=""banner-heading h1 text-secondary display-3 mb-0 pb-5 mx-0 px-0 light-300 typo-space-line"">
                                        ");
#nullable restore
#line 30 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
                                   Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h1>\r\n                                    <p class=\"banner-body text-muted py-3 mx-0 px-0\">\r\n                                        ");
#nullable restore
#line 33 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>
                                    <a class=""banner-button btn rounded-pill btn-outline-primary btn-lg px-4"" href=""#"" role=""button"">Get Started</a>
                                </div>
                            </div>

                        </div>
");
#nullable restore
#line 40 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <a class=""carousel-control-prev text-decoration-none"" href=""#carouselExampleIndicators"" role=""button"" data-bs-slide=""prev"">
                    <i class='bx bx-chevron-left'></i>
                    <span class=""visually-hidden"">Previous</span>
                </a>
                <a class=""carousel-control-next text-decoration-none"" href=""#carouselExampleIndicators"" role=""button"" data-bs-slide=""next"">
                    <i class='bx bx-chevron-right'></i>
                    <span class=""visually-hidden"">Next</span>
                </a>
            </div>
            <!-- End slider -->

        </div>
    </div>
    <!-- End Banner Hero -->



    <!-- Start Service -->
    <section class=""service-wrapper py-3"">
        <div class=""container-fluid pb-3"">
            <div class=""row"">
                <h2 class=""h2 text-center col-12 py-5 semi-bold-600"">Services</h2>
                <div class=""service-header col-2 col-lg-3 text-end light-300"">");
            WriteLiteral(@"
                    <i class='bx bx-gift h3 mt-1'></i>
                </div>
                <div class=""service-heading col-10 col-lg-9 text-start float-end light-300"">
                    <h2 class=""h3 pb-4 typo-space-line"">Make Success for future</h2>
                </div>
            </div>
            <p class=""service-footer col-10 offset-2 col-lg-9 offset-lg-3 text-start pb-3 text-muted px-2"">
                You are free to use this template for your commercial or business websites. You are not allowed to re-distribute this template ZIP file on any template collection websites. It is too easy to illegally copy and repost this template.
            </p>
        </div>

        <div class=""service-tag py-5 bg-secondary"">
            <div class=""col-md-12"">
                <ul class=""nav d-flex justify-content-center"">
                    <li class=""nav-item mx-lg-4"">
                        <a class=""filter-btn nav-link btn-outline-primary active shadow rounded-pill text-light px-4 lig");
            WriteLiteral(@"ht-300"" href=""#"" data-filter="".project"">All</a>
                    </li>
                    <li class=""nav-item mx-lg-4"">
                        <a class=""filter-btn nav-link btn-outline-primary rounded-pill text-light px-4 light-300"" href=""#"" data-filter="".graphic"">Graphics</a>
                    </li>
                    <li class=""filter-btn nav-item mx-lg-4"">
                        <a class=""filter-btn nav-link btn-outline-primary rounded-pill text-light px-4 light-300"" href=""#"" data-filter="".ui"">UI/UX</a>
                    </li>
                    <li class=""nav-item mx-lg-4"">
                        <a class=""filter-btn nav-link btn-outline-primary rounded-pill text-light px-4 light-300"" href=""#"" data-filter="".branding"">Branding</a>
                    </li>
                </ul>
            </div>
        </div>

    </section>

    <section class=""container overflow-hidden py-5"">
        <div class=""row gx-5 gx-sm-3 gx-lg-5 gy-lg-5 gy-3 pb-3 projects"">

            <!-- Sta");
            WriteLiteral(@"rt Recent Work -->
            <div class=""col-xl-3 col-md-4 col-sm-6 project ui branding"">
                <a href=""#"" class=""service-work card border-0 text-white shadow-sm overflow-hidden mx-5 m-sm-0"">
                    <img class=""service card-img"" src=""./assets/img/services-01.jpg"" alt=""Card image"">
                    <div class=""service-work-vertical card-img-overlay d-flex align-items-end"">
                        <div class=""service-work-content text-left text-light"">
                            <span class=""btn btn-outline-light rounded-pill mb-lg-3 px-lg-4 light-300"">UI/UX design</span>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing</p>
                        </div>
                    </div>
                </a>
            </div><!-- End Recent Work -->

            <!-- Start Recent Work -->
            <div class=""col-xl-3 col-md-4 col-sm-6 project ui graphic"">
                <a href=""#"" class=""service-work card border-0 t");
            WriteLiteral(@"ext-white shadow-sm overflow-hidden mx-5 m-sm-0"">
                    <img class=""card-img"" src=""./assets/img/services-02.jpg"" alt=""Card image"">
                    <div class=""service-work-vertical card-img-overlay d-flex align-items-end"">
                        <div class=""service-work-content text-left text-light"">
                            <span class=""btn btn-outline-light rounded-pill mb-lg-3 px-lg-4 light-300"">Social Media</span>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing</p>
                        </div>
                    </div>
                </a>
            </div><!-- End Recent Work -->

            <!-- Start Recent Work -->
            <div class=""col-xl-3 col-md-4 col-sm-6 project branding"">
                <a href=""#"" class=""service-work card border-0 text-white shadow-sm overflow-hidden mx-5 m-sm-0"">
                    <img class=""card-img"" src=""./assets/img/services-03.jpg"" alt=""Card image"">
                    ");
            WriteLiteral(@"<div class=""service-work-vertical card-img-overlay d-flex align-items-end"">
                        <div class=""service-work-content text-left text-light"">
                            <span class=""btn btn-outline-light rounded-pill mb-lg-3 px-lg-4 light-300"">Marketing</span>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing</p>
                        </div>
                    </div>
                </a>
            </div><!-- End Recent Work -->

            <!-- Start Recent Work -->
            <div class=""col-xl-3 col-md-4 col-sm-6 project ui graphic"">
                <a href=""#"" class=""service-work card border-0 text-white shadow-sm overflow-hidden mx-5 m-sm-0"">
                    <img class=""card-img"" src=""./assets/img/services-04.jpg"" alt=""Card image"">
                    <div class=""service-work-vertical card-img-overlay d-flex align-items-end"">
                        <div class=""service-work-content text-left text-light"">
          ");
            WriteLiteral(@"                  <span class=""btn btn-outline-light rounded-pill mb-lg-3 px-lg-4 light-300"">Graphic</span>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing</p>
                        </div>
                    </div>
                </a>
            </div><!-- End Recent Work -->

            <!-- Start Recent Work -->
            <div class=""col-xl-3 col-md-4 col-sm-6 project ui graphic"">
                <a href=""#"" class=""service-work card border-0 text-white shadow-sm overflow-hidden mx-5 m-sm-0"">
                    <img class=""card-img"" src=""./assets/img/services-05.jpg"" alt=""Card image"">
                    <div class=""service-work-vertical card-img-overlay d-flex align-items-end"">
                        <div class=""service-work-content text-left text-light"">
                            <span class=""btn btn-outline-light rounded-pill mb-lg-3 px-lg-4 light-300"">Digtal Marketing</span>
                            <p class=""card-text"">Lor");
            WriteLiteral(@"em ipsum dolor sit amet, consectetur adipisicing</p>
                        </div>
                    </div>
                </a>
            </div><!-- End Recent Work -->

            <!-- Start Recent Work -->
            <div class=""col-xl-3 col-md-4 col-sm-6 project branding"">
                <a href=""#"" class=""service-work card border-0 text-white shadow-sm overflow-hidden mx-5 m-sm-0"">
                    <img class=""card-img"" src=""./assets/img/services-06.jpg"" alt=""Card image"">
                    <div class=""service-work-vertical card-img-overlay d-flex align-items-end"">
                        <div class=""service-work-content text-left text-light"">
                            <span class=""btn btn-outline-light rounded-pill mb-lg-3 px-lg-4 light-300"">Market Research</span>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing</p>
                        </div>
                    </div>
                </a>
            </div><!-- End R");
            WriteLiteral(@"ecent Work -->

            <!-- Start Recent Work -->
            <div class=""col-xl-3 col-md-4 col-sm-6 project branding"">
                <a href=""#"" class=""service-work card border-0 text-white shadow-sm overflow-hidden mx-5 m-sm-0"">
                    <img class=""card-img"" src=""./assets/img/services-07.jpg"" alt=""Card image"">
                    <div class=""service-work-vertical card-img-overlay d-flex align-items-end"">
                        <div class=""service-work-content text-left text-light"">
                            <span class=""btn btn-outline-light rounded-pill mb-lg-3 px-lg-4 light-300"">Business</span>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing</p>
                        </div>
                    </div>
                </a>
            </div><!-- End Recent Work -->

            <!-- Start Recent Work -->
            <div class=""col-xl-3 col-md-4 col-sm-6 project ui graphic branding"">
                <a href=""#"" cla");
            WriteLiteral(@"ss=""service-work card border-0 text-white shadow-sm overflow-hidden mx-5 m-sm-0"">
                    <img class=""card-img"" src=""./assets/img/services-08.jpg"" alt=""Card image"">
                    <div class=""service-work-vertical card-img-overlay d-flex align-items-end"">
                        <div class=""service-work-content text-left text-light"">
                            <span class=""btn btn-outline-light rounded-pill mb-lg-3 px-lg-4 light-300"">Branding</span>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing</p>
                        </div>
                    </div>
                </a>
            </div><!-- End Recent Work -->

        </div>
    </section>
    <!-- End Service -->






    <!-- Start View Work -->
    <section class=""bg-secondary"">
        <div class=""container py-5"">
            <div class=""row d-flex justify-content-center text-center"">
                <div class=""col-lg-2 col-12 text-light align-items");
            WriteLiteral(@"-center"">
                    <i class='display-1 bx bxs-box bx-lg'></i>
                </div>
                <div class=""col-lg-7 col-12 text-light pt-2"">
                    <h3 class=""h4 light-300"">Great transformations successful</h3>
                    <p class=""light-300"">Quis ipsum suspendisse ultrices gravida.</p>
                </div>
                <div class=""col-lg-3 col-12 pt-4"">
                    <a href=""#"" class=""btn btn-primary rounded-pill btn-block shadow px-4 py-2"">View Our Work</a>
                </div>
            </div>
        </div>
    </section>
    <!-- End View Work -->

    <!-- Start Recent Work -->
    <section class=""py-5 mb-5"">
        <div class=""container"">
            <div class=""recent-work-header row text-center pb-5"">
                <h2 class=""col-md-6 m-auto h2 semi-bold-600 py-5"">Recent Works</h2>
            </div>
            <div class=""row gy-5 g-lg-5 mb-4"">

");
#nullable restore
#line 241 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
                 foreach (var item in Model.Works)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- Start Recent Work -->
                    <div class=""col-md-4 mb-3"">
                        <a href=""#"" class=""recent-work card border-0 shadow-lg overflow-hidden"">
                            <img class=""recent-work-img card-img""");
            BeginWriteAttribute("src", " src=\"", 13581, "\"", 13611, 2);
            WriteAttributeValue("", 13587, "./assets/img/", 13587, 13, true);
#nullable restore
#line 246 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
WriteAttributeValue("", 13600, item.Image, 13600, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Card image"">
                            <div class=""recent-work-vertical card-img-overlay d-flex align-items-end"">
                                <div class=""recent-work-content text-start mb-3 ml-3 text-dark"">
                                    <h3 class=""card-title light-300"">");
#nullable restore
#line 249 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
                                                                Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 250 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </a>\r\n                    </div><!-- End Recent Work -->\r\n");
#nullable restore
#line 255 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-EntityFrameWork\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- End Recent Work -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
