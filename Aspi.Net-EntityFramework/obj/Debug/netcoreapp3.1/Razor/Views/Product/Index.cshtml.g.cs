#pragma checksum "C:\Users\ESQIN\source\repos\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "073a4add8431d28d6645fa7ad576243ad4b2144b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\ESQIN\source\repos\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\_ViewImports.cshtml"
using Aspi.Net_EntityFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESQIN\source\repos\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\_ViewImports.cshtml"
using Aspi.Net_EntityFramework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESQIN\source\repos\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\_ViewImports.cshtml"
using Aspi.Net_EntityFramework.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"073a4add8431d28d6645fa7ad576243ad4b2144b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb8c34a43dbed80b2fafe329e8cb0837424828c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ESQIN\source\repos\Aspi.Net-EntityFramework\Aspi.Net-EntityFramework\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";
    //Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""product-list-title"">
        <div class=""container py-4"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <h1>Product List</h1>
                    <i class=""text-muted"">Where flowers are our inspiration</i>
                </div>
            </div>
        </div>
    </section>
    <section id=""product-list"">
        <div class=""container"">
            <div class=""row"">

            </div>
        </div>
    </section>
</main>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick.min.js"" integrity=""sha512-XtmMtDEcNz2j7ekrtHvOVR4iwwaD6o/FUJe6+Zq+HgcCsk3kj4uSQQR8weQ2QVj1o0Pk6PwYLohm206ZzNfubg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
");
            }
            );
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