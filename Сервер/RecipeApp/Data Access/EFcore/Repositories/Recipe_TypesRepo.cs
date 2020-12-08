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
            entity.id = new Guid();
            _context.Add(entity);
        }

        public void AddDefault(Recipe_Type entity, Guid id)
        {
            entity = new Recipe_Type { id = new Guid() , RecipeId = id, TypeId = Guid.Parse("c064d010-331b-11eb-adc1-0242ac120002")};
            _context.Add(entity);
        }

        public void Delete(Guid id)
        {
            Recipe_Type entity = _context.Recipes_Types.Find(id);
            if (entity != null)
                _context.Recipes_Types.Remove(entity);
        }

        public Recipe_Type Get(Guid id)
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

        public IEnumerable<Recipe_Type> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public Recipe_Type GetByName(string name)
        {
            var amount = _context.Recipes_Types
                .Include(recipe => recipe.recipe)
                .Include(type => type.type)
                .Single(amount => amount.recipe.Name == name);
            return amount;
        }

        public void Update(Recipe_Type entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
