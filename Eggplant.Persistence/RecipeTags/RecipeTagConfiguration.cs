using Eggplant.Domain.RecipeTags;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eggplant.Persistence.RecipeTags
{
    public class RecipeTagConfiguration : IEntityTypeConfiguration<RecipeTag>
    {
        public void Configure(EntityTypeBuilder<RecipeTag> builder)
        {
            builder.HasKey(p=> new { p.RecipeId, p.TagId });

            builder.HasOne(p => p.Recipe)
                .WithMany(p => p.RecipeTags)
                .HasForeignKey(p => p.RecipeId);

            builder.HasOne(p => p.Tag)
                .WithMany(p => p.RecipeTags)
                .HasForeignKey(p => p.TagId);
        }
    }
}