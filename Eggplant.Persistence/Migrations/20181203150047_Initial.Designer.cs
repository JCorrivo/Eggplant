﻿// <auto-generated />
using System;
using Eggplant.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eggplant.Persistence.Migrations
{
    [DbContext(typeof(EggplantContext))]
    [Migration("20181203150047_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Eggplant.Domain.Documents.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Eggplant.Domain.Recipes.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DocumentId");

                    b.Property<int>("DocumentPage");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Eggplant.Domain.RecipeTags.RecipeTag", b =>
                {
                    b.Property<int>("RecipeId");

                    b.Property<int>("TagId");

                    b.HasKey("RecipeId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("RecipeTags");
                });

            modelBuilder.Entity("Eggplant.Domain.Tags.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Eggplant.Domain.Recipes.Recipe", b =>
                {
                    b.HasOne("Eggplant.Domain.Documents.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId");
                });

            modelBuilder.Entity("Eggplant.Domain.RecipeTags.RecipeTag", b =>
                {
                    b.HasOne("Eggplant.Domain.Recipes.Recipe", "Recipe")
                        .WithMany("RecipeTags")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Eggplant.Domain.Tags.Tag", "Tag")
                        .WithMany("RecipeTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
