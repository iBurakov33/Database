using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class Recipe_IngredientRepo : IRepository<Recipe_Ingredient>
    {
        private readonly RecipeAppWebApiContext _context;

        public Recipe_IngredientRepo(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(Recipe_Ingredient entity)
        {
            entity.id = new Guid();
            _context.Add(entity);
        }

        public void AddDefault(Recipe_Ingredient entity, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            Recipe_Ingredient entity = _context.Recipes_Ingredients.Find(id);
            if (entity != null)
                _context.Recipes_Ingredients.Remove(entity);
        }

        public Recipe_Ingredient Get(Guid id)
        {
            var amount = _context.Recipes_Ingredients
                .Include(recipe => recipe.Recipe)
                .Include(ingredient => ingredient.Ingredient)
                .Single(amount => amount.id == id);
            return amount;
        }

        public IEnumerable<Recipe_Ingredient> GetAll()
        {
            return _context.Recipes_Ingredients
                .Include(recipe => recipe.Recipe)
                .Include(ingredient => ingredient.Ingredient);
        }

        public IEnumerable<Recipe_Ingredient> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public Recipe_Ingredient GetByName(string name)
        {
            var amount = _context.Recipes_Ingredients
                .Include(recipe => recipe.Recipe)
                .Include(ingredient => ingredient.Ingredient)
                .Single(amount => amount.Recipe.Name == name);
            return amount;
        }

        public void Update(Recipe_Ingredient entity)
        {
            //Recipe_Ingredient entity = _context.Recipes_Ingredients.Find(id);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
