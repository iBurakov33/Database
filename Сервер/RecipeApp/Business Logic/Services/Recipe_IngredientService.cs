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
    public class Recipe_IngredientService : IRecipe_IngredientService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public Recipe_IngredientService(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }
        public void Add(Recipe_IngredientDTO entity)
        {
            Recipe_Ingredient recipe_Ingredient = _mapper.Map<Recipe_Ingredient>(entity);
            _db.GetRecipe_IngredientRepo.Add(recipe_Ingredient);
            _db.Save();
        }

        public void Delete(int id)
        {
            _db.GetRecipe_IngredientRepo.Delete(id);
        }    

        public void Update(Recipe_IngredientDTO entity)
        {
            //
            Recipe_Ingredient recipe_Ingredient = _mapper.Map<Recipe_Ingredient>(entity);
            _db.GetRecipe_IngredientRepo.Update(recipe_Ingredient);
            _db.Save();
        }
        public Recipe_IngredientDTO Get(int id)
        {
            var recipe = _db.GetRecipe_IngredientRepo.Get(id);
            return _mapper.Map<Recipe_Ingredient, Recipe_IngredientDTO>(recipe);
        }
        public IEnumerable<Recipe_IngredientDTO> GetAll()
        {
            var recipes = _db.GetRecipe_IngredientRepo.GetAll();
            return _mapper.Map<IEnumerable<Recipe_Ingredient>, IEnumerable<Recipe_IngredientDTO>>(recipes);
        }
    }
}
