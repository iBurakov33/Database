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
    public class MeasurementService : IMeasurmentService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public MeasurementService(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }
        public void Add(MeasurementDTO entity)
        {
            Measurement measurement = _mapper.Map<Measurement>(entity);
            _db.GetMeasurmentRepo.Add(measurement);
            _db.Save();
        }

        public void Delete(int id)
        {
            _db.GetMeasurmentRepo.Delete(id);
        }

        public MeasurementDTO Get(int id)
        {
            var measurement = _db.GetMeasurmentRepo.Get(id);
            return _mapper.Map<Measurement, MeasurementDTO>(measurement);
        }

        public IEnumerable<MeasurementDTO> GetAll()
        {
            var measurement = _db.GetMeasurmentRepo.GetAll();
            return _mapper.Map<IEnumerable<Measurement>, IEnumerable<MeasurementDTO>>(measurement);
        }

        public void Update(MeasurementDTO entity)
        {
            Measurement measurement = _mapper.Map<Measurement>(entity);
            _db.GetMeasurmentRepo.Update(measurement);
            _db.Save();
        }
    }
}
