using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Business_Logic.Interfaces;
using RecipeApp.Business_Logic.DTO;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.EFcore;
using RecipeApp.Data_Access.EFcore.Repositories;
using RecipeApp.Data_Access.Models;
using AutoMapper;

namespace RecipeApp.Business_Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }
        public void Add(UserDTO entity)
        {
            User user = _mapper.Map<User>(entity);
            _db.GetUsersRepo.Add(user);
            _db.Save();
        }

        public void Delete(Guid id)
        {
            _db.GetUsersRepo.Delete(id);
        }

        public UserDTO Get(Guid id)
        {
            var user = _db.GetUsersRepo.Get(id);
            return _mapper.Map<User, UserDTO>(user);
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var user = _db.GetUsersRepo.GetAll();
            return _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(user);
        }

        public void Update(UserDTO entity)
        {
            User user = _mapper.Map<User>(entity);
            _db.GetUsersRepo.Update(user);
            _db.Save();
        }
    }
}
