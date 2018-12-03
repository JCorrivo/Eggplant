using System.Collections.Generic;
using Eggplant.Domain.Common;
using Eggplant.Domain.Documents;
using Eggplant.Domain.RecipeTags;

namespace Eggplant.Domain.Recipes
{
    public class Recipe : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Document Document { get; set; }
        public int DocumentPage { get; set; }
        public ICollection<RecipeTag> RecipeTags { get; set; }
    }
}