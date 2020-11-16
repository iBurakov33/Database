using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.Interfaces;

namespace RecipeApp.Data_Access.Models
{
    public class Ingredient : IEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Measurement measurement { get; set; }
        public int measurementId { get; set; }
    }
}
