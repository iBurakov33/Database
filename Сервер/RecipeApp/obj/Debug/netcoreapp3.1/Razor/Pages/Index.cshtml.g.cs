#pragma checksum "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f1538f465b646902824be5b979cfb30f668afc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f1538f465b646902824be5b979cfb30f668afc", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2168cc57cc7e46699c9829db969e614cf87787b4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
 foreach (var recipe in Model.recipes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col l4 s12 m7\">\r\n            <div class=\"card\">\r\n                <div class=\"card-image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 302, "", 320, 1);
#nullable restore
#line 13 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
WriteAttributeValue("", 307, recipe.Image, 307, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                                        Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"card-content\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 18 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                   Write(recipe.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"card-action\">\r\n                    <a href=\"#\">This is a link</a>\r\n                </div>\r\n                \r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr><th>id</th><th>Name</th><th>Make Time</th><th>Description</th></tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
             foreach (var recipe in Model.recipes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr><td>");
#nullable restore
#line 36 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                   Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 36 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                                        Write(recipe.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 36 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                                                              Write(recipe.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 37 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
