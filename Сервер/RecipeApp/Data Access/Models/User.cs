using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApp.Data_Access.Interfaces;

namespace RecipeApp.Data_Access.Models
{
    public class User : IEntity
    {
        public Guid id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public bool AdminRole { get; set; }
        public string Password { get; set; }
    }
}
