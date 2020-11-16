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
    public class TypesController : ControllerBase
    {
        private readonly ITypesService _service;
        public TypesController(ITypesService service)
        {
            _service = service;
        }
        [HttpGet("One Type")]
        public TypeDTO GetOneType(int id)
        {
            return _service.Get(id);
        }
        [HttpGet("All Types")]
        public IEnumerable<TypeDTO> GetAllTypes()
        {
            return _service.GetAll();
        }
        [HttpPost("Add Type")]
        public void AddType(TypeDTO type)
        {
            _service.Add(type);
        }
    }
}
