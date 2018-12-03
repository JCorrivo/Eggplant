using Eggplant.Domain.Documents;
using Eggplant.Domain.Recipes;
using Eggplant.Domain.Tags;
using Microsoft.EntityFrameworkCore;

namespace Eggplant.Persistence
{
    public interface IEggplantContext
    {
        DbSet<Recipe> Recipes { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<Document> Documents { get; set; }
    }
}