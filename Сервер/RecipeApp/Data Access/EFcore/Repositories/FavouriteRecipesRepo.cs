using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class FavouriteRecipesRepo : IRepository<FavouriteRecipes>
    {
        private readonly RecipeAppWebApiContext _context;

        public FavouriteRecipesRepo(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(FavouriteRecipes entity)
        {
            entity.id = new Guid();
            _context.Add(entity);
        }

        public void AddDefault(FavouriteRecipes entity, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            FavouriteRecipes entity = _context.FavouriteRecipes.Find(id);
            if (entity != null)
                _context.FavouriteRecipes.Remove(entity);
        }

        public FavouriteRecipes Get(Guid id)
        {
            var favouriteRecipes = _context.FavouriteRecipes
                .Include(favouriteRecipes => favouriteRecipes.Recipe)
                .Include(favouriteRecipes => favouriteRecipes.User)
                .Single(amount => amount.id == id);
            return favouriteRecipes;
        }

        public IEnumerable<FavouriteRecipes> GetAll()
        {
            return _context.FavouriteRecipes
                .Include(favouriteRecipes => favouriteRecipes.Recipe)
                .Include(favouriteRecipes => favouriteRecipes.User);
        }

        public IEnumerable<FavouriteRecipes> GetAllByName(string name)
        {
            var favouriteRecipes = _context.FavouriteRecipes
                .Include(favouriteRecipes => favouriteRecipes.Recipe)
                .Include(favouriteRecipes => favouriteRecipes.User)
                .Where(recipe => recipe.User.Login == name);
            return favouriteRecipes;
                
        }

        public FavouriteRecipes GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(FavouriteRecipes entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
