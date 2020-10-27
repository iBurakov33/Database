using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class AmountRepo : IRepository<AmountOfIngredients>
    {
        private readonly RecipeAppWebApiContext _context;

        public AmountRepo(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(AmountOfIngredients entity)
        {
            _context.Add(entity);
        }

        public void Delete(int id)
        {
            AmountOfIngredients entity = _context.AmountOfIngredients.Find(id);
            if (entity != null)
                _context.AmountOfIngredients.Remove(entity);
        }

        public AmountOfIngredients Get(int id)
        {
            return _context.AmountOfIngredients.Find(id);
        }

        public IEnumerable<AmountOfIngredients> GetAll()
        {
            return _context.AmountOfIngredients;
        }

        public void Update(AmountOfIngredients entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
