using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class IngredientRep : IRepository<Ingredient>
    {
        private readonly RecipeAppWebApiContext _context;

        public IngredientRep(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(Ingredient entity)
        {
            _context.Add(entity);
        }

        public void Delete(int id)
        {
            Ingredient entity = _context.Ingredients.Find(id);
            if (entity != null)
                _context.Ingredients.Remove(entity);
        }

        public Ingredient Get(int id)
        {
            return _context.Ingredients.Find(id);
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return _context.Ingredients;
        }

        public void Update(Ingredient entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
