using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IIngredientService
    {
        void Add(IngredientDTO entity);
        void Delete(int id);
        IngredientDTO Get(int id);
        IEnumerable<IngredientDTO> GetAll();
        void Update(IngredientDTO entity);
    }
}
