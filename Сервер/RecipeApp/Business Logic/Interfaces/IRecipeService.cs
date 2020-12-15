using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IRecipeService 
    {
        void Add(RecipeDTOFull entity);
        void Delete(Guid id);
        RecipeDTOFull Get(Guid id);
        IEnumerable<RecipeDTOShort> GetAll();
        void Update(RecipeDTOFull entity);
    }
}
