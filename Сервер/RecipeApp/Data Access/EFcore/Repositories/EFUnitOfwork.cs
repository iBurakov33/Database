using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;

namespace RecipeApp.Data_Access.EFcore.Repositories
{
    public class EFUnitOfwork : IUnitOfWork
    {
        private readonly RecipeAppWebApiContext _db;
        private IRepository<Recipe> _recipeRepo;
        private IRepository<Ingredient> _ingredientRepo;
        private IRepository<Models.Type> _typesRepo;
        private IRepository<AmountOfIngredients> _amountRepo;
        
        public EFUnitOfwork(RecipeAppWebApiContext context)
        {
            _db = context;
        }
        public IRepository<Recipe> GetRecipeRepo 
        {
            get
            {
                if (_recipeRepo == null)
                    _recipeRepo = new RecipeRep(_db);
                return _recipeRepo;
            }
        }
        public IRepository<Ingredient> GetIngredientRepo
        {
            get
            {
                if (_ingredientRepo == null)
                    _ingredientRepo = new IngredientRep(_db);
                return _ingredientRepo;
            }
        }
        public IRepository<Models.Type> GetTypeRepo
        {
            get
            {
                if (_typesRepo == null)
                    _typesRepo = new TypesRepo(_db);
                return _typesRepo;
            }
        }

        public IRepository<AmountOfIngredients> GetAmountRepo
        {
            get
            {
                if (_amountRepo == null)
                    _amountRepo = new AmountRepo(_db);
                return _amountRepo;
            }
        }
        
        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;
        /// <summary>
        /// Освобождение выделенных ресурсов для этого контекста
        /// </summary>
        /// <param name="disposing"></param>
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
