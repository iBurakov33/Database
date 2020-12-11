using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Business_Logic.DTO
{
    public class Recipe_TypeDTO
    {
        public Guid id { get; set; }
        public RecipeDTOFull recipe { get; set; }
        public Guid RecipeId { get; set; }
        public TypeDTO type { get; set; }
        public Guid TypeId { get; set; }
    }
}
