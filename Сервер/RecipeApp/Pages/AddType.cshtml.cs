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
    public class AddTypeModel : PageModel
    {
        private readonly IRecipe_TypeService _service;
        private readonly IRecipeService _recipeService;
        private readonly ITypesService _typesService;
        private readonly IUserService _userService;
        public Recipe_TypeDTO type { get; set; }
        public RecipeDTOFull recipe { get; set; }
        public UserDTO user { get; set; }
        public TypeDTO typeMain { get; set; }
        public string typeName { get; set; }
        public AddTypeModel(IRecipe_TypeService db, IRecipeService dbR, ITypesService dbT, IUserService dbU)
        {
            _service = db;
            _recipeService = dbR;
            _typesService = dbT;
            _userService = dbU;
        }
        public void OnGet(Guid id, string login)
        {
            recipe = _recipeService.Get(id);
            user = _userService.GetByLogin(login);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                type.RecipeId = recipe.id;
                try
                {
                    typeMain = _typesService.GetByName(typeName);
                }
                catch (InvalidOperationException)
                {
                    _typesService.Add(new TypeDTO { Name = typeName });
                    typeMain = _typesService.GetByName(typeName);
                }
                type.TypeId = typeMain.id;
                _service.Add(type);
                return Redirect(Url.Page("/Recipe_ingredient", new { id = recipe.id, login = user.Login }));
            }
            return Page();
        }
    }
}
