using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Recipe> GetRecipeRepo { get; }
        IRepository<Ingredient> GetIngredientRepo { get; }
        IRepository<Models.Type> GetTypeRepo { get; }
        IRepository<Recipe_Ingredient> GetRecipe_IngredientRepo { get; }
        IRepository<Recipe_Type> GetRecipe_TypeRepo { get; }
        IRepository<Measurement> GetMeasurmentRepo { get; }
        IUserRepository GetUsersRepo { get; }
        IRepository<FavouriteRecipes> GetFavouriteRecipesRepo { get; }
        void Save();
    }
}
