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
    public class DeleteRecipeModel : PageModel
    {
        private readonly IRecipeService _service;
        [BindProperty]
        public RecipeDTO recipe { get; set; }
        public DeleteRecipeModel(IRecipeService db)
        {
            _service = db;
        }
        public void OnGet(Guid id)
        {
            recipe = _service.Get(id);
            //if (recipe == null)
            //{
            //    return NotFound();
            //}
            //return Page();
        }
        public IActionResult OnPost(Guid id)
        {
            _service.Delete(id);

            return RedirectToPage("Index");
        }
    }
}
