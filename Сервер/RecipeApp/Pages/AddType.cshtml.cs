using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeApp.Business_Logic.DTO;
using RecipeApp.Business_Logic.Interfaces;

namespace RecipeApp.Pages
{
    [BindProperties]
    public class AddTypeModel : BaseLayoutPageModel
    {
        private readonly IRecipe_TypeService _service;
        private readonly IRecipeService _recipeService;
        private readonly ITypesService _typesService;
        public Recipe_TypeDTO type { get; set; }
        public RecipeDTO recipe { get; set; }
        public TypeDTO typeMain { get; set; }
        public string typeName { get; set; }
        public AddTypeModel(IRecipe_TypeService db, IRecipeService dbR, ITypesService dbT)
        {
            _service = db;
            _recipeService = dbR;
            _typesService = dbT;
        }

        public void OnGet(Guid id)
        {
            recipe = _recipeService.Get(id);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                type.RecipeId = recipe.id;
                typeMain = _typesService.GetByName(typeName);
                type.TypeId = typeMain.id;
                _service.Add(type);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
