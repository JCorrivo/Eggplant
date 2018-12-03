using System.Collections.Generic;
using Eggplant.Domain.Common;
using Eggplant.Domain.RecipeTags;

namespace Eggplant.Domain.Tags
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RecipeTag> RecipeTags { get; set; }

    }
}