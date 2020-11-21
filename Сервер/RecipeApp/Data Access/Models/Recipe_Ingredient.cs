﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;

namespace RecipeApp.Data_Access.Models
{
    public class Recipe_Ingredient : IEntity
    {
        public int id { get; set; }
        public Recipe_Type Recipe_Type { get; set; }
        public int Recipe_TypeId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
    }
}
