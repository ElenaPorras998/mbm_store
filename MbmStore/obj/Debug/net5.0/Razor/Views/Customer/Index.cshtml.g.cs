#pragma checksum "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8daff5c7616d0baa9564f7f9f96d531c7eee85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8daff5c7616d0baa9564f7f9f96d531c7eee85", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df10ef731621db43bb1562b1b1b64f0736f7561", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Customers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8daff5c7616d0baa9564f7f9f96d531c7eee854160", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>Customers</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
 foreach (var customer in ViewBag.Customers)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"customer-label\">\r\n        <p><strong>Name:</strong><span> ");
#nullable restore
#line 13 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
                                   Write(customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
                                                       Write(customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span> (");
#nullable restore
#line 13 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
                                                                                        Write(string.Join(", ", customer.PhoneNumbers));

#line default
#line hidden
#nullable disable
            WriteLiteral(";)</span></p>\r\n        <p><strong>Address:</strong><span> ");
#nullable restore
#line 14 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
                                      Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        <p><strong>City:</strong><span> ");
#nullable restore
#line 15 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
                                   Write(customer.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 15 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
                                                  Write(customer.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        <p>");
#nullable restore
#line 16 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
      Write(customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
                          Write(customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is ");
#nullable restore
#line 16 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
                                                Write(customer.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" years old.</p>\r\n    </div>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 20 "C:\Users\Elena\OneDrive\WEB DEV\Backend\MbmStore_Mandatory_Assignment\MbmStore\Views\Customer\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
