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
            _context.Add(entity);
        }

        public void Delete(int id)
        {
            Recipe entity = _context.Recipes.Find(id);
            if (entity != null)
                _context.Recipes.Remove(entity);
        }

        public Recipe Get(int id)
        {
            return _context.Recipes.Find(id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return _context.Recipes;
        }

        public void Update(Recipe entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
