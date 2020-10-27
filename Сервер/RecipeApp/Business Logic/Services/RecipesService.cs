using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Business_Logic.Interfaces;
using RecipeApp.Business_Logic.DTO;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.EFcore;
using RecipeApp.Data_Access.Models;
using AutoMapper;

namespace RecipeApp.Business_Logic.Services
{
    public class RecipesService : IService<IngredientDTO, RecipeDTO,  TypeDTO, AmountDTO>
    {
        private readonly IUnitOfWork _db;
        public RecipesService(IUnitOfWork entity)
        {
            _db = entity;
        }

        public IEnumerable<AmountDTO> GetAllAmount()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecipeDTO> GetAllRecipes()
        {
            throw new NotImplementedException();
        }

        public IngredientDTO GetIng(int id)
        {
            throw new NotImplementedException();
        }

        public AmountDTO GetOneRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public RecipeDTO GetRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public TypeDTO GetTtype(int id)
        {
            throw new NotImplementedException();
        }
    }
}
