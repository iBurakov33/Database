using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.Interfaces;

namespace RecipeApp.Data_Access.Models
{
    public class FavouriteRecipes : IEntity
    {
        public Guid id { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Recipe Recipe { get; set; }
        public Guid RecipeId { get; set; }
    }
}
