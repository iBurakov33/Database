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
        void Add(RecipeDTO entity);
        void Delete(int id);
        RecipeDTO Get(int id);
        IEnumerable<RecipeDTO> GetAll();
        void Update(RecipeDTO entity);
    }
}
