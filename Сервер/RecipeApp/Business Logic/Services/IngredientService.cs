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
    public class IngredientService : IIngredientService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public IngredientService(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }
        public void Add(IngredientDTO entity)
        {
            Ingredient ingredient = _mapper.Map<Ingredient>(entity);
            _db.GetIngredientRepo.Add(ingredient);
            _db.Save();
        }

        public void Delete(Guid id)
        {
            _db.GetIngredientRepo.Delete(id);
        }

        public IngredientDTO Get(Guid id)
        {
            var ingredient = _db.GetIngredientRepo.Get(id);
            return _mapper.Map<Ingredient, IngredientDTO>(ingredient);
        }

        public IEnumerable<IngredientDTO> GetAll()
        {
            var ingredient = _db.GetIngredientRepo.GetAll();
            return _mapper.Map<IEnumerable<Ingredient>, IEnumerable<IngredientDTO>>(ingredient);
        }

        public IngredientDTO GetByName(string name)
        {
            var ingredient = _db.GetIngredientRepo.GetByName(name);
            return _mapper.Map<Ingredient, IngredientDTO>(ingredient);
        }

        public void Update(IngredientDTO entity)
        {
            Ingredient ingredient = _mapper.Map<Ingredient>(entity);
            _db.GetIngredientRepo.Update(ingredient);
            _db.Save();
        }
    }
}
