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
    public class AddRecipeModel : PageModel
    {
        private readonly IRecipeService _service;
        [BindProperty]
        public RecipeDTO recipe { get; set; }
        public AddRecipeModel(IRecipeService db)
        {
            _service = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _service.Add(recipe);//_context.People.Add(Person);
                //await _service.;
                return Redirect("AddType");
            }
            return Page();
        }
    }
}
