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
    public class AddIngredientsModel : PageModel
    {
        private readonly IRecipe_IngredientService _service;
        [BindProperty]
        public Recipe_IngredientDTO ingredient { get; set; }
        public AddIngredientsModel(IRecipe_IngredientService db)
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
                _service.Add(ingredient);//_context.People.Add(Person);
                //await _service.;
                return Redirect("Index");
            }
            return Page();
        }
    }
}
