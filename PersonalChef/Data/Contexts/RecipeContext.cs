using Microsoft.EntityFrameworkCore;
using PersonalChef.Data.Models.Recipes;
using System;
using System.Collections.Generic;

namespace PersonalChef.Data.Contexts
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MeasurementUnit>().HasData(GetMeasurementUnits());
        }
        
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeStep> RecipeSteps { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }

        private IEnumerable<MeasurementUnit> GetMeasurementUnits()
        {
            foreach (Common.Units u in Enum.GetValues(typeof(Common.Units)))
            {
                yield return new MeasurementUnit(u);
            }
        }
    }
}
