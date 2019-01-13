﻿using System.ComponentModel.DataAnnotations;

namespace PersonalChef.Data.Models.Recipes
{
    public class Ingredient
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Name of the <see cref="Ingredient"/>
        /// </summary>
        [Required]
        [StringLength(128)]
        [Display(Name = "Ingredient Name")]
        public string Name { get; set; }
        /// <summary>
        /// Description of the <see cref="Ingredient"/>
        /// </summary>
        [Required]
        [StringLength(512)]
        [Display(Name = "Ingredient Description")]
        public string Description { get; set; }

    }
}
