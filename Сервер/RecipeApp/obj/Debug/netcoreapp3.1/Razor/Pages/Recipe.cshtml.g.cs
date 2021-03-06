#pragma checksum "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be0794fdfe88c765bb79b3451131f03a5744157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipeApp.Pages.Pages_Recipe), @"mvc.1.0.razor-page", @"/Pages/Recipe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be0794fdfe88c765bb79b3451131f03a5744157", @"/Pages/Recipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf5749beb52248b8c81aba9922b4f5aca0a8c3c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Recipe : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
  
    ViewData["Title"] = "Список рецептов";
    string _login;
    if (Model.user == null)
    {
        _login = "";
    }
    else
    {
        _login = Model.user.Login;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 style=\"text-align:center; margin:12px;font-size:55px; font-weight:600;\">");
#nullable restore
#line 16 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
                                                                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div style=\"display:flex;justify-content:flex-start;\">\r\n");
#nullable restore
#line 19 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
     foreach (var type in Model.types)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <a style=\"margin: 8px;\r\n        margin-top: 15px;\r\n        margin-bottom: 20px;\r\n        font-size: 20px;\r\n        border: 4px solid lightskyblue;\r\n        border-radius: 0 50% 50% 50%;\r\n        padding: 15px;\"");
            BeginWriteAttribute("href", " href=", 667, "", 734, 1);
#nullable restore
#line 28 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
WriteAttributeValue("", 673, Url.Page("/Recipe", new { name = type.Name, login = _login}), 673, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
                                                                                      Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 29 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
 foreach (var recipe in Model.recipes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col l4 s12 m7\">\r\n        <div class=\"card\">\r\n            <div class=\"card-image\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 934, "", 959, 1);
#nullable restore
#line 39 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
WriteAttributeValue("", 939, recipe.recipe.Image, 939, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"card-content\">\r\n                <span class=\"card-title\" style=\"font-size:24px;font-weight:600;\">");
#nullable restore
#line 42 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
                                                                            Write(recipe.recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <p>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
               Write(recipe.recipe.DescriptionShort);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div style=\"display:flex; flex-wrap:wrap; justify-content:space-around;\">\r\n                <a class=\"waves-effect waves-light btn-large red\" style=\"margin-bottom:8px;\"");
            BeginWriteAttribute("href", " href=", 1426, "", 1510, 1);
#nullable restore
#line 48 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
WriteAttributeValue("", 1432, Url.Page("/Recipe_ingredient", new { id = recipe.recipe.id, login = _login }), 1432, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Подробнее</a>\r\n");
#nullable restore
#line 49 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
                  
                    if (Model.user != null)
                    {
                        if (Model.user.AdminRole)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"waves-effect waves-light btn-large red\" style=\"margin-bottom:8px;\"");
            BeginWriteAttribute("href", " href=", 1796, "", 1867, 1);
#nullable restore
#line 54 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
WriteAttributeValue("", 1802, Url.Page("/UpdateRecipe", new { id = recipe.id, login = _login}), 1802, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Редактировать</a>\r\n                            <a class=\"waves-effect waves-light btn-large red\" style=\"margin-bottom:8px;\"");
            BeginWriteAttribute("href", " href=", 1991, "", 2062, 1);
#nullable restore
#line 55 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
WriteAttributeValue("", 1997, Url.Page("/DeleteRecipe", new { id = recipe.id, login = _login}), 1997, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Удалить</a>\r\n");
#nullable restore
#line 56 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 62 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Recipe.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeApp.Pages.RecipeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeApp.Pages.RecipeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeApp.Pages.RecipeModel>)PageContext?.ViewData;
        public RecipeApp.Pages.RecipeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
