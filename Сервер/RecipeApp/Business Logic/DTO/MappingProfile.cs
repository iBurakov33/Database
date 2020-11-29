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
            CreateMap<Recipe_Ingredient, Recipe_IngredientDTO>();
            CreateMap<Recipe_Type, Recipe_TypeDTO>();
            CreateMap<Measurement, MeasurementDTO>();

            CreateMap<Data_Access.Models.Type, TypeDTO>().ReverseMap();
            CreateMap<Ingredient, IngredientDTO>().ReverseMap();
            CreateMap<Recipe, RecipeDTO>().ReverseMap();
            CreateMap<Recipe_Ingredient, Recipe_IngredientDTO>().ReverseMap();
            CreateMap<Recipe_Type, Recipe_TypeDTO>().ReverseMap();
            CreateMap<Measurement, MeasurementDTO>().ReverseMap();
        }
    }
}
