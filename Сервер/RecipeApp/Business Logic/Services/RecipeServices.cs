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
    public class RecipeServices : IRecipeService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;
        public RecipeServices(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }

        public IEnumerable<RecipeDTO> GetAll()
        {
            var recipes = _db.GetRecipeRepo.GetAll().OrderByDescending(recipes => recipes.MakeTime);
            return _mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipeDTO>>(recipes);
        }
                
        public RecipeDTO Get(int id)
        {
            var recipe = _db.GetRecipeRepo.Get(id);
            return _mapper.Map<Recipe, RecipeDTO>(recipe);
        }

        public void Add(RecipeDTO entity)
        {
            Recipe recipe = _mapper.Map<Recipe>(entity);
            _db.GetRecipeRepo.Add(recipe);
            _db.Save();
        }

        public void Delete(int id)
        {
            _db.GetRecipeRepo.Delete(id);
        }

        public void Update(RecipeDTO entity)
        {
            //
            Recipe recipe = _mapper.Map<Recipe>(entity);
            _db.GetRecipeRepo.Update(recipe);
            _db.Save();
        }
    }
}
