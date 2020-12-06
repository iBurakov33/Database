using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IFavouriteRecipesService
    {
        void Add(FavouriteRecipesDTO entity);
        void Delete(Guid id);
        FavouriteRecipesDTO Get(Guid id);
        FavouriteRecipesDTO GetByName(string name);
        IEnumerable<FavouriteRecipesDTO> GetAllByName(string name);
        IEnumerable<FavouriteRecipesDTO> GetAll();
        void Update(FavouriteRecipesDTO entity);
    }
}
