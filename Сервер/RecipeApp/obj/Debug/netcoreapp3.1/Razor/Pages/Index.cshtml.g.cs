#pragma checksum "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ed5a53a1aaa0107ca0051beee9da126f311d0e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipeApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace RecipeApp.Pages
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
#line 1 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\_ViewImports.cshtml"
using RecipeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\_ViewImports.cshtml"
using RecipeApp.Business_Logic.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed5a53a1aaa0107ca0051beee9da126f311d0e6", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2168cc57cc7e46699c9829db969e614cf87787b4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "AddRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Список рецептов";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed5a53a1aaa0107ca0051beee9da126f311d0e63971", async() => {
                WriteLiteral("Добавить рецепт");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
 foreach (var recipe in Model.recipes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col l4 s12 m7\">\r\n        <div class=\"card\">\r\n            <div class=\"card-image\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 338, "", 356, 1);
#nullable restore
#line 14 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
WriteAttributeValue("", 343, recipe.Image, 343, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <span class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                                    Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"card-content\">\r\n                <p>\r\n                    ");
#nullable restore
#line 19 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
               Write(recipe.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"card-action\">\r\n                <a");
            BeginWriteAttribute("href", " href=", 642, "", 703, 1);
#nullable restore
#line 23 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
WriteAttributeValue("", 648, Url.Page("/Recipe_ingredient", new { id = recipe.id }), 648, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Подробное описание рецепта</a>\r\n            </div>\r\n            <div class=\"card-action\">\r\n                <a");
            BeginWriteAttribute("href", " href=", 813, "", 868, 1);
#nullable restore
#line 26 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
WriteAttributeValue("", 819, Url.Page("/UpdateRecipe", new { id = recipe.id}), 819, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Редактировать рецепт</a>\r\n            </div>\r\n            <div class=\"card-action\">\r\n                <a");
            BeginWriteAttribute("href", " href=", 972, "", 1027, 1);
#nullable restore
#line 29 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
WriteAttributeValue("", 978, Url.Page("/DeleteRecipe", new { id = recipe.id}), 978, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Удалить рецепт</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeApp.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeApp.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeApp.Pages.IndexModel>)PageContext?.ViewData;
        public RecipeApp.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
