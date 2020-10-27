using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;

namespace RecipeApp.Data_Access.Models
{
    public class AmountOfIngredients : IEntity
    {
        public int id { get; set; }
        public Recipe recipe { get; set; }
        public Ingredient ingredient { get; set; }
        public int NumberOfIngredients { get; set; }
    }
}
