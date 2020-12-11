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
        private readonly IUserService _userService;
        public RecipeDTOFull recipe { get; set; }
        public UserDTO user { get; set; }
        public Guid RecipeId { get; set; }
        public Recipe_IngredientDTO ingredient { get; set; }
        public IngredientDTO ingredientMain { get; set; }
        public string ingredientName { get; set; }
        public string measurementName { get; set; }
        public AddIngredientsModel(IRecipe_IngredientService db, IRecipeService recipeDb, IIngredientService ingredientDb, IUserService userDb)
        {
            _service = db;
            _recipeService = recipeDb;
            _ingredientService = ingredientDb;
            _userService = userDb;
        }
        public void OnGet(Guid id, string login)
        {
            recipe = _recipeService.Get(id);
            user = _userService.GetByLogin(login);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                ingredient.RecipeId = recipe.id;
                try
                {
                    ingredientMain = _ingredientService.GetByName(ingredientName);
                }
                catch (InvalidOperationException)
                {
                    _ingredientService.Add(new IngredientDTO { id = Guid.NewGuid(), Name = ingredientName });
                    ingredientMain = _ingredientService.GetByName(ingredientName);
                }
                ingredient.IngredientId = ingredientMain.id;
                _service.Add(ingredient);
                return Redirect(Url.Page("/Index", new { login = user.Login }));
            }
            return Page();
        }
    }
}
