using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class TypesRepo : IRepository<Models.Type>
    {
        private readonly RecipeAppWebApiContext _context;
        public TypesRepo(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(Models.Type entity)
        {
            _context.Add(entity);
        }

        public void AddDefault(Models.Type entity, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            Models.Type entity = _context.Types.Find(id);
            if (entity != null)
                _context.Types.Remove(entity);
        }

        public Models.Type Get(Guid id)
        {
            return _context.Types.Find(id);
        }

        public IEnumerable<Models.Type> GetAll()
        {
            return _context.Types;
        }

        public void Update(Models.Type entity)
        {
            //Models.Type entity = _context.Types.Find(id);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
