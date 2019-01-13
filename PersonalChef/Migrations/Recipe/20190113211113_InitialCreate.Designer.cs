﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalChef.Data.Contexts;

namespace PersonalChef.Migrations.Recipe
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20190113211113_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonalChef.Data.Models.Recipes.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("ID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("PersonalChef.Data.Models.Recipes.MeasurementUnit", b =>
                {
                    b.Property<int>("Unit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Unit");

                    b.ToTable("MeasurementUnits");

                    b.HasData(
                        new
                        {
                            Unit = 1,
                            Name = "Cup"
                        },
                        new
                        {
                            Unit = 2,
                            Name = "Pint"
                        },
                        new
                        {
                            Unit = 3,
                            Name = "Quart"
                        },
                        new
                        {
                            Unit = 4,
                            Name = "Gallon"
                        },
                        new
                        {
                            Unit = 5,
                            Name = "Milliliter"
                        },
                        new
                        {
                            Unit = 6,
                            Name = "Liter"
                        },
                        new
                        {
                            Unit = 7,
                            Name = "Teaspoon"
                        },
                        new
                        {
                            Unit = 8,
                            Name = "Tablespoon"
                        },
                        new
                        {
                            Unit = 9,
                            Name = "FluidOunce"
                        },
                        new
                        {
                            Unit = 10,
                            Name = "Pound"
                        },
                        new
                        {
                            Unit = 11,
                            Name = "Ounce"
                        },
                        new
                        {
                            Unit = 12,
                            Name = "Milligram"
                        },
                        new
                        {
                            Unit = 13,
                            Name = "Gram"
                        },
                        new
                        {
                            Unit = 14,
                            Name = "Kilogram"
                        },
                        new
                        {
                            Unit = 15,
                            Name = "Millimeter"
                        },
                        new
                        {
                            Unit = 16,
                            Name = "Centimeter"
                        },
                        new
                        {
                            Unit = 17,
                            Name = "Meter"
                        },
                        new
                        {
                            Unit = 18,
                            Name = "Inch"
                        });
                });

            modelBuilder.Entity("PersonalChef.Data.Models.Recipes.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("ID");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("PersonalChef.Data.Models.Recipes.RecipeIngredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredientID");

                    b.Property<double>("Quantity");

                    b.Property<int>("RecipeID");

                    b.Property<int>("Unit1");

                    b.HasKey("ID");

                    b.HasIndex("IngredientID");

                    b.HasIndex("RecipeID");

                    b.HasIndex("Unit1");

                    b.ToTable("RecipeIngredient");
                });

            modelBuilder.Entity("PersonalChef.Data.Models.Recipes.RecipeStep", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Order");

                    b.Property<int>("RecipeID");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.HasKey("ID");

                    b.HasIndex("RecipeID");

                    b.ToTable("RecipeSteps");
                });

            modelBuilder.Entity("PersonalChef.Data.Models.Recipes.RecipeIngredient", b =>
                {
                    b.HasOne("PersonalChef.Data.Models.Recipes.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PersonalChef.Data.Models.Recipes.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PersonalChef.Data.Models.Recipes.MeasurementUnit", "Unit")
                        .WithMany()
                        .HasForeignKey("Unit1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PersonalChef.Data.Models.Recipes.RecipeStep", b =>
                {
                    b.HasOne("PersonalChef.Data.Models.Recipes.Recipe", "Recipe")
                        .WithMany("RecipeSteps")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
