using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;

namespace RecipeApp.Data_Access.Models
{
    public class Recipe_Ingredient : IEntity
    {
        public int id { get; set; }
        public Recipe_Type recipe_type { get; set; }
        public int recipe_typeId { get; set; }
        public Ingredient ingredient { get; set; }
        public int ingredientId { get; set; }
        public int Quantity { get; set; }
    }
}
