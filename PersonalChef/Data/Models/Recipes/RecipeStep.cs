using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalChef.Data.Models.Recipes
{
    public class RecipeStep
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Written description of the action to take for this step of the recipe.
        /// </summary>
        [Required]
        [StringLength(512)]
        public string Text { get; set; }
        /// <summary>
        /// Order of the step for a given recipe.
        /// </summary>
        /// <remarks>This field is not sequential to minimize database updates needed to
        /// change the order of the steps.  By default steps should be set in increments
        /// of 1000, and upon re-order will be set to the average of the two steps
        /// they are inserted between.</remarks>
        [Required]
        public int Order { get; set; }
        /// <summary>
        /// Recipe that the step is included in.
        /// </summary>
        [Required]
        public Recipe Recipe { get; set; }
    }
}
