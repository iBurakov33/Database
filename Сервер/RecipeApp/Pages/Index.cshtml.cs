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
    public class IndexModel : PageModel
    {
        private readonly IRecipeService _service;
        public IEnumerable<RecipeDTO> recipes { get; set; }
        public IndexModel(IRecipeService db)
        {
            _service = db;
        }
        public void OnGet()
        {
            recipes = _service.GetAll();
        }
    }
}
