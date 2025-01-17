#pragma checksum "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb782d9e60ac43fbd364c7a7286336c228ab48b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Cart.cshtml", typeof(AspNetCore.Views_Order_Cart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb782d9e60ac43fbd364c7a7286336c228ab48b1", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb18ec7718e9e031ec81c603586868f77986d15", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sample.Models.RefreshCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DataPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(110, 190, true);
            WriteLiteral("\n<h2>Cart</h2>\n\n<table>\n    <thead>\n        <tr>\n            <th>Item</th>\n            <th>Quantity</th>\n            <th class=\"text-right\">Price</th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 19 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
         foreach (var item in @Model.GetCart().Cart.GetItems)
        {

#line default
#line hidden
            BeginContext(372, 78, true);
            WriteLiteral("            <tr>                       \n                <td class=\"text-left\">");
            EndContext();
            BeginContext(451, 17, false);
#line 22 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
                                 Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(468, 46, true);
            WriteLiteral("</td>\n                <td class=\"text-center\">");
            EndContext();
            BeginContext(515, 13, false);
#line 23 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(528, 45, true);
            WriteLiteral("</td>\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(574, 32, false);
#line 24 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
                                  Write(item.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(606, 66, true);
            WriteLiteral("</td>\n                <td class=\"text-right\">\n                    ");
            EndContext();
            BeginContext(674, 50, false);
#line 26 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
                Write((item.Quantity * item.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(725, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(789, 350, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55a24a5352a4b00bb8e261e364a8634", async() => {
                BeginContext(837, 62, true);
                WriteLiteral("\n                        <input type=\"hidden\" name=\"ProductID\"");
                EndContext();
                BeginWriteAttribute("value", "\n                               value=\"", 899, "\"", 961, 1);
#line 31 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
WriteAttributeValue("", 938, item.Product.ProductID, 938, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(962, 170, true);
                WriteLiteral(" />\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">\n                            Remove\n                        </button>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1139, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 38 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
        }

#line default
#line hidden
            BeginContext(1190, 149, true);
            WriteLiteral("    </tbody>\n    <tfoot>\n        <tr>\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\n            <td class=\"text-right\">\n                ");
            EndContext();
            BeginContext(1340, 49, false);
#line 44 "C:\Users\Lenovo\Downloads\COMP229-Estore-master (1)\COMP229-Estore-master\Web Application Project - Connected to Database\Sample\Views\Order\Cart.cshtml"
           Write(Model.GetCart().Cart.GetTotalCost().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 86, true);
            WriteLiteral("\n            </td>\n        </tr>\n    </tfoot>\n</table>\n\n<div class=\"text-center\">\n    ");
            EndContext();
            BeginContext(1475, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b168855de1e42b3a338aff1668e97e9", async() => {
                BeginContext(1544, 22, true);
                WriteLiteral("\n        Checkout\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1570, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(1575, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "073089ffcbb94e19a63aa0c53262503b", async() => {
                BeginContext(1646, 43, true);
                WriteLiteral("\n           &nbsp;&nbsp;Add more Items\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1693, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sample.Models.RefreshCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
