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
    public class IndexModel : BaseLayoutPageModel
    {
        private readonly IRecipeService _service;
        private readonly ITypesService _typesService;
        public IEnumerable<RecipeDTO> recipes { get; set; }
        public IEnumerable<TypeDTO> types { get; set; }
        public string _login { get; set; }
        public IndexModel(IRecipeService db, ITypesService dbT)
        {
            _service = db;
            _typesService = dbT;
        }
        public void OnGet(string login)
        {
            _login = login;
            recipes = _service.GetAll();
            types = _typesService.GetAll();
        }
        
    }
}
