using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IRecipe_TypeService
    {
        void Add(Recipe_TypeDTO entity);
        void Delete(int id);
        Recipe_TypeDTO Get(int id);
        IEnumerable<Recipe_TypeDTO> GetAll();
        void Update(Recipe_TypeDTO entity);
    }
}
