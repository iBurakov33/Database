#pragma checksum "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b5653016bce9bfc228fb00c4a14df81f1ae814"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b5653016bce9bfc228fb00c4a14df81f1ae814", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Список рецептов";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 7 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr><th>id</th><th>Name</th><th>Make Time</th><th>Description</th></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
         foreach (var recipe in Model.recipes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>");
#nullable restore
#line 16 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
               Write(recipe.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                                  Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                                                       Write(recipe.MakeTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
                                                                                Write(recipe.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 17 "C:\Users\Илья\source\repos\Database\Сервер\RecipeApp\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
