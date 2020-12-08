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

        public void AddDefault(Ingredient entity, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            Ingredient entity = _context.Ingredients.Find(id);
            if (entity != null)
                _context.Ingredients.Remove(entity);
        }

        public Ingredient Get(Guid id)
        {
            var ingredient = _context.Ingredients
                .Single(amount => amount.id == id);
            return ingredient;
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return _context.Ingredients;
        }

        public IEnumerable<Ingredient> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public Ingredient GetByName(string name)
        {
            return _context.Ingredients.Single(ing => ing.Name == name);
        }

        public void Update(Ingredient entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
