using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class IngredientRepo : IRepository<Ingredient>
    {
        private readonly RecipeAppWebApiContext _context;

        public IngredientRepo(RecipeAppWebApiContext context)
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
            var ingredient = _context.Ingredients
                .Include(ingredient => ingredient.measurement)
                .Single(amount => amount.id == id);
            return ingredient;
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return _context.Ingredients
                .Include(measurement => measurement.measurement);
        }

        public void Update(Ingredient entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
