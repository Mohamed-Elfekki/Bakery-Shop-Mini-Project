#pragma checksum "D:\Final Projects\BakeryShop\BakeryShop\Pages\OrderSucess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf98f3c89126aceaf9a8e66aa80e18f65a8ff2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BakeryShop.Pages.Pages_OrderSucess), @"mvc.1.0.razor-page", @"/Pages/OrderSucess.cshtml")]
namespace BakeryShop.Pages
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
#line 1 "D:\Final Projects\BakeryShop\BakeryShop\Pages\_ViewImports.cshtml"
using BakeryShop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf98f3c89126aceaf9a8e66aa80e18f65a8ff2c", @"/Pages/OrderSucess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1946d02452e2e754319dca239e3fd18eed261551", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_OrderSucess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ol id=orderProccer>
    <li>
        <span class=""step-number"">1</span>Choose item!
    </li>
    <li>
        <span class=""step-number"">2</span>Details and Submit
    </li>
    <li class=""current"">
        <span class=""step-number"">3</span>Reciept
    </li>
</ol>
<h1> Ordered Confirmation!</h1>
<div class=""border-success"">
    <h2>Than you for Your Order!</h2>
    <p>
        We are proccessing in your order, will sent you a confirmation email soon!
        <br />
        Thanks for your time!
    </p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BakeryShop.Pages.OrderSucessModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BakeryShop.Pages.OrderSucessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BakeryShop.Pages.OrderSucessModel>)PageContext?.ViewData;
        public BakeryShop.Pages.OrderSucessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
