using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IUserService
    {
        void Add(UserDTO entity);
        void Delete(Guid id);
        UserDTO Get(Guid id);
        IEnumerable<UserDTO> GetAll();
        void Update(UserDTO entity);
        UserDTO GetUser(string login, string password);
        UserDTO GetByLogin(string login);
        void SingIn(string login);
        void SingOff();
    }
}
