using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.EFcore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RecipeApp.Data_Access.Models
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new RecipeAppWebApiContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RecipeAppWebApiContext>>());
            if (context.AmountOfIngredients.Any())
            {
                return;
            }

            context.Types.Add(new Type { id = 1, Name = "Завтрак" });

            context.Ingredients.Add(new Ingredient { id = 1, Name = "Творог", Measurement = "г"});
            context.Ingredients.Add(new Ingredient { id = 1, Name = "Творог", Measurement = "г" });
        }
    }
}
