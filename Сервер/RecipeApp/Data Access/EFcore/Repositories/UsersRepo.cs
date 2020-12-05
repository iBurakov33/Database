using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class UsersRepo : IUserRepository
    {
        private readonly RecipeAppWebApiContext _context;
        public UsersRepo(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(User entity)
        {
            entity.id = new Guid();
            entity.AdminRole = false;
            _context.Add(entity);
        }

        public void AddDefault(User entity, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            User entity = _context.Users.Find(id);
            if (entity != null)
                _context.Users.Remove(entity);
        }

        public User Get(Guid id)
        {
            var user = _context.Users.Single(amount => amount.id == id);
            return user;
        }

        public User GetUser(string login, string password)
        {
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //if ()
            //{

            //}
            var user = _context.Users.Single(user => user.Login == login && user.Password == password);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public void Update(User entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
