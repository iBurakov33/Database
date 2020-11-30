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
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _service;

        public RecipeController(IRecipeService service)
        {
            _service = service;
        }
        [HttpGet("One_Recipe")]
        public RecipeDTO GetRecipe(Guid id)
        {
            return _service.Get(id);
        }
        [HttpPost("Add_Recipe")]
        public void AddRecipe(RecipeDTO recipe)
        {
            _service.Add(recipe);
        }
    }
}
