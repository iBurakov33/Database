using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipeApp.Pages
{
    public abstract class BaseLayoutPageModel : PageModel
    {
        public string SingedInUser { get; set; }
    }
}
