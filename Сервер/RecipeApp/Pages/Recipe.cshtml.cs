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
    public class RecipeModel : PageModel
    {
        private readonly IRecipe_TypeService _service;
        private readonly ITypesService _typesService;
        private readonly IUserService _userService;
        public IEnumerable<Recipe_TypeDTO> recipes { get; set; }
        public UserDTO user { get; set; }
        public IEnumerable<TypeDTO> types { get; set; }
        public RecipeModel(IRecipe_TypeService db, ITypesService dbT, IUserService dbU)
        {
            _service = db;
            _typesService = dbT;
            _userService = dbU;
        }
        public void OnGet(string name, string login)
        {
            if (login == null)
            {
                recipes = _service.GetAll().Where(recipes => recipes.type.Name == name);
                types = _typesService.GetAll();
            }
            else
            {
                recipes = _service.GetAll().Where(recipes => recipes.type.Name == name);
                types = _typesService.GetAll();
                user = _userService.GetByLogin(login);
            }
        }
    }
}
