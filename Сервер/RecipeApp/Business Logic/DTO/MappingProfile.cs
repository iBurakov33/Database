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
            CreateMap<Recipe, RecipeDTOShort>();
            CreateMap<Recipe_Ingredient, Recipe_IngredientDTO>();
            CreateMap<Recipe_Type, Recipe_TypeDTO>();
            CreateMap<User, UserDTO>();

            CreateMap<Data_Access.Models.Type, TypeDTO>().ReverseMap();
            CreateMap<Ingredient, IngredientDTO>().ReverseMap();
            CreateMap<Recipe, RecipeDTOFull>().ReverseMap();
            CreateMap<Recipe_Ingredient, Recipe_IngredientDTO>().ReverseMap();
            CreateMap<Recipe_Type, Recipe_TypeDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();

        }
    }
}
