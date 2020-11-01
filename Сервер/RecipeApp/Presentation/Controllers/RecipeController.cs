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
        private readonly IService _service;

        public RecipeController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<AmountDTO> GetAllAmounts()
        {
            return _service.GetAllAmount();
        }
        [HttpGet("OneAmount")]
        public AmountDTO GetOneRecipe(int id)
        {
            return _service.GetOneRecipe(id);
        }

        [HttpGet("OneRecipe")]
        public RecipeDTO GetRecipe(int id)
        {
            return _service.GetRecipe(id);
        }

        [HttpGet("OneIngredient")]
        public IngredientDTO GetIngredient(int id)
        {
            return _service.GetIng(id);
        }

        [HttpGet("OneType")]
        public TypeDTO GetOneType(int id)
        {
            return _service.GetType(id);
        }
    }
}
