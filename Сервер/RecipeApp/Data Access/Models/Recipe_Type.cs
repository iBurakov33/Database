using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;

namespace RecipeApp.Data_Access.Models
{
    public class Recipe_Type : IEntity
    {
        public Guid id { get; set; }
        public Recipe recipe { get; set; }
        public Guid RecipeId { get; set; }
        public Type type { get; set; }
        public Guid TypeId { get; set; }
    }
}
