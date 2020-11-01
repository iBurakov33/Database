using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Business_Logic.DTO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data_Access.Models.Type, TypeDTO>();
            CreateMap<Ingredient, IngredientDTO>();
            CreateMap<Recipe, RecipeDTO>();
            CreateMap<AmountOfIngredients, AmountDTO>();
            
        }
    }
}
