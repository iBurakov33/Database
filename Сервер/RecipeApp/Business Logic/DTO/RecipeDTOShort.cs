﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Business_Logic.DTO
{
    public class RecipeDTOShort
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public TimeSpan MakeTime { get; set; }
        public Uri Image { get; set; }
        public string DescriptionShort { get; set; }
    }
}
