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
    public class FavouriteRecipesService : IFavouriteRecipesService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public FavouriteRecipesService(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }
        public void Add(FavouriteRecipesDTO entity)
        {
            FavouriteRecipes favouriteRecipes = _mapper.Map<FavouriteRecipes>(entity);
            _db.GetFavouriteRecipesRepo.Add(favouriteRecipes);
            _db.Save();
        }

        public void Delete(Guid id)
        {
            _db.GetFavouriteRecipesRepo.Delete(id);
        }

        public FavouriteRecipesDTO Get(Guid id)
        {
            var favouriteRecipes = _db.GetFavouriteRecipesRepo.Get(id);
            return _mapper.Map<FavouriteRecipes, FavouriteRecipesDTO>(favouriteRecipes);
        }

        public IEnumerable<FavouriteRecipesDTO> GetAll()
        {
            var favouriteRecipes = _db.GetFavouriteRecipesRepo.GetAll();
            return _mapper.Map<IEnumerable<FavouriteRecipes>, IEnumerable<FavouriteRecipesDTO>>(favouriteRecipes);
        }

        public IEnumerable<FavouriteRecipesDTO> GetAllByName(string name)
        {
            var favouriteRecipes = _db.GetFavouriteRecipesRepo.GetAllByName(name);
            return _mapper.Map<IEnumerable<FavouriteRecipes>, IEnumerable<FavouriteRecipesDTO>>(favouriteRecipes);
        }

        public FavouriteRecipesDTO GetByName(string name)
        {
            var favouriteRecipes = _db.GetFavouriteRecipesRepo.GetByName(name);
            return _mapper.Map<FavouriteRecipes, FavouriteRecipesDTO>(favouriteRecipes);
        }

        public void Update(FavouriteRecipesDTO entity)
        {
            FavouriteRecipes favouriteRecipes = _mapper.Map<FavouriteRecipes>(entity);
            _db.GetFavouriteRecipesRepo.Update(favouriteRecipes);
            _db.Save();
        }
    }
}
