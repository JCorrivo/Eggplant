using Eggplant.Domain.Common;
using Eggplant.Domain.Documents;
using Eggplant.Domain.Recipes;
using Eggplant.Domain.RecipeTags;
using Eggplant.Domain.Tags;
using Eggplant.Persistence.Documents;
using Eggplant.Persistence.Recipes;
using Eggplant.Persistence.RecipeTags;
using Eggplant.Persistence.Tags;
using Microsoft.EntityFrameworkCore;

namespace Eggplant.Persistence
{
    public class EggplantContext : DbContext, IEggplantContext
    {
        public EggplantContext(DbContextOptions<EggplantContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeTagConfiguration());
        }

        public void Save()
        {
            this.SaveChanges();
        }

        public new DbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }

        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<RecipeTag> RecipeTags { get; set; }
    }
}