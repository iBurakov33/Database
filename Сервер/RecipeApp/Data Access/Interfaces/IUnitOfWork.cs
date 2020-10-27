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
        IRepository<AmountOfIngredients> GetAmountRepo { get; }
        void Save();
    }
}
