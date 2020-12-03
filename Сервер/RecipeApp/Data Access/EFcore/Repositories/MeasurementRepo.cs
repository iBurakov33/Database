﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;


namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class MeasurementRepo : IRepository<Measurement>
    {
        private readonly RecipeAppWebApiContext _context;
        public MeasurementRepo(RecipeAppWebApiContext context)
        {
            _context = context;
        }
        public void Add(Measurement entity)
        {
            _context.Add(entity);
        }

        public void AddDefault(Measurement entity, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            Measurement entity = _context.Measurments.Find(id);
            if (entity != null)
                _context.Measurments.Remove(entity);
        }

        public Measurement Get(Guid id)
        {
            return _context.Measurments.Find(id);
        }

        public IEnumerable<Measurement> GetAll()
        {
            return _context.Measurments;
        }

        public Measurement GetByName(string name)
        {
            return _context.Measurments.Find(name);
        }

        public void Update(Measurement entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
