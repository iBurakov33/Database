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
    public class Recipe_IngredientModel : BaseLayoutPageModel
    {
        private readonly IRecipe_IngredientService _serviceR_I;
        private readonly IRecipeService _serviceR;
        private readonly IRecipe_TypeService _TypeService;
        public RecipeDTO recipe_Ingredient { get; set; }
        public IEnumerable<Recipe_IngredientDTO> recipe_Ingredients { get; set; }
        public IEnumerable<Recipe_TypeDTO> recipe_Types { get; set; }
        public Recipe_IngredientModel(IRecipe_IngredientService dbR_I, IRecipeService dbR, IRecipe_TypeService dbR_T)
        {
            _serviceR_I = dbR_I;
            _serviceR = dbR;
            _TypeService = dbR_T;
        }
        public void OnGet(Guid id)
        {
            //int id = 8;
            //Recipeid = _service.Get(id).
            recipe_Ingredient = _serviceR.Get(id);
            recipe_Ingredients = _serviceR_I.GetAll();
            recipe_Types = _TypeService.GetAll();
        }
    }
}
