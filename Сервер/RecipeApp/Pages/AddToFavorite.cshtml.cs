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
    public class AddToFavoriteModel : PageModel
    {
        private readonly IFavouriteRecipesService favouriteRecipesService;
        private readonly IUserService userService;
        private readonly IRecipeService recipeService;
        public FavouriteRecipesDTO recipe { get; set; }
        public UserDTO user { get; set; }
        public RecipeDTO recipeMain { get; set; }
        public AddToFavoriteModel(IFavouriteRecipesService db, IUserService dbU, IRecipeService dbR)
        {
            favouriteRecipesService = db;
            userService = dbU;
            recipeService = dbR;
        }
        public void OnGet(string login, Guid id)
        {
            //login = "User2";
            recipeMain = recipeService.Get(id);
            user = userService.GetByLogin(login);
        }
        public void OnPost()
        {
            recipe.RecipeId = recipeMain.id;
            recipe.UserId = user.id;
            favouriteRecipesService.Add(recipe);
        }
    }
}
