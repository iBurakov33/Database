using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IRecipe_IngredientService
    {
        void Add(Recipe_IngredientDTO entity);
        void Delete(Guid id);
        Recipe_IngredientDTO Get(Guid id);
        IEnumerable<Recipe_IngredientDTO> GetAll();
        void Update(Recipe_IngredientDTO entity);
    }
}
