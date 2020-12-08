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
        public Guid id { get; set; }
        public Recipe Recipe { get; set; }
        public Guid RecipeId { get; set; }
        public Ingredient Ingredient { get; set; }
        public Guid IngredientId { get; set; }
        public string Quantity { get; set; }
    }
}
