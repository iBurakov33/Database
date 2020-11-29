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
            //using var context = new RecipeAppWebApiContext(
            //    serviceProvider.GetRequiredService<
            //        DbContextOptions<RecipeAppWebApiContext>>());
            //if (context.Recipes_Ingredients.Any())
            //{
            //    return;
            //}

            //context.Measurments.Add(new Measurement
            //{
            //    id = 1,
            //    Name = "г"
            //});

            //context.Measurments.Add(new Measurement
            //{
            //    id = 2,
            //    Name = "шт."
            //});

            //context.Measurments.Add(new Measurement
            //{
            //    id = 3,
            //    Name = "ст. л."
            //});

            //context.Types.Add(new Type 
            //{   
            //    id = 1, 
            //    Name = "Завтрак" 
            //});

            //context.Ingredients.Add(new Ingredient
            //{   
            //    id = 1, 
            //    Name = "Творог", 
            //    measurementId = 1 
            //});
            //context.Ingredients.Add(new Ingredient 
            //{ 
            //    id = 2, 
            //    Name = "Куриное яйцо",
            //    measurementId = 2
            //});
            //context.Ingredients.Add(new Ingredient 
            //{ 
            //    id = 3, 
            //    Name = "Пшеничная мука",
            //    measurementId = 3
            //});
            //context.Ingredients.Add(new Ingredient 
            //{ 
            //    id = 4, 
            //    Name = "Сахар",
            //    measurementId = 3
            //});
            //context.Ingredients.Add(new Ingredient 
            //{ 
            //    id = 5, 
            //    Name = "Подсолнечное масло",
            //    measurementId = 3
            //});

            //context.Recipes.Add(new Recipe 
            //{ 
            //    id = 1,
            //    Name = "Сырники из творога", 
            //    MakeTime = new TimeSpan(0,30,0), 
            //    Description = "Главный секрет идеальных сырников — а точнее творожников, — творог нужно протереть через мелкое сито и отжать от влаги. Жирность предпочтительна не больше и не меньше 9%. Тесто должно получиться эластичным, чтобы при надавливании сырник не треснул на сковородке, а сохранил форму. Если все сделать правильно, получатся нежные однородные кругляшки под плотной румяной корочкой. Сырники можно запекать в духовке или готовить на пару. В рецепте не исключаются эксперименты с начинкой — сухофрукты, орехи, свежие фрукты и даже картофель лишними не будут." 
            //});

            //context.Recipes_Ingredients.Add(new Recipe_Ingredient 
            //{ 
            //    id = 1,
            //    RecipeId = 1, 
            //    IngredientId = 1, 
            //    Quantity = 500 
            //});
            //context.Recipes_Ingredients.Add(new Recipe_Ingredient
            //{
            //    id = 2,
            //    RecipeId = 1,
            //    IngredientId = 2,
            //    Quantity = 2
            //});
            //context.Recipes_Ingredients.Add(new Recipe_Ingredient
            //{
            //    id = 3,
            //    RecipeId = 1,
            //    IngredientId = 3,
            //    Quantity = 6
            //});
            //context.Recipes_Ingredients.Add(new Recipe_Ingredient
            //{
            //    id = 4,
            //    RecipeId = 1,
            //    IngredientId = 4,
            //    Quantity = 2
            //});
            //context.Recipes_Ingredients.Add(new Recipe_Ingredient
            //{
            //    id = 5,
            //    RecipeId = 1,
            //    IngredientId = 5,
            //    Quantity = 5
            //});
        }
    }
}
