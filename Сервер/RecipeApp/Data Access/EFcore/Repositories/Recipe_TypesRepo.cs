using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;
namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class Recipe_TypesRepo : IRepository<Recipe_Type>
    {
        private readonly RecipeAppWebApiContext _context;

        public Recipe_TypesRepo(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(Recipe_Type entity)
        {
            _context.Add(entity);
        }

        public void Delete(int id)
        {
            Recipe_Type entity = _context.Recipes_Types.Find(id);
            if (entity != null)
                _context.Recipes_Types.Remove(entity);
        }

        public Recipe_Type Get(int id)
        {
            var amount = _context.Recipes_Types
                .Include(recipe => recipe.recipe)
                .Include(type => type.type)
                .Single(amount => amount.id == id);
            return amount;
        }

        public IEnumerable<Recipe_Type> GetAll()
        {
            return _context.Recipes_Types
                .Include(recipe => recipe.recipe)
                .Include(type => type.type);
        }

        public void Update(Recipe_Type entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
