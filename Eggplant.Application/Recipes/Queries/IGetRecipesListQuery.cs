using System.Collections.Generic;

namespace Eggplant.Application.Recipes.Queries
{
    public interface IGetRecipesListQuery
    {
         List<RecipeModel> Execute();
    }
}