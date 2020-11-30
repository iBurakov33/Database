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
    public class AddTypeModel : PageModel
    {
        private readonly IRecipe_TypeService _service;
        [BindProperty]
        public Recipe_TypeDTO type { get; set; }
        public AddTypeModel(IRecipe_TypeService db)
        {
            _service = db;
        }

        public void OnGet(Guid Rid)
        {
            //_service.AddDefault(type, Rid);
        }
        public IActionResult OnPost()//Guid Rid)
        {
            if (ModelState.IsValid)
            {
                //type.RecipeId = Rid;
                _service.Add(type);
                return Redirect("Index");
            }
            return Page();
        }
    }
}
