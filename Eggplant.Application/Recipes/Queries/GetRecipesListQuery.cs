using System.Collections.Generic;
using System.Linq;
using Eggplant.Application.Interfaces.Persistence;
using Eggplant.Domain.Recipes;

namespace Eggplant.Application.Recipes.Queries
{
    public class GetRecipesListQuery : IGetRecipesListQuery
    {
        private readonly IReadOnlyRepository<Recipe> _repository;

        public GetRecipesListQuery(IReadOnlyRepository<Recipe> repository)
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