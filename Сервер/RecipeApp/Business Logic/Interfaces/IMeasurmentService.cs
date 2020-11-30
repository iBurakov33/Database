using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IMeasurmentService
    {
        void Add(MeasurementDTO entity);
        void Delete(Guid id);
        MeasurementDTO Get(Guid id);
        IEnumerable<MeasurementDTO> GetAll();
        void Update(MeasurementDTO entity);
    }
}
