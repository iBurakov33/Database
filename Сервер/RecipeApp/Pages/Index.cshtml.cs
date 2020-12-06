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
    public class IndexModel : PageModel
    {
        private readonly IRecipeService _service;
        private readonly ITypesService _typesService;
        private readonly IUserService _userService;
        public IEnumerable<RecipeDTO> recipes { get; set; }
        public IEnumerable<TypeDTO> types { get; set; }
        public UserDTO user { get; set; }
        public IndexModel(IRecipeService db, ITypesService dbT, IUserService dbU)
        {
            _service = db;
            _typesService = dbT;
            _userService = dbU;
        }
        public void OnGet(string login)
        {
            if (login == null)
            {
                recipes = _service.GetAll();
                types = _typesService.GetAll();
            }
            else
            {
                user = _userService.GetByLogin(login);
                recipes = _service.GetAll();
                types = _typesService.GetAll();
            }
        }
        
    }
}
