using System.Collections.Generic;
using System.Linq;

namespace Eggplant.Application.Recipes.Queries
{
    public interface IGetRecipesListQuery
    {
         IQueryable<RecipeModel> Execute();
    }
}