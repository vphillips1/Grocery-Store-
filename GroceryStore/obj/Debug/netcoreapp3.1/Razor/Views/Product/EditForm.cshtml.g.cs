#pragma checksum "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d9ca8cbfcfc1ccae9c6c11e6be28924ad0e1a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_EditForm), @"mvc.1.0.view", @"/Views/Product/EditForm.cshtml")]
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
#line 1 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\_ViewImports.cshtml"
using GroceryStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\_ViewImports.cshtml"
using GroceryStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d9ca8cbfcfc1ccae9c6c11e6be28924ad0e1a6", @"/Views/Product/EditForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd50d0179ac9bea7de6074dacf685930840d048", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_EditForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/product/edit/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml"
  
    ViewData["Title"] = "EditForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47d9ca8cbfcfc1ccae9c6c11e6be28924ad0e1a64307", async() => {
                WriteLiteral("\r\n\r\n    Name:<input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 173, "\"", 192, 1);
#nullable restore
#line 10 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml"
WriteAttributeValue("", 181, Model.name, 181, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    Description: <input type=\"text\" name=\"description\"");
                BeginWriteAttribute("value", " value=\"", 260, "\"", 286, 1);
#nullable restore
#line 12 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml"
WriteAttributeValue("", 268, Model.description, 268, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    Price:<input type=\"text\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 341, "\"", 361, 1);
#nullable restore
#line 14 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml"
WriteAttributeValue("", 349, Model.price, 349, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    Inventory:<input type=\"text\" name=\"inventory\"");
                BeginWriteAttribute("value", " value=\"", 424, "\"", 448, 1);
#nullable restore
#line 16 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml"
WriteAttributeValue("", 432, Model.inventory, 432, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    Category:<input type=\"text\" name=\"category\"");
                BeginWriteAttribute("value", " value=\"", 509, "\"", 532, 1);
#nullable restore
#line 18 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml"
WriteAttributeValue("", 517, Model.category, 517, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 580, "\"", 597, 1);
#nullable restore
#line 20 "C:\Users\vphillips\dev\GroceryStore\GroceryStore\Views\Product\EditForm.cshtml"
WriteAttributeValue("", 588, Model.id, 588, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n    <input type=\"submit\" />\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
