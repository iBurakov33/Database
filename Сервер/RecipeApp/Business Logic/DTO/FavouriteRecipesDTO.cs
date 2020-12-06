using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Business_Logic.DTO
{
    public class FavouriteRecipesDTO
    {
        public Guid id { get; set; }
        public UserDTO User { get; set; }
        public Guid UserId { get; set; }
        public RecipeDTO Recipe { get; set; }
        public Guid RecipeId { get; set; }
    }
}
