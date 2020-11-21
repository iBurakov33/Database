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
            _context.Add(entity);
        }

        public void Delete(int id)
        {
            Recipe_Ingredient entity = _context.Recipes_Ingredients.Find(id);
            if (entity != null)
                _context.Recipes_Ingredients.Remove(entity);
        }

        public Recipe_Ingredient Get(int id)
        {
            var amount = _context.Recipes_Ingredients
                .Include(recipe => recipe.Recipe_Type.recipe)
                .Include(type => type.Recipe_Type.type)
                .Include(ingredient => ingredient.Ingredient)
                .Include(measurement => measurement.Ingredient.measurement)
                .Single(amount => amount.id == id);
            return amount;
        }

        public IEnumerable<Recipe_Ingredient> GetAll()
        {
            return _context.Recipes_Ingredients
                .Include(recipe => recipe.Recipe_Type.recipe)
                .Include(type => type.Recipe_Type.type)
                .Include(ingredient => ingredient.Ingredient)
                .Include(measurement => measurement.Ingredient.measurement);
        }

        public void Update(Recipe_Ingredient entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
