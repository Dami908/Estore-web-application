#pragma checksum "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Home\DataPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a87e428484eba0a5ac4c0f1b846dd068fb7a8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DataPage), @"mvc.1.0.view", @"/Views/Home/DataPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DataPage.cshtml", typeof(AspNetCore.Views_Home_DataPage))]
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
#line 1 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\_ViewImports.cshtml"
using Sample;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\_ViewImports.cshtml"
using Sample.Models;

#line default
#line hidden
#line 1 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Home\DataPage.cshtml"
using Sample.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a87e428484eba0a5ac4c0f1b846dd068fb7a8d", @"/Views/Home/DataPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb18ec7718e9e031ec81c603586868f77986d15", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DataPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFProductRepository>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Home\DataPage.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(82, 23, true);
            WriteLiteral("<!Doctype html>\n<html>\n");
            EndContext();
            BeginContext(105, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1158fab27ce04a119d2739c3089a7857", async() => {
                BeginContext(111, 88, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Data Page</title>\n");
                EndContext();
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
            EndContext();
            BeginContext(206, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(207, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "653b0374d5ec42549c5ca31437cb7291", async() => {
                BeginContext(213, 24, true);
                WriteLiteral("\n    <h2>Data Page</h2>\n");
                EndContext();
#line 14 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Home\DataPage.cshtml"
     foreach (var item in Model.Products)
    {
        

#line default
#line hidden
                BeginContext(294, 33, false);
#line 16 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Home\DataPage.cshtml"
   Write(Html.Partial("ProductData", item));

#line default
#line hidden
                EndContext();
#line 16 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Home\DataPage.cshtml"
                                          
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(341, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFProductRepository> Html { get; private set; }
    }
}
#pragma warning restore 1591
