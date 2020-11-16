using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Business_Logic.DTO
{
    public class Recipe_IngredientDTO
    {
        public int id { get; set; }
        public Recipe_TypeDTO Recipe_Type { get; set; }
        public int recipe_typeId { get; set; }
        public IngredientDTO Ingredient { get; set; }
        public int ingredientId { get; set; }
        public int Quantity { get; set; }
    }
}
