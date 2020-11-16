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
    public class Recipe_TypeService : IRecipe_TypeService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public Recipe_TypeService(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }
        public void Add(Recipe_TypeDTO entity)
        {
            Recipe_Type recipe_Type = _mapper.Map<Recipe_Type>(entity);
            _db.GetRecipe_TypeRepo.Add(recipe_Type);
            _db.Save();
        }

        public void Delete(int id)
        {
            _db.GetRecipe_TypeRepo.Delete(id);
        }

        public void Update(Recipe_TypeDTO entity)
        {
            Recipe_Type recipe_Type = _mapper.Map<Recipe_Type>(entity);
            _db.GetRecipe_TypeRepo.Update(recipe_Type);
            _db.Save();
        }

        public Recipe_TypeDTO Get(int id)
        {
            var recipe_type = _db.GetRecipe_TypeRepo.Get(id);
            return _mapper.Map<Recipe_Type, Recipe_TypeDTO>(recipe_type);
        }

        public IEnumerable<Recipe_TypeDTO> GetAll()
        {
            var recipe_type = _db.GetRecipe_TypeRepo.GetAll().OrderByDescending(recipe_type => recipe_type.recipe.MakeTime);
            return _mapper.Map<IEnumerable<Recipe_Type>, IEnumerable<Recipe_TypeDTO>>(recipe_type);
        }
    }
}
