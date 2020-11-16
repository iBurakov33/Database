using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Business_Logic.DTO
{
    public class Recipe_TypeDTO
    {
        public int id { get; set; }
        public RecipeDTO recipe { get; set; }
        public int RecipeId { get; set; }
        public TypeDTO type { get; set; }
        public int TypeId { get; set; }
    }
}
