using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore
{
    public class RecipeAppWebApiContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeApp.Data_Access.Models.Type> Types { get; set; }
        public DbSet<AmountOfIngredients> AmountOfIngredients { get; set; }
        public RecipeAppWebApiContext(DbContextOptions<RecipeAppWebApiContext> options)
            : base(options)
        { 
        
        }

    }
}
