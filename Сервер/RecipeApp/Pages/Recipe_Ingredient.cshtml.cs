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
    public class Recipe_IngredientModel : PageModel
    {
        private readonly IRecipe_IngredientService _service;
        public IEnumerable<Recipe_IngredientDTO> recipe_Ingredients { get; set; }
        public Recipe_IngredientModel(IRecipe_IngredientService db)
        {
            _service = db;
        }
        public void OnGet()
        {
            recipe_Ingredients = _service.GetAll(); 
        }
    }
}
