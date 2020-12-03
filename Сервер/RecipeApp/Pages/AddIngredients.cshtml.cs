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
    public class AddIngredientsModel : PageModel
    {
        private readonly IRecipe_IngredientService _service;
        private readonly IRecipeService _recipeService;
        private readonly IIngredientService _ingredientService;
        public RecipeDTO recipe { get; set; }
        public Guid RecipeId { get; set; }
        public Recipe_IngredientDTO ingredient { get; set; }
        public IngredientDTO ingredientMain { get; set; }
        public string ingredientName { get; set; }
        public AddIngredientsModel(IRecipe_IngredientService db, IRecipeService recipeDb, IIngredientService ingredientDb)
        {
            _service = db;
            _recipeService = recipeDb;
            _ingredientService = ingredientDb;
        }
        public void OnGet(Guid id)
        {
            recipe = _recipeService.Get(id);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                ingredient.RecipeId = recipe.id;
                ingredientMain = _ingredientService.GetByName(ingredientName);
                ingredient.IngredientId = ingredientMain.id;
                _service.Add(ingredient);
                return Redirect("Index");
            }
            return Page();
        }
    }
}
