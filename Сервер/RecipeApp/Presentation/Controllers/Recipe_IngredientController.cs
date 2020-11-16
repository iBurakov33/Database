using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Business_Logic.Services;
using RecipeApp.Business_Logic.Interfaces;
using RecipeApp.Business_Logic.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipeApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Recipe_IngredientController : ControllerBase
    {
        private readonly IRecipe_IngredientService _service;

        public Recipe_IngredientController(IRecipe_IngredientService service)
        {
            _service = service;
        }

        [HttpGet("All Recipes_Ingredients")]
        public IEnumerable<Recipe_IngredientDTO> GetAllRecipes_Ingredients()
        {
            return _service.GetAll();
        }
        [HttpGet("One Recipe_Ingredient")]
        public Recipe_IngredientDTO GetOneRecipe_Ingredient(int id)
        {
            return _service.Get(id);
        }
    }
}
