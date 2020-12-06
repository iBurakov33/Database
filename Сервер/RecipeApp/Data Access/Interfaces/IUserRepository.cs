using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Get(Guid id);
        User GetUser(string login, string password);
        User GetByLogin(string login);
        void Add(User entity);
        void Update(User entity);
        void Delete(Guid id);
        public void AddDefault(User entity, Guid id);
    }
}
