using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Data_Access.Interfaces
{
    public interface IEntity
    {
        public Guid id { get; set; }
    }
}
