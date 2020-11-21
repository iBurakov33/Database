using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeApp.Business_Logic.DTO;
using RecipeApp.Business_Logic.Interfaces;

namespace RecipeApp.Pages
{
    public class UpdateRecipeModel : PageModel
    {
        private readonly IRecipeService service;
        [BindProperty]
        public RecipeDTO recipe { get; set; }
        public UpdateRecipeModel(IRecipeService db)
        {
            service = db;
        }
        public IActionResult OnGet(int id)
        {
            recipe = service.Get(id);
            //if (id == null)
            //{
            //    return NotFound();
            //}

            return Page();
        }
        public IActionResult OnPost()
        {
            
            if (recipe == null)
            {
                return NotFound();
            }
            service.Update(recipe);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("Index");
        }
    }
}
