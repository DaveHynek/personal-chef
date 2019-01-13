using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalChef.Data.Models.Recipes
{
    public class Recipe
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Name of the <see cref="Recipe"/>
        /// </summary>
        [Required]
        [StringLength(128)]
        [Display(Name="Recipe Name")]
        public string Name { get; set; }
        /// <summary>
        /// Description of the <see cref="Recipe"/>
        /// </summary>
        [Required]
        [StringLength(512)]
        [Display(Name = "Recipe Description")]
        public string Description { get; set; }
        /// <summary>
        /// Collection of <see cref="RecipeIngredient"/>s associated with the <see cref="Recipe"/>
        /// </summary>
        public List<RecipeIngredient> RecipeIngredients { get; set; }
        /// <summary>
        /// Collection of <see cref="RecipeStep"/>s associated with the <see cref="Recipe"/>
        /// </summary>
        public List<RecipeStep> RecipeSteps { get; set; }
    }
}
