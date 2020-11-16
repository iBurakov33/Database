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
    public class Recipe_TypeController : ControllerBase
    {
        private readonly IRecipe_TypeService _service;
        public Recipe_TypeController(IRecipe_TypeService service)
        {
            _service = service;
        }
        [HttpGet("One_Recipe_Type")]
        public Recipe_TypeDTO GetOneRecipe_Type(int id)
        {
            return _service.Get(id);
        }

        [HttpGet("All_Recipes_Types")]
        public IEnumerable<Recipe_TypeDTO> GetAllRecipes_Types()
        {
            return _service.GetAll();
        }
        [HttpPost("Add_Recipe_Type")]
        public void AddRecipe(Recipe_TypeDTO recipe)
        {
            _service.Add(recipe);
        }
    }
}
