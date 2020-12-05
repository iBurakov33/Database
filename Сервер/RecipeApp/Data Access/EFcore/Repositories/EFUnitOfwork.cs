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
        private IRepository<Recipe_Ingredient> _recipe_ingredientRepo;
        private IRepository<Recipe_Type> _recipe_typeRepo;
        private IRepository<Measurement> _measurementRepo;
        private IUserRepository _userRepo;
        
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
                    _ingredientRepo = new IngredientRepo(_db);
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

        public IRepository<Recipe_Ingredient> GetRecipe_IngredientRepo
        {
            get
            {
                if (_recipe_ingredientRepo == null)
                    _recipe_ingredientRepo = new Recipe_IngredientRepo(_db);
                return _recipe_ingredientRepo;
            }
        }

        public IRepository<Recipe_Type> GetRecipe_TypeRepo
        {
            get
            {
                if (_recipe_typeRepo == null)
                    _recipe_typeRepo = new Recipe_TypesRepo(_db);
                return _recipe_typeRepo;
            }
        }

        public IRepository<Measurement> GetMeasurmentRepo
        {
            get
            {
                if (_measurementRepo == null)
                    _measurementRepo = new MeasurementRepo(_db);
                return _measurementRepo;
            }
        }

        public IUserRepository GetUsersRepo
        {
            get
            {
                if (_userRepo == null)
                    _userRepo = new UsersRepo(_db);
                return _userRepo;
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
