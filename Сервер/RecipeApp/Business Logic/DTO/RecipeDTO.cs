using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Business_Logic.DTO
{
    public class RecipeDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime MakeTime { get; set; }
        public string Description { get; set; }
    }
}
