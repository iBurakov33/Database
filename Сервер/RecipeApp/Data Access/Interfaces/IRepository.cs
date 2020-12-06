using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Data_Access.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
        T GetByName(string name);
        public IEnumerable<T> GetAllByName(string name);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        public void AddDefault(T entity, Guid id);
    }
}
