using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Business_Logic.Interfaces
{
    public interface IService <TIng, TRec, Ttype, TAmount>
        where TIng : class
        where TRec : class
        where Ttype : class
    {
        TIng GetIng(int id);
        IEnumerable<TRec> GetAllRecipes();
        TRec GetRecipe(int id);
        Ttype GetTtype(int id);
        IEnumerable<TAmount> GetAllAmount();
        TAmount GetOneRecipe(int id);
    }
}
