using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Business_Logic.DTO
{
    public class RecipeDTOFull
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public TimeSpan MakeTime { get; set; }
        public Uri Image { get; set; }
        public DateTime CreationDate { get; set; }
        public string DescriptionShort { get; set; }
        public string DescriptionFull { get; set; }
        public double Nutritions { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
        public double Proteins { get; set; }
    }
}
