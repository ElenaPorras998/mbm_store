#pragma checksum "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0ee459255307c5208d7fb2896f0fa78a6b40185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSummaryMovie), @"mvc.1.0.view", @"/Views/Shared/_ProductSummaryMovie.cshtml")]
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
#line 2 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
using MbmStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0ee459255307c5208d7fb2896f0fa78a6b40185", @"/Views/Shared/_ProductSummaryMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df10ef731621db43bb1562b1b1b64f0736f7561", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductSummaryMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MbmStore.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <p><img");
            BeginWriteAttribute("src", " src=\"", 150, "\"", 184, 2);
            WriteAttributeValue("", 156, "/Images/", 156, 8, true);
#nullable restore
#line 7 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
WriteAttributeValue("", 164, Model.ImageFileName, 164, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 185, "\"", 203, 1);
#nullable restore
#line 7 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
WriteAttributeValue("", 191, Model.Title, 191, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></p>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <p>Title: ");
#nullable restore
#line 10 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Price: ");
#nullable restore
#line 11 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
             Write(String.Format("{0:0.00}", Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Director: ");
#nullable restore
#line 12 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
                Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
   Write(await Html.PartialAsync("_AddToCartButton", (Product)Model));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MbmStore.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
