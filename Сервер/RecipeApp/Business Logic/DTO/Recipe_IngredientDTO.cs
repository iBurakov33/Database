using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Business_Logic.DTO
{
    public class Recipe_IngredientDTO
    {
        public Guid id { get; set; }
        public RecipeDTO Recipe { get; set; }
        public Guid RecipeId { get; set; }
        public IngredientDTO Ingredient { get; set; }
        public Guid IngredientId { get; set; }
        public string Quantity { get; set; }
    }
}
