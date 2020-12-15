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
        void Delete(Guid id);
        IngredientDTO Get(Guid id);
        IngredientDTO GetByName(string name);
        IEnumerable<IngredientDTO> GetAll();
        void Update(IngredientDTO entity);
    }
}
