#pragma checksum "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3d39e7fb5a046cf60f5760eb968a026f04f5929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CategoryPage), @"mvc.1.0.view", @"/Views/Home/CategoryPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CategoryPage.cshtml", typeof(AspNetCore.Views_Home_CategoryPage))]
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
#line 1 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/_ViewImports.cshtml"
using ProductsAndCategories;

#line default
#line hidden
#line 2 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/_ViewImports.cshtml"
using ProductsAndCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d39e7fb5a046cf60f5760eb968a026f04f5929", @"/Views/Home/CategoryPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3772dd1aab0a113eef9daa4fd8f7fdb8a407ef7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CategoryPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryAndProductsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 154, true);
            WriteLiteral("<div class=\"container\">\n        <a class=\"float-right\" href=\"/categories\">Home</a>\n        <h1 style=\"margin-bottom: 40px;\" class=\"display-2 text-center\">");
            EndContext();
            BeginContext(192, 22, false);
#line 4 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                                                                  Write(Model.TheCategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(214, 118, true);
            WriteLiteral("</h1>\n        <div class=\"row\">\n            <div class=\"col\">\n                <h3>Products:</h3>\n                <ul>\n");
            EndContext();
#line 9 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                     foreach(Association association in Model.TheCategory.Products)
                    {

#line default
#line hidden
            BeginContext(438, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(467, 24, false);
#line 11 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                       Write(association.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(491, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 12 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(519, 41, true);
            WriteLiteral("                </ul>\n            </div>\n");
            EndContext();
#line 15 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                          
                            if(Model.NonassociatedProducts.Count != 0)
                            {

#line default
#line hidden
            BeginContext(688, 144, true);
            WriteLiteral("                                <div class=\"col\">\n                                    <h4>Add Product:</h4>\n                                    ");
            EndContext();
            BeginContext(832, 844, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d39e7fb5a046cf60f5760eb968a026f04f59298037", async() => {
                BeginContext(917, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(958, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3d39e7fb5a046cf60f5760eb968a026f04f59298453", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 21 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewAssociation.CategoryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 21 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                                                                                                                 WriteLiteral(Model.TheCategory.CategoryId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1074, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(1115, 398, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d39e7fb5a046cf60f5760eb968a026f04f592911189", async() => {
                    BeginContext(1179, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 23 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                                         foreach (Product product in Model.NonassociatedProducts)
                                        {

#line default
#line hidden
                    BeginContext(1320, 44, true);
                    WriteLiteral("                                            ");
                    EndContext();
                    BeginContext(1364, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d39e7fb5a046cf60f5760eb968a026f04f592912047", async() => {
                        BeginContext(1400, 12, false);
#line 25 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                                                                          Write(product.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 25 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                                               WriteLiteral(product.ProductId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1421, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 26 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                                        }

#line default
#line hidden
                    BeginContext(1464, 40, true);
                    WriteLiteral("                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 22 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewAssociation.ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1513, 156, true);
                WriteLiteral("  \n                                    <button style=\"margin-top: 20px;\" class=\"btn btn-primary\" type=\"submit\">Add</button>\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1676, 37, true);
            WriteLiteral(" \n                            </div>\n");
            EndContext();
#line 31 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1806, 161, true);
            WriteLiteral("                                <div class=\"col\">\n                                    <h4>No more products to add :(</h4>\n                                </div>\n");
            EndContext();
#line 37 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/ProductsAndCategories/Views/Home/CategoryPage.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2023, 25, true);
            WriteLiteral("        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryAndProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
