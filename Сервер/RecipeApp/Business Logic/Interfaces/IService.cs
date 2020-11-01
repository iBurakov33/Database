using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IService 
    {
        IngredientDTO GetIng(int id);
        IEnumerable<RecipeDTO> GetAllRecipes();
        RecipeDTO GetRecipe(int id);
        TypeDTO GetType(int id);
        IEnumerable<AmountDTO> GetAllAmount();
        AmountDTO GetOneRecipe(int id);
    }
}
