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
    [BindProperties]
    public class DeleteRecipeModel : PageModel
    {
        private readonly IRecipeService _service;
        private readonly IRecipe_IngredientService _ingredientService;
        private readonly IRecipe_TypeService _typeService;
        public RecipeDTO recipe { get; set; }
        public Recipe_IngredientDTO recipe_Ingredient { get; set; }
        public Recipe_TypeDTO recipe_Type { get; set; }
        public DeleteRecipeModel(IRecipeService db, IRecipe_IngredientService dbI, IRecipe_TypeService dbT)
        {
            _service = db;
            _ingredientService = dbI;
            _typeService = dbT;
        }
        public void OnGet(Guid id)
        {
            recipe = _service.Get(id);
            recipe_Ingredient = _ingredientService.GetByName(recipe.Name);
            recipe_Type = _typeService.GetByName(recipe.Name);
        }
        public IActionResult OnPost()
        {
            _service.Delete(recipe.id);
            _ingredientService.Delete(recipe_Ingredient.id);
            _typeService.Delete(recipe_Type.id);

            return RedirectToPage("Index");
        }
    }
}
