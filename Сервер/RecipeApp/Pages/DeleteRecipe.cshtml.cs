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
        private readonly IUserService _userService;
        public RecipeDTOFull recipe { get; set; }
        public Recipe_IngredientDTO recipe_Ingredient { get; set; }
        public Recipe_TypeDTO recipe_Type { get; set; }
        public UserDTO user { get; set; }
        public DeleteRecipeModel(IRecipeService db, IRecipe_IngredientService dbI, IRecipe_TypeService dbT, IUserService dbU)
        {
            _service = db;
            _ingredientService = dbI;
            _typeService = dbT;
            _userService = dbU;
        }
        public void OnGet(Guid id, string login)
        {
            recipe = _service.Get(id);
            try
            {
                recipe_Ingredient = _ingredientService.GetById(recipe.id);
            }
            catch (InvalidOperationException)
            {
                goto NoInredients;
            }
            NoInredients:
            try
            {
                recipe_Type = _typeService.GetById(recipe.id);
            }
            catch (InvalidOperationException)
            {
                goto NoTypes;
            }
            NoTypes:
            //recipe_Ingredient = _ingredientService.GetByName(recipe.Name);
            //recipe_Type = _typeService.GetByName(recipe.Name);
            user = _userService.GetByLogin(login); 
        }
        public IActionResult OnPost()
        {
            try
            {
                _ingredientService.Delete(recipe_Ingredient.id);
            }
            catch (InvalidOperationException)
            {
                goto NoInredients;
            }
        NoInredients:
            try
            {
                _typeService.Delete(recipe_Type.id);
            }
            catch (InvalidOperationException)
            {
                goto NoTypes;
            }
        NoTypes:
            _service.Delete(recipe.id);
            //_ingredientService.Delete(recipe_Ingredient.id);
            //_typeService.Delete(recipe_Type.id);

            return Redirect(Url.Page("/Index", new { login = user.Login }));
        }
    }
}
