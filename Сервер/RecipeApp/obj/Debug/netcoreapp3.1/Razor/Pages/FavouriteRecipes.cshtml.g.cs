#pragma checksum "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36a24922477180201656a27043ea2906968b51ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipeApp.Pages.Pages_FavouriteRecipes), @"mvc.1.0.razor-page", @"/Pages/FavouriteRecipes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a24922477180201656a27043ea2906968b51ec", @"/Pages/FavouriteRecipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf5749beb52248b8c81aba9922b4f5aca0a8c3c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FavouriteRecipes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
  
    ViewData["Title"] = "Список любимых рецептов";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 7 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
 foreach (var recipe in Model.recipes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col l4 s12 m7\">\r\n        <div class=\"card\">\r\n            <div class=\"card-image\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 303, "", 328, 1);
#nullable restore
#line 12 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
WriteAttributeValue("", 308, recipe.Recipe.Image, 308, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <span class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
                                    Write(recipe.Recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"card-content\">\r\n                <p>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
               Write(recipe.Recipe.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"card-action\">\r\n                <a");
            BeginWriteAttribute("href", " href=", 628, "", 689, 1);
#nullable restore
#line 21 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
WriteAttributeValue("", 634, Url.Page("/Recipe_ingredient", new { id = recipe.id }), 634, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Подробное описание рецепта</a>\r\n            </div>\r\n            <div class=\"card-action\">\r\n                <a");
            BeginWriteAttribute("href", " href=", 799, "", 854, 1);
#nullable restore
#line 24 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
WriteAttributeValue("", 805, Url.Page("/UpdateRecipe", new { id = recipe.id}), 805, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Редактировать рецепт</a>\r\n            </div>\r\n            <div class=\"card-action\">\r\n                <a");
            BeginWriteAttribute("href", " href=", 958, "", 1013, 1);
#nullable restore
#line 27 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
WriteAttributeValue("", 964, Url.Page("/DeleteRecipe", new { id = recipe.id}), 964, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Удалить рецепт</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 31 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\FavouriteRecipes.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeApp.Pages.FavouriteRecipesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeApp.Pages.FavouriteRecipesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeApp.Pages.FavouriteRecipesModel>)PageContext?.ViewData;
        public RecipeApp.Pages.FavouriteRecipesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
