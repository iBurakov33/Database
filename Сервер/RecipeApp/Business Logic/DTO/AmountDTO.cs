using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Business_Logic.DTO
{
    public class AmountDTO
    {
        public int id { get; set; }
        public Recipe recipe { get; set; }
        public Ingredient ingredient { get; set; }
        public int NumberOfIngredients { get; set; }
    }
}
