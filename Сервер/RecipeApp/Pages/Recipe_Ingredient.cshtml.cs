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
        private readonly IRecipe_IngredientService _serviceR_I;
        private readonly IRecipeService _serviceR;
        private readonly IRecipe_TypeService _TypeService;
        private readonly IUserService _userService;
        public RecipeDTOFull recipe_Ingredient { get; set; }
        public UserDTO user { get; set; }
        public IEnumerable<Recipe_IngredientDTO> recipe_Ingredients { get; set; }
        public IEnumerable<Recipe_TypeDTO> recipe_Types { get; set; }
        public Recipe_IngredientModel(IRecipe_IngredientService dbR_I, IRecipeService dbR, IRecipe_TypeService dbR_T, IUserService dbU)
        {
            _serviceR_I = dbR_I;
            _serviceR = dbR;
            _TypeService = dbR_T;
            _userService = dbU;
        }
        public void OnGet(Guid id, string login)
        {
            if (login == null)
            {
                recipe_Ingredient = _serviceR.Get(id);
                recipe_Ingredients = _serviceR_I.GetAll();
                recipe_Types = _TypeService.GetAll();
            }
            else
            {
                recipe_Ingredient = _serviceR.Get(id);
                recipe_Ingredients = _serviceR_I.GetAll();
                recipe_Types = _TypeService.GetAll();
                user = _userService.GetByLogin(login);
            }  
        }
    }
}
