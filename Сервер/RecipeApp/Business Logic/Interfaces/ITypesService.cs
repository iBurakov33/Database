using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Business_Logic.DTO;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface ITypesService
    {
        void Add(TypeDTO entity);
        void Delete(Guid id);
        TypeDTO Get(Guid id);
        TypeDTO GetByName(string name);
        IEnumerable<TypeDTO> GetAll();
        void Update(TypeDTO entity);
    }
}
