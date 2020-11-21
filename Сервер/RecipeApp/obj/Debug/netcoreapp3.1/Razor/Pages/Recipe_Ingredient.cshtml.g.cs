#pragma checksum "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf81afede9b8c40083dcaaebeff2a78be3bffadf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipeApp.Pages.Pages_Recipe_Ingredient), @"mvc.1.0.razor-page", @"/Pages/Recipe_Ingredient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf81afede9b8c40083dcaaebeff2a78be3bffadf", @"/Pages/Recipe_Ingredient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2168cc57cc7e46699c9829db969e614cf87787b4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Recipe_Ingredient : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
  
    ViewData["Title"] = "Подробный рецепт";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 7 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 8 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
  var recipe = Model.recipe_Ingredient;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 9 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
             foreach (var type in Model.recipe_Types.Where(id => id.RecipeId == recipe.id))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>");
#nullable restore
#line 14 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
               Write(type.type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n");
#nullable restore
#line 15 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n    <img");
            BeginWriteAttribute("src", " src=", 453, "", 471, 1);
#nullable restore
#line 19 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
WriteAttributeValue("", 458, recipe.Image, 458, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <a");
            BeginWriteAttribute("href", " href=", 480, "", 542, 1);
#nullable restore
#line 20 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
WriteAttributeValue("", 486, Url.Page("/AddIngredients"), 486, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Добавить ингредиентов</a>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr><th>Ingredients</th><th>Quantity</th><th>Measurement</th></tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
         foreach (var ing in Model.recipe_Ingredients.Where(id => id.RecipeId == recipe.id))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
               Write(ing.Ingredient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
               Write(ing.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
               Write(ing.Ingredient.measurement.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe_Ingredient.cshtml"
        }           

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeApp.Pages.Recipe_IngredientModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeApp.Pages.Recipe_IngredientModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeApp.Pages.Recipe_IngredientModel>)PageContext?.ViewData;
        public RecipeApp.Pages.Recipe_IngredientModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
