﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Business_Logic.DTO
{
    public class UserDTO
    {
        public Guid id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public bool AdminRole { get; set; }
        public string Password { get; set; }
    }
}
