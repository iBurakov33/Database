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
    public class FavouriteRecipesModel : PageModel
    {
        private readonly IFavouriteRecipesService _favouriteRecipesService;
        public IEnumerable<FavouriteRecipesDTO> recipes { get; set; }
        public UserDTO user { get; set; }
        public string _login { get; set; }
        public FavouriteRecipesModel(IFavouriteRecipesService dbF)
        {;
            _favouriteRecipesService = dbF;
        }
        public void OnGet(string login)
        {
            recipes = _favouriteRecipesService.GetAllByName(login);
        }
    }
}
