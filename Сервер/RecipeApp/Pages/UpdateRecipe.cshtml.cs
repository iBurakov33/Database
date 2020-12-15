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
    public class UpdateRecipeModel : PageModel
    {
        private readonly IRecipeService service;
        private readonly IUserService _userService;
        public UserDTO user { get; set; }
        public RecipeDTOFull recipe { get; set; }
        public UpdateRecipeModel(IRecipeService db, IUserService dbU)
        {
            service = db;
            _userService = dbU;
        }
        public void OnGet(Guid id, string login)
        {
            recipe = service.Get(id);
            user = _userService.GetByLogin(login);
        }
        public IActionResult OnPost(Guid id)
        {
            if (recipe == null)
            {
                return NotFound();
            }
            recipe.id = id;
            recipe.UserId = user.id;
            service.Update(recipe);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect(Url.Page("/Index", new { login = user.Login }));
        }
    }
}
