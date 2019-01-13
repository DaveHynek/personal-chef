using System.ComponentModel.DataAnnotations;

namespace PersonalChef.Data.Models.Recipes
{
    public class RecipeIngredient
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Amount of the ingredient.  Combines with the <see cref="Unit"/> property for context.
        /// </summary>
        [Required]
        public double Quantity { get; set; }
        /// <summary>
        /// Unit of the ingredient measurement.  Combines with the <see cref="Quantity"/> property for context.
        /// </summary>
        [Required]
        public MeasurementUnit Unit { get; set; }
        /// <summary>
        /// Ingredient that is included in the recipe.
        /// </summary>
        [Required]
        public Ingredient Ingredient { get; set; }
        /// <summary>
        /// Recipe that the ingredient is a component of.
        /// </summary>
        [Required]
        public Recipe Recipe { get; set; }
        
    }
}
