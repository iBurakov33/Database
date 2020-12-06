using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class RecipeRep : IRepository<Recipe>
    {
        private readonly RecipeAppWebApiContext _context;
        public RecipeRep(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(Recipe entity)
        {
            entity.id = new Guid();
            _context.Add(entity);
        }

        public void AddDefault(Recipe entity, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            Recipe entity = _context.Recipes.Find(id);
            if (entity != null)
                _context.Recipes.Remove(entity);
        }

        public Recipe Get(Guid id)
        {
            return _context.Recipes.Find(id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return _context.Recipes;
        }

        public IEnumerable<Recipe> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public Recipe GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Recipe entity)
        {
            //Recipe entity = _context.Recipes.Find(id);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
