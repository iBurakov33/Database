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
    public class AddRecipeModel : PageModel
    {
        private readonly IRecipeService _service;
        private readonly IUserService _userService;

        public RecipeDTOFull recipe { get; set; }
        public UserDTO user { get; set; }
        public AddRecipeModel(IRecipeService db, IUserService dbU)
        {
            _service = db;
            _userService = dbU;
        }
        public void OnGet(string login)
        {
            user = _userService.GetByLogin(login);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                recipe.UserId = user.id;
                _service.Add(recipe);
                return Redirect(Url.Page("/Index", new { login = user.Login }));
            }
            return Page();
        }
    }
}
