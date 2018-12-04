using System.Collections.Generic;
using System.Linq;
using Eggplant.Application.Interfaces.Persistence;

namespace Eggplant.Application.Recipes.Queries
{
    public class GetRecipesListQuery : IGetRecipesListQuery
    {
        private readonly IRecipeRepository _repository;

        public GetRecipesListQuery(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public List<RecipeModel> Execute()
        {
            var recipes = _repository.GetAll()
                .Select(e => new RecipeModel
                {
                    Id = e.Id,
                    Name = e.Name                    
                });

            return recipes.ToList();
        }
    }
}