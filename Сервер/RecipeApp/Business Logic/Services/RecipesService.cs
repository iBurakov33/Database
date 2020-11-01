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
    public class RecipesService : IService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;
        public RecipesService(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }

        public IEnumerable<AmountDTO> GetAllAmount()
        {
            var recipes = _db.GetAmountRepo.GetAll();//.OrderByDescending(recipes => recipes.recipe.MakeTime);
            return _mapper.Map<IEnumerable<AmountOfIngredients>, IEnumerable<AmountDTO>>(recipes);
        }

        public IEnumerable<RecipeDTO> GetAllRecipes()
        {
            var recipes = _db.GetRecipeRepo.GetAll().OrderByDescending(recipes => recipes.MakeTime);
            return _mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipeDTO>>(recipes);
        }

        public IngredientDTO GetIng(int id)
        {
            var ingredient = _db.GetIngredientRepo.Get(id);
            return _mapper.Map<Ingredient, IngredientDTO>(ingredient);
        }

        public AmountDTO GetOneRecipe(int id)
        {
            var recipe = _db.GetAmountRepo.Get(id);
            return _mapper.Map<AmountOfIngredients, AmountDTO>(recipe);
        }

        public RecipeDTO GetRecipe(int id)
        {
            var recipe = _db.GetRecipeRepo.Get(id);
            return _mapper.Map<Recipe, RecipeDTO>(recipe);
        }

        public TypeDTO GetType(int id)
        {
            var type = _db.GetTypeRepo.Get(id);
            return _mapper.Map<Data_Access.Models.Type, TypeDTO>(type);
        }
    }
}
