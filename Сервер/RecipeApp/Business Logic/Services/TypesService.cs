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
    public class TypesService : ITypesService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public TypesService(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }
        public void Add(TypeDTO entity)
        {
            Data_Access.Models.Type type = _mapper.Map<TypeDTO, Data_Access.Models.Type>(entity);
            _db.GetTypeRepo.Add(type);
            _db.Save();
        }

        public void Delete(Guid id)
        {
            _db.GetTypeRepo.Delete(id);
        }

        public TypeDTO Get(Guid id)
        {
            var type = _db.GetTypeRepo.Get(id);
            return _mapper.Map<Data_Access.Models.Type, TypeDTO>(type);
        }

        public IEnumerable<TypeDTO> GetAll()
        {
            var type = _db.GetTypeRepo.GetAll();
            return _mapper.Map<IEnumerable<Data_Access.Models.Type>, IEnumerable<TypeDTO>>(type);
        }

        public TypeDTO GetByName(string name)
        {
            var type = _db.GetTypeRepo.GetByName(name);
            return _mapper.Map<Data_Access.Models.Type, TypeDTO>(type);
        }

        public void Update(TypeDTO entity)
        {
            //
            Data_Access.Models.Type type = _mapper.Map<Data_Access.Models.Type>(entity);
            _db.GetTypeRepo.Update(type);
            _db.Save();
        }
    }
}
